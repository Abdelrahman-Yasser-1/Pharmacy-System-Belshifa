using System.Drawing;
using System.Windows.Forms;

namespace Belshifa
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_manage_products = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_report1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel_report2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker_end_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start_date = new System.Windows.Forms.DateTimePicker();
            this.bnt_show_report_2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_user_name = new System.Windows.Forms.ComboBox();
            this.panel_search_by_price = new System.Windows.Forms.Panel();
            this.dataGridView_search_price = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_search_price = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel_manage_products.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_report1.SuspendLayout();
            this.panel_report2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_search_by_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search_price)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.serchByPriceToolStripMenuItem,
            this.report1ToolStripMenuItem,
            this.report2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(174, 36);
            this.manageProductsToolStripMenuItem.Text = "Manage Products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // serchByPriceToolStripMenuItem
            // 
            this.serchByPriceToolStripMenuItem.Name = "serchByPriceToolStripMenuItem";
            this.serchByPriceToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.serchByPriceToolStripMenuItem.Text = "Search by price";
            this.serchByPriceToolStripMenuItem.Click += new System.EventHandler(this.serchByPriceToolStripMenuItem_Click);
            // 
            // report1ToolStripMenuItem
            // 
            this.report1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1ToolStripMenuItem.Name = "report1ToolStripMenuItem";
            this.report1ToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.report1ToolStripMenuItem.Text = "Report 1";
            this.report1ToolStripMenuItem.Click += new System.EventHandler(this.report1ToolStripMenuItem_Click);
            // 
            // report2ToolStripMenuItem
            // 
            this.report2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2ToolStripMenuItem.Name = "report2ToolStripMenuItem";
            this.report2ToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.report2ToolStripMenuItem.Text = "Report 2";
            this.report2ToolStripMenuItem.Click += new System.EventHandler(this.report2ToolStripMenuItem_Click);
            // 
            // panel_manage_products
            // 
            this.panel_manage_products.BackColor = System.Drawing.Color.White;
            this.panel_manage_products.Controls.Add(this.panel2);
            this.panel_manage_products.Controls.Add(this.panel1);
            this.panel_manage_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_manage_products.Location = new System.Drawing.Point(0, 40);
            this.panel_manage_products.Name = "panel_manage_products";
            this.panel_manage_products.Size = new System.Drawing.Size(1902, 943);
            this.panel_manage_products.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 883);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1902, 883);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 883);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 60);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1724, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_report1
            // 
            this.panel_report1.BackColor = System.Drawing.Color.White;
            this.panel_report1.Controls.Add(this.button2);
            this.panel_report1.Controls.Add(this.crystalReportViewer1);
            this.panel_report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report1.Location = new System.Drawing.Point(0, 40);
            this.panel_report1.Name = "panel_report1";
            this.panel_report1.Size = new System.Drawing.Size(1902, 943);
            this.panel_report1.TabIndex = 1;
            this.panel_report1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1902, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 49);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1902, 894);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // panel_report2
            // 
            this.panel_report2.BackColor = System.Drawing.Color.White;
            this.panel_report2.Controls.Add(this.crystalReportViewer2);
            this.panel_report2.Controls.Add(this.panel3);
            this.panel_report2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report2.Location = new System.Drawing.Point(0, 40);
            this.panel_report2.Name = "panel_report2";
            this.panel_report2.Size = new System.Drawing.Size(1902, 943);
            this.panel_report2.TabIndex = 0;
            this.panel_report2.Visible = false;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 103);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1902, 840);
            this.crystalReportViewer2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker_end_date);
            this.panel3.Controls.Add(this.dateTimePicker_start_date);
            this.panel3.Controls.Add(this.bnt_show_report_2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmb_user_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1902, 103);
            this.panel3.TabIndex = 1;
            // 
            // dateTimePicker_end_date
            // 
            this.dateTimePicker_end_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end_date.Location = new System.Drawing.Point(1351, 15);
            this.dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            this.dateTimePicker_end_date.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_end_date.TabIndex = 3;
            // 
            // dateTimePicker_start_date
            // 
            this.dateTimePicker_start_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimePicker_start_date.Location = new System.Drawing.Point(987, 16);
            this.dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            this.dateTimePicker_start_date.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_start_date.TabIndex = 3;
            // 
            // bnt_show_report_2
            // 
            this.bnt_show_report_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bnt_show_report_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_show_report_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_show_report_2.ForeColor = System.Drawing.Color.White;
            this.bnt_show_report_2.Location = new System.Drawing.Point(999, 59);
            this.bnt_show_report_2.Name = "bnt_show_report_2";
            this.bnt_show_report_2.Size = new System.Drawing.Size(173, 38);
            this.bnt_show_report_2.TabIndex = 0;
            this.bnt_show_report_2.Text = "Show Report";
            this.bnt_show_report_2.UseVisualStyleBackColor = false;
            this.bnt_show_report_2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1252, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // cmb_user_name
            // 
            this.cmb_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user_name.FormattingEnabled = true;
            this.cmb_user_name.Location = new System.Drawing.Point(671, 13);
            this.cmb_user_name.Name = "cmb_user_name";
            this.cmb_user_name.Size = new System.Drawing.Size(179, 30);
            this.cmb_user_name.TabIndex = 0;
            // 
            // panel_search_by_price
            // 
            this.panel_search_by_price.BackColor = System.Drawing.Color.White;
            this.panel_search_by_price.Controls.Add(this.dataGridView_search_price);
            this.panel_search_by_price.Controls.Add(this.panel4);
            this.panel_search_by_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search_by_price.Location = new System.Drawing.Point(0, 40);
            this.panel_search_by_price.Name = "panel_search_by_price";
            this.panel_search_by_price.Size = new System.Drawing.Size(1902, 943);
            this.panel_search_by_price.TabIndex = 1;
            // 
            // dataGridView_search_price
            // 
            this.dataGridView_search_price.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_search_price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_search_price.Location = new System.Drawing.Point(0, 73);
            this.dataGridView_search_price.Name = "dataGridView_search_price";
            this.dataGridView_search_price.RowHeadersWidth = 51;
            this.dataGridView_search_price.RowTemplate.Height = 24;
            this.dataGridView_search_price.Size = new System.Drawing.Size(1902, 870);
            this.dataGridView_search_price.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.txt_search_price);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1902, 73);
            this.panel4.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(219, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txt_search_price
            // 
            this.txt_search_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_price.Location = new System.Drawing.Point(30, 17);
            this.txt_search_price.Name = "txt_search_price";
            this.txt_search_price.Size = new System.Drawing.Size(164, 34);
            this.txt_search_price.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 983);
            this.Controls.Add(this.panel_report2);
            this.Controls.Add(this.panel_report1);
            this.Controls.Add(this.panel_manage_products);
            this.Controls.Add(this.panel_search_by_price);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belshifa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_manage_products.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_report1.ResumeLayout(false);
            this.panel_report2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_search_by_price.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search_price)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_manage_products;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel_report1;
        private System.Windows.Forms.Panel panel_report2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bnt_show_report_2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_user_name;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_date;
        private DateTimePicker dateTimePicker_end_date;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ToolStripMenuItem serchByPriceToolStripMenuItem;
        private Panel panel_search_by_price;
        private Panel panel4;
        private Button button3;
        private TextBox txt_search_price;
        private DataGridView dataGridView_search_price;
    }
}