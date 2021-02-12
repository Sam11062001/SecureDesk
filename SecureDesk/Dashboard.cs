using Guna.UI2.WinForms;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //documnetDialog.Hide();
            addDocument1.Hide();
            timer1.Start();
        }
       
        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           
            this.label3.Text = datetime.ToString();
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addNewDocumentBtn_Click(object sender, EventArgs e)
        {
            //documnetDialog.Show();
            addDocument1.Show();
        }
    }
}
