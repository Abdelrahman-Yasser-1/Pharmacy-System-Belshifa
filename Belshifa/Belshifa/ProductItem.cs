using System.ComponentModel;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Belshifa
{
    [ToolboxItem(true)]
    public partial class ProductItem : UserControl
    {
        private Product product;
        int userID;
        
        public ProductItem(Product product1, int usre_id)
        {
            InitializeComponent();
            this.product = product1;
            this.userID = usre_id;

            label_name.Text = product.Name;
            label_usage.Text = product.Usage;
            label_price.Text = product.Price.ToString() + " $";
        }

        public ProductItem()
        {
            InitializeComponent();
        }

        private void ShowToast(string message) {
            ToastForm toast = new ToastForm(message);
            toast.Show();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from CART where product_id = :product_Id and  userID = :user_id";
            cmd.Parameters.Add("product_id", product.ID);
            cmd.Parameters.Add("user_id", userID);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "update CART set number_of_items = number_of_items + 1  where product_id = :product_Id and  userID = :user_id";
                cmd1.Parameters.Add("product_id", product.ID);
                cmd1.Parameters.Add("user_id", userID);
                int r2 = cmd1.ExecuteNonQuery();
                if (r2 != -1)
                {
                    //ShowToast("Product already in cart and incresed by 1");
                    ShowToast("Product added to cart");
                }
                else
                {
                    ShowToast("Error");
                }
            }
            else
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into CART values(:product_id,:amount,:name,:price,:usage,:user_id)";
                cmd2.Parameters.Add("product_id", product.ID);
                cmd2.Parameters.Add("amount", 1);
                cmd2.Parameters.Add("name", product.Name);
                cmd2.Parameters.Add("price", product.Price);
                cmd2.Parameters.Add("usage", product.Usage);
                cmd2.Parameters.Add("user_id", userID);
                int r3 = cmd2.ExecuteNonQuery();
                if (r3 != -1)
                {
                    ShowToast("Product added to cart");
                }
                else
                {
                    ShowToast("Error");
                }
            }
            dr.Close();
        }
    }
}
