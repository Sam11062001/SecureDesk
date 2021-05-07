using SecureDesk.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDesk
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SDMessageBox msg = new SDMessageBox();
            msg.setLabelMessage("Incorrect Credential");
            System.Media.SystemSounds.Exclamation.Play();
            msg.ShowDialog();
            


        }
    }
}
