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
    public partial class CartItem : UserControl
    {
        private Cart cart;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        
        public CartItem(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;

            label_name.Text = cart.Product.Name;
            label_price.Text = cart.Product.Price.ToString();
            label_usage.Text = cart.Product.Usage;
            label_amount.Text = cart.ProductAmount.ToString();
        }
        
        public CartItem()
        {
            InitializeComponent();
        }

        private void pictureBox_inc_amount_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(label_amount.Text);
            amount++;
            label_amount.Text = amount.ToString();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "update CART set number_of_items = number_of_items + 1  where product_id = :product_Id and  userID = :user_id";
            cmd1.Parameters.Add("product_Id", cart.Product.ID);
            cmd1.Parameters.Add("user_id", cart.ProductUserID);
            int r2 = cmd1.ExecuteNonQuery();
            if (r2 != -1)
            {
                //MessageBox.Show("Product already in cart and incresed by 1");
                string totalPrice = (UserForm.label100.Text).ToString();
                totalPrice = totalPrice.Remove(totalPrice.Length - 1);
                int totalPriceInt = int.Parse(totalPrice);
                UserForm.label100.Text = (totalPriceInt + cart.Product.Price) + "$";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox_dec_amount_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(label_amount.Text);
            if (amount > 1)
            {
                amount--;
                label_amount.Text = amount.ToString();

                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "update CART set number_of_items = number_of_items - 1  where product_id = :product_Id and  userID = :user_id";
                cmd1.Parameters.Add("product_Id", cart.Product.ID);
                cmd1.Parameters.Add("user_id", cart.ProductUserID);
                int r2 = cmd1.ExecuteNonQuery();
                if (r2 != -1)
                {
                    string totalPrice = (UserForm.label100.Text).ToString();
                    totalPrice = totalPrice.Remove(totalPrice.Length - 1);
                    int totalPriceInt = int.Parse(totalPrice);
                    UserForm.label100.Text = (totalPriceInt - cart.Product.Price) + "$";                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void CartItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(label_amount.Text);
            int price = int.Parse(label_price.Text);

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "delete from CART where product_id = :product_Id and  userID = :user_id";
            cmd1.Parameters.Add("product_Id", cart.Product.ID);
            cmd1.Parameters.Add("user_id", cart.ProductUserID);
            int r2 = cmd1.ExecuteNonQuery();
            if (r2 != -1)
            {
                UserForm.flowLayoutPanel1.Controls.Remove(this);
                string totalPrice = (UserForm.label100.Text).ToString();
                totalPrice = totalPrice.Remove(totalPrice.Length - 1);
                int totalPriceInt = int.Parse(totalPrice);
                UserForm.label100.Text = (totalPriceInt - (amount * price)) + "$";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
