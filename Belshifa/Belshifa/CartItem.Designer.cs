namespace Belshifa
{
    partial class CartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.remove_from_cart = new System.Windows.Forms.PictureBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_usage = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.inc_amount = new System.Windows.Forms.PictureBox();
            this.dec_amount = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.remove_from_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inc_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // remove_from_cart
            // 
            this.remove_from_cart.Image = ((System.Drawing.Image)(resources.GetObject("remove_from_cart.Image")));
            this.remove_from_cart.Location = new System.Drawing.Point(1042, 29);
            this.remove_from_cart.Name = "remove_from_cart";
            this.remove_from_cart.Size = new System.Drawing.Size(46, 46);
            this.remove_from_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.remove_from_cart.TabIndex = 9;
            this.remove_from_cart.TabStop = false;
            this.remove_from_cart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(706, 37);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(88, 29);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Price $";
            // 
            // label_usage
            // 
            this.label_usage.AutoSize = true;
            this.label_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usage.Location = new System.Drawing.Point(80, 63);
            this.label_usage.Name = "label_usage";
            this.label_usage.Size = new System.Drawing.Size(66, 25);
            this.label_usage.TabIndex = 7;
            this.label_usage.Text = "usage";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(180, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(162, 29);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Product name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(654, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(922, 37);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(26, 29);
            this.label_amount.TabIndex = 10;
            this.label_amount.Text = "1";
            // 
            // inc_amount
            // 
            this.inc_amount.Image = ((System.Drawing.Image)(resources.GetObject("inc_amount.Image")));
            this.inc_amount.Location = new System.Drawing.Point(964, 35);
            this.inc_amount.Name = "inc_amount";
            this.inc_amount.Size = new System.Drawing.Size(30, 33);
            this.inc_amount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inc_amount.TabIndex = 9;
            this.inc_amount.TabStop = false;
            this.inc_amount.Click += new System.EventHandler(this.pictureBox_inc_amount_Click);
            // 
            // dec_amount
            // 
            this.dec_amount.Image = ((System.Drawing.Image)(resources.GetObject("dec_amount.Image")));
            this.dec_amount.Location = new System.Drawing.Point(872, 35);
            this.dec_amount.Name = "dec_amount";
            this.dec_amount.Size = new System.Drawing.Size(30, 33);
            this.dec_amount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dec_amount.TabIndex = 9;
            this.dec_amount.TabStop = false;
            this.dec_amount.Click += new System.EventHandler(this.pictureBox_dec_amount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usage: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 3);
            this.panel1.TabIndex = 13;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dec_amount);
            this.Controls.Add(this.inc_amount);
            this.Controls.Add(this.remove_from_cart);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_usage);
            this.Controls.Add(this.label_name);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(1105, 115);
            this.Load += new System.EventHandler(this.CartItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remove_from_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inc_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox remove_from_cart;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_usage;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.PictureBox inc_amount;
        private System.Windows.Forms.PictureBox dec_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
