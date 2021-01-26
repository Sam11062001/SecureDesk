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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
            progressBar.Value = 0;
        }
        int counter = 0;
        string text = "";
        int lenght;


        private void timer1_Tick(object sender, EventArgs e)
        {
            softwareName.Text = text.Substring(0, counter);
            counter++;
            if (counter > lenght)
            {
                timer1.Stop();
                tagLine.Show();
                progressBar.Show();
                loading.Show();
                timer2.Start();
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void SecureDesk_Load(object sender, EventArgs e)
        {
            loading.Hide();
            progressBar.Hide();
            tagLine.Hide();
            text = softwareName.Text;
            softwareName.Text = "";
            lenght = text.Length;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == 100)
            {
                timer2.Stop();
                this.Hide();
                login l = new login();
                l.Show();
            }
        }

       
    }  
}
