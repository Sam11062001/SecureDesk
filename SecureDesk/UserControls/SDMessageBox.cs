using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDesk.UserControls
{
    public partial class SDMessageBox : Form
    {
        public SDMessageBox()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SDMessageBox_Load(object sender, EventArgs e)
        {

        }
        public void setLabelMessage(string msg)
        {
            label1.Text = msg;
        }
    }
}
