using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SecureDesk
{
    public partial class login : Form
    {
        public login()
        {
             
            InitializeComponent();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d1 = new Dashboard();
            d1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage rp = new registrationPage();
            this.Hide();
            rp.Show();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[1-9][0-9]{5}$");
            string code = textBox9.Text;
            Match match = regex.Match(code);
            if (!match.Success)
            {
                if (code.Length == 6)
                {
                    label10.Text = "Enter digits only";
                    label10.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label10.Text = "Please enter OTP code.";
                    label10.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                panel4.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string answer = textBox3.Text;
            if (String.IsNullOrEmpty(answer) )
            {
                label27.Text = "Please enter the answer.";
                label27.ForeColor = System.Drawing.Color.Red;

            }
            else
                panel3.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string password = textBox5.Text;
            string cPassword = textBox4.Text;
            if (cPassword != password)
            {
                label24.Text = "Password isn't matching";
                label24.ForeColor = System.Drawing.Color.Red;
            }
            else
                label24.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string password = textBox5.Text, cPassword = textBox4.Text;
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword) )
            {
                label24.Text = "Enter all details.";
                label24.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                panel2.Hide();
                panel4.Hide();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[1-9][0-9]{5}$");
            string code = textBox9.Text;
            Match match = regex.Match(code);
            if (!match.Success)
            {
                if (code.Length == 6)
                {
                    label10.Text = "Enter digits only";
                    label10.ForeColor = System.Drawing.Color.Red;
                }
            } 
            else
                label10.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string password = textBox5.Text;
            HashSet<char> specialCharacters = new HashSet<char>() { '@', '$', '#', '_', '%' };
            if (password.Any(char.IsLower) &&
                 password.Any(char.IsUpper) &&
                 password.Any(char.IsDigit) &&
                 password.Any(specialCharacters.Contains) && password.Length >= 8)
            {
                label24.Text = "";
            }
            else
            {
                label24.Text = "Try to enter strong password";
                label24.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
