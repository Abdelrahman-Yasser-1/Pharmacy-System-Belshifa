using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace Belshifa
{
    public partial class UserForm : Form
    {
        private static User user;
        public static FlowLayoutPanel flowLayoutPanel1;
        public static Label label100;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public UserForm(User user1)
        {
            InitializeComponent();
            user = user1;
        }
        
        public UserForm()
        {
            InitializeComponent();
        }

        public void GetHomeProduct() {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllProducts";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("products", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            #region GUI
            flowLayoutPanel_home.AutoScroll = true;
            flowLayoutPanel_home.Controls.Clear();
            #endregion

            while (dr.Read())
            {
                int id = int.Parse(dr["product_id"].ToString());
                string name = dr["product_name"].ToString();
                int price = int.Parse(dr["product_price"].ToString());
                string usage = dr["product_usage"].ToString();

                Product product = new Product(id, name, usage, price);
                flowLayoutPanel_home.Controls.Add(new ProductItem(product, user.Id));

            }

        }

        public void GetCartProduct()
        {
            #region GUI
            flowLayoutPanel_cart.AutoScroll = true;
            flowLayoutPanel_cart.Controls.Clear();
            #endregion

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select * from CART where userID = :user_id";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("user_id", user.Id);
            OracleDataReader dr = cmd1.ExecuteReader();
            
            int totalPrice = 0;
            while (dr.Read())
            {
                int id = int.Parse(dr["product_id"].ToString());
                int amount = int.Parse(dr["number_of_items"].ToString());
                string name = dr["product_name"].ToString();
                int price = int.Parse(dr["product_price"].ToString());
                string usage = dr["product_usage"].ToString();
                int userId = int.Parse(dr["userID"].ToString());
                totalPrice += price * amount;
                Product product = new Product(id, name, usage, price);
                Cart cart = new Cart(userId, amount, product);
                flowLayoutPanel_cart.Controls.Add(new CartItem(cart));
            }
            label_total_price.Text = totalPrice.ToString() + " $";
        }

        public void GetSerchProduct(string text)
        {
            if (txt_search.Text.ToString() != null)
            {
                #region GUI
                flowLayoutPanel_search.AutoScroll = true;
                flowLayoutPanel_search.Controls.Clear();
                #endregion

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from PRODUCTS where product_name like" + "'%" + text + "%'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = int.Parse(dr["product_id"].ToString());
                    string name = dr["product_name"].ToString();
                    int price = int.Parse(dr["product_price"].ToString());
                    string usage = dr["product_usage"].ToString();

                    Product product = new Product(id, name, usage, price);
                    flowLayoutPanel_search.Controls.Add(new ProductItem(product, user.Id));
                }
                dr.Close();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            label_uasername.Text = user.Name;
            flowLayoutPanel1 = flowLayoutPanel_cart;
            label100 = label_total_price;

            conn = new OracleConnection(ordb);
            conn.Open();
            
            ProductItem con = new ProductItem();
            Controls.Add(con);
            con.Dock = DockStyle.Fill;

            panel_cart.Visible = false;
            panel_search.Visible = false;
            panel_home.Visible = true;

            GetHomeProduct();
            GetCartProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_cart.Controls.Clear();
            GetCartProduct();
            panel_cart.Visible = true;
            panel_search.Visible = false;
            panel_home.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_cart.Visible = false;
            panel_search.Visible = false;
            panel_home.Visible = true;
        }

        private void pictureBox_back_search_Click(object sender, EventArgs e)
        {
            panel_cart.Visible = false;
            panel_search.Visible = false;
            panel_home.Visible = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GetSerchProduct(txt_search.Text.ToString());
            txt_search2.Text = txt_search.Text;
            panel_cart.Visible = false;
            panel_search.Visible = true;
            panel_home.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSerchProduct(txt_search2.Text.ToString());
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (label_total_price.Text != "0 $") 
            {
                //add products in cart to history and delete them from cart
                OracleCommand maxID = new OracleCommand();
                maxID.Connection = conn;
                maxID.CommandText = "select max(id) from HISTORY";
                maxID.CommandType = CommandType.Text;
                OracleDataReader dr1 = maxID.ExecuteReader();
                int history_id = 0;
                while (dr1.Read())
                {
                    history_id = int.Parse(dr1[0].ToString());
                }

                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select * from CART where userID = :user_id";
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.Add("user_id", user.Id);
                OracleDataReader dr = cmd1.ExecuteReader();
                
                while (dr.Read())
                {
                    int id = int.Parse(dr["product_id"].ToString());
                    int amount = int.Parse(dr["number_of_items"].ToString());

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into HISTORY values (:id ,:product_id, :user_id, :buying_date, :amount )";
                    cmd.CommandType = CommandType.Text;
                    history_id++;
                    cmd.Parameters.Add("id", history_id);
                    cmd.Parameters.Add("product_id", id);
                    cmd.Parameters.Add("user_id", user.Id);
                    cmd.Parameters.Add("buying_date", DateTime.Now);
                    cmd.Parameters.Add("amount", amount);
                    cmd.ExecuteNonQuery();

                }
                dr.Close();

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "delete from CART where userID = :user_id";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("user_id", user.Id);
                cmd2.ExecuteNonQuery();
                flowLayoutPanel_cart.Controls.Clear();
                label_total_price.Text = "0 $";

                OrderInWay order = new OrderInWay();
                order.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
