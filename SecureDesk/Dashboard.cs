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
            //Hide the Diary Panel
            diaryPanel.Hide();
            addDocument1.Hide();

            //documnetDialog.Hide();
            //addDocument1.Hide();


          

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
            addDiaryPanel.Hide();
            diaryPanel.Hide();

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
            //MessageBox.Show("Clicked event started");
            addDocument1.Show();
            //MessageBox.Show("Clicked event finshed");
            //documnetDialog.Show();
            //addDocument1.Show();
        }

        private void addDocument1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewDiary_Click(object sender, EventArgs e)
        {
            addDiaryPanel.Show();
            
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            addDiaryPanel.Hide();
            addDocument1.Hide();
            
            diaryPanel.Show();

        }

        private void addDiaryPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
