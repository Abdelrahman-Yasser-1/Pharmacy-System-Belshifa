using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belshifa
{
    public partial class ToastForm : Form
    {
        public ToastForm(string message)
        {
            InitializeComponent();
            label_message.Text = message;
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            toastTimer.Start();
            Top = Screen.PrimaryScreen.WorkingArea.Height - Height -90;
            Left = Screen.PrimaryScreen.WorkingArea.Width - Width - 600;
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
