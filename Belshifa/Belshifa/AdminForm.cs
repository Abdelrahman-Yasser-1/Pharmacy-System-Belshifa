using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace Belshifa
{
    public partial class AdminForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();
        Report1 CR;
        Report2 CR2;

        public void GetProducts()
        {
            
            string constr = "Data source=orcl;User Id=scott; Password=tiger;";
            string cmdstr = "select * from products";
            adapter = new OracleDataAdapter(cmdstr, constr);
            builder = new OracleCommandBuilder(adapter);
            adapter.Fill(ds, "products");
            dataGridView.DataSource = ds.Tables["products"];

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                int width = Screen.PrimaryScreen.Bounds.Width - 100;
                column.Width = width / dataGridView.Columns.Count;
            }
        }
        
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            #region GUI
            panel_report1.Visible = false;
            panel_report2.Visible = false;
            panel_manage_products.Visible = true;
            panel_search_by_price.Visible = false;
            manageProductsToolStripMenuItem.BackColor = Color.FromArgb(199, 234, 224);
            report1ToolStripMenuItem.BackColor = Color.White;
            report2ToolStripMenuItem.BackColor = Color.White;
            #endregion
            CR = new Report1();
            CR2 = new Report2();
            foreach (ParameterDiscreteValue v in CR2.ParameterFields[0].DefaultValues)
            {
                cmb_user_name.Items.Add(v.Value);
            }
            GetProducts();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GUI
            panel_report1.Visible = false;
            panel_report2.Visible = false;
            panel_manage_products.Visible = true;
            panel_search_by_price.Visible = false;
            manageProductsToolStripMenuItem.BackColor = Color.FromArgb(199, 234, 224);
            report1ToolStripMenuItem.BackColor = Color.White;
            report2ToolStripMenuItem.BackColor = Color.White;
            serchByPriceToolStripMenuItem.BackColor = Color.White;
            #endregion

            //GetProducts();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GUI
            panel_report1.Visible = true;
            panel_report2.Visible = false;
            panel_manage_products.Visible = false;
            panel_search_by_price.Visible = false;
            manageProductsToolStripMenuItem.BackColor = Color.White;
            report1ToolStripMenuItem.BackColor = Color.FromArgb(199, 234, 224);
            report2ToolStripMenuItem.BackColor = Color.White;
            manageProductsToolStripMenuItem.BackColor = Color.White;
            serchByPriceToolStripMenuItem.BackColor = Color.White;
            #endregion

        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GUI
            panel_report1.Visible = false;
            panel_report2.Visible = true;
            panel_manage_products.Visible = false;
            panel_search_by_price.Visible = false;
            manageProductsToolStripMenuItem.BackColor = Color.White;
            report1ToolStripMenuItem.BackColor = Color.White;
            report2ToolStripMenuItem.BackColor = Color.FromArgb(199, 234, 224);
            manageProductsToolStripMenuItem.BackColor = Color.White;
            serchByPriceToolStripMenuItem.BackColor = Color.White;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            dataGridView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string start_date = dateTimePicker_start_date.Value.ToShortDateString(), end_date = dateTimePicker_end_date.Value.ToShortDateString(), userName = cmb_user_name.Text;
            if (start_date != "" && end_date != "" && userName != "") {
                CR2.SetParameterValue(0, cmb_user_name.Text);
                CR2.SetParameterValue(1, start_date);
                CR2.SetParameterValue(2, end_date);

                crystalReportViewer2.ReportSource = CR2;
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void serchByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GUI
            panel_report1.Visible = false;
            panel_report2.Visible = false;
            panel_manage_products.Visible = false;
            panel_search_by_price.Visible = true;
            manageProductsToolStripMenuItem.BackColor = Color.White;
            report1ToolStripMenuItem.BackColor = Color.White;
            serchByPriceToolStripMenuItem.BackColor = Color.FromArgb(199, 234, 224);
            report2ToolStripMenuItem.BackColor = Color.White;
            #endregion
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            dataGridView_search_price.Controls.Clear();
            int price = int.Parse(txt_search_price.Text);
            string constr = "Data source=orcl;User Id=scott; Password=tiger;";
            string cmdstr = "select * from products where product_price <= :price";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("price", int.Parse(txt_search_price.Text));
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView_search_price.DataSource = ds.Tables[0];

            foreach (DataGridViewColumn column in dataGridView_search_price.Columns)
            {
                int width = Screen.PrimaryScreen.Bounds.Width - 100;
                column.Width = width / dataGridView_search_price.Columns.Count;
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
