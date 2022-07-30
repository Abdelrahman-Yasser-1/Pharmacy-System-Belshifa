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
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text, password = txt_password.Text;
           if (username != "" && password != "")
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", username);
                cmd.Parameters.Add("password", password);
                cmd.Parameters.Add("result", OracleDbType.Int32, ParameterDirection.Output);

                try
                {
                    cmd.ExecuteNonQuery();
                    int result = Convert.ToInt32(cmd.Parameters["result"].Value.ToString());
                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "select * from BUYER where user_id = : id";
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.Add("id", result);
                    OracleDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        User user = new User(int.Parse(dr["user_id"].ToString()), dr["user_name"].ToString(), dr["user_email"].ToString(), dr["user_password"].ToString(), int.Parse(dr["user_phone"].ToString()), dr["user_address"].ToString());
                        UserForm myForm = new UserForm(user);
                        this.Hide();
                        myForm.ShowDialog();
                        this.Close();
                    }
                    dr.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Make sure you entered the correct username and password");
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_register.Visible = false;
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_register.Visible = true;
        }

        private void pictureBox_back_cart_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_register.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = txt_user_name.Text, email = txt_email.Text, address = txt_address.Text, password = txt_pass.Text;
            int phone = int.Parse(txt_phone.Text.ToString());

            if (userName != "" && email != "" && address != "" && password != "" && phone.ToString() != "") {
                conn = new OracleConnection(ordb);
                conn.Open();

                //get max id from buyer table   (user_id)
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select max(user_id) from buyer";
                cmd1.CommandType = CommandType.Text;
                OracleDataReader dr = cmd1.ExecuteReader();
                int id = -1;
                if (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                }
                id++;
                
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into BUYER values(:name, :id, :pass, :email, :address, :phone)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", userName);
                cmd.Parameters.Add("id", id);
                cmd.Parameters.Add("pass", password);
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("address", address);
                cmd.Parameters.Add("phone", phone);
                int r =  cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Registration Successful");
                    panel_login.Visible = true;
                    panel_register.Visible = false;
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }
                dr.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();            
            home.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
