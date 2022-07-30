
namespace Belshifa
{
    partial class ProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.label_name = new System.Windows.Forms.Label();
            this.label_usage = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.add_to_cart = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add_to_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(184, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(162, 29);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Product name";
            // 
            // label_usage
            // 
            this.label_usage.AutoSize = true;
            this.label_usage.BackColor = System.Drawing.Color.Transparent;
            this.label_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usage.Location = new System.Drawing.Point(85, 61);
            this.label_usage.Name = "label_usage";
            this.label_usage.Size = new System.Drawing.Size(66, 25);
            this.label_usage.TabIndex = 0;
            this.label_usage.Text = "usage";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(822, 34);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(88, 29);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Price $";
            // 
            // add_to_cart
            // 
            this.add_to_cart.BackColor = System.Drawing.Color.Transparent;
            this.add_to_cart.Image = ((System.Drawing.Image)(resources.GetObject("add_to_cart.Image")));
            this.add_to_cart.Location = new System.Drawing.Point(1040, 26);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(46, 46);
            this.add_to_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_to_cart.TabIndex = 5;
            this.add_to_cart.TabStop = false;
            this.add_to_cart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(770, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 3);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usage: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product name: ";
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.add_to_cart);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_usage);
            this.Controls.Add(this.label_name);
            this.DoubleBuffered = true;
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(1105, 108);
            ((System.ComponentModel.ISupportInitialize)(this.add_to_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_usage;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.PictureBox add_to_cart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
