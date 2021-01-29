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
//using SecureDesk.ClientRegistration;

namespace SecureDesk
{
    public partial class registrationPage : Form
    {
        string emailAddress;
        Regex regex;
        string[] Questions;
        ClientRegistrationService.RegistrationServiceClient clientRegistration = null; 
        public registrationPage()
        {
            InitializeComponent();
            panel2.Hide();
            clientRegistration = new ClientRegistrationService.RegistrationServiceClient();
            Questions = clientRegistration.getQuestions();
            foreach( string question in Questions )
            {
                comboBox1.Items.Add(question);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string questionSelected=comboBox1.SelectedText, email = textBox1.Text , firstName = textBox4.Text, lastName = textBox5.Text , date = textBox2.Text , password = textBox3.Text , cPassword = textBox6.Text , answer = textBox8.Text;
            if ( string.IsNullOrEmpty(email) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword) || string.IsNullOrEmpty(answer))
            {
                label26.Text = "Enter all details.";
                label26.ForeColor = System.Drawing.Color.Red;
                return;
            }
            ClientRegistrationService.UserRegister userRegister = new ClientRegistrationService.UserRegister()
            {
                Email_Address = email,
                First_Name = firstName,
                Last_Name = lastName,
                Date_Of_Birth = date,
                Question_Number_Selected = comboBox1.SelectedIndex,
                Question_Answered = answer,
                Password = password

            };
            clientRegistration.registerNewUser(userRegister);
            
            emailAddress = email;
            panel2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
                regex = new Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
                string email = textBox1.Text;
                Match match = regex.Match(email);
                if (!match.Success)
                {
                    label21.Text = "Enter valid email Address.";
                    label21.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label21.Text = "";
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            regex = new Regex(@"^[a-zA-Z]+$");
            string firstName = textBox4.Text;
            Match match = regex.Match(firstName);
            if (!match.Success)
            {
                label22.Text = "Enter valid name.";
                label22.ForeColor = System.Drawing.Color.Red;
            }
            else
                label22.Text = "";
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            regex = new Regex(@"^[a-zA-Z]+$");
            string lastName = textBox5.Text;
            Match match = regex.Match(lastName);
            if (!match.Success)
            {
                label22.Text = "Enter valid name.";
                label22.ForeColor = System.Drawing.Color.Red;
            }
            else
                label22.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            DateTime dt;

            bool dateValidity = DateTime.TryParseExact(textBox2.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
            if (!dateValidity)
            {
                label23.Text = "Enter valid date";
                label23.ForeColor = System.Drawing.Color.Red;
            }
            else
                label23.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string password = textBox3.Text;
            HashSet<char> specialCharacters = new HashSet<char>() { '@', '$', '#' , '_' , '%'};
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string password = textBox3.Text;
            string cPassword = textBox6.Text;
            if (cPassword != password)
            {
                label24.Text = "Password isn't matching";
                label24.ForeColor = System.Drawing.Color.Red;
            }
            else
                label24.Text = "";
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            string answer = textBox8.Text;
            if (answer.Length > 0)
            {
                label25.Text = "";
            }
            else
            {
                label25.Text = "Give answer to the selected question.";
                label25.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            regex = new Regex(@"^[1-9][0-9]{5}$");
            string code = textBox9.Text;
            Match match = regex.Match(code);
            if (!match.Success)
            {
                if (code.Length == 6)
                {
                    label27.Text = "Enter digits only";
                    label27.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
                label27.Text = "";
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regex = new Regex(@"^[1-9][0-9]{5}$");
            string code = textBox9.Text;
            Match match = regex.Match(code);
            if (!match.Success)
            {
                if (code.Length == 6)
                {
                    label27.Text = "Enter digits only";
                    label27.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label27.Text = "Please enter OTP code.";
                    label27.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                
                ClientRegistrationService.UserOtpVerification userOtpVerification = new ClientRegistrationService.UserOtpVerification()
                {
                    OneTimePasswordforVerification = Int32.Parse(code),
                    User_Email_Address = emailAddress
                   
                };
                //userOtpVerification.OneTimePasswordforVerification,userOtpVerification.User_Email_Address
                //Int32.Parse(code),emailAddress
                //ClientRegistrationService.OTP_Verified otpVerified = clientRegistration.verifyUser(userOtpVerification.OneTimePasswordforVerification,userOtpVerification.User_Email_Address);      
                Boolean result = clientRegistration.verifyUser(userOtpVerification.OneTimePasswordforVerification, userOtpVerification.User_Email_Address);
                if (result)
                {
                    this.Hide();
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                }
                else
                {
                    label27.Text = "Invalid OTP code";
                    label27.ForeColor = System.Drawing.Color.Red;
                }
                
            }
        }
    }
}

