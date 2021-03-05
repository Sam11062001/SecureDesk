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
using SecureDesk.StaticInfo;

namespace SecureDesk
{
    public partial class login : Form
    {
        string emailAddress;
        ClientRegistrationService.RegistrationServiceClient clientRegistration = null;
        public login()
        {
            
            InitializeComponent();
            clientRegistration = new ClientRegistrationService.RegistrationServiceClient();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            invalidLabel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //instance of service procy
            AuthenticateClient.IAuthService serviceProcy = new AuthenticateClient.AuthServiceClient();
           
            //creating the instance of the userCredential object required for validating the client
            AuthenticateClient.UserCredentials userCredentials = new AuthenticateClient.UserCredentials();
           
            //user email address
            userCredentials.User_Auth_Email = emailTB.Text;
           
            //user password
            userCredentials.User_Auth_Password = passwordTextBox.Text;
            
            //result obtained from the Service
            bool auth_result = serviceProcy.validateLogin(userCredentials);
            if (auth_result)
            {
                UserConfiguration.strUserEmail = userCredentials.User_Auth_Email;
                this.Hide();
                Dashboard d1 = new Dashboard();
                d1.Show();
            }
            else
            {
                invalidLabel.Show();
                invalidLabel.Text = "Incorrect Credentials";
                button1.Enabled = true;
            }
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clientRegistration.sendOTP(emailAddress);
            panel2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            invalidLabel.Hide();
            if (!String.IsNullOrEmpty(emailTB.Text))
            {
                emailAddress = emailTB.Text;

                richTextBox1.Text = clientRegistration.getUserQuestion(emailAddress);

                panel2.Show();
                panel3.Hide();
            }
            else
            {
                invalidLabel.Show();
                invalidLabel.Text = "Enter email address";
                invalidLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage rp = new registrationPage();
            this.Hide();
            rp.Show();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invalidLabel.Hide();
            Regex regex = new Regex(@"^[0-9]{6}$");
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
                ClientRegistrationService.UserOtpVerification userOtpVerification = new ClientRegistrationService.UserOtpVerification()
                {
                    OneTimePasswordforVerification = Int32.Parse(code),
                    User_Email_Address = emailAddress

                };
                Boolean result = clientRegistration.verifyUser(userOtpVerification.OneTimePasswordforVerification, userOtpVerification.User_Email_Address);
                if (result)
                {
                    textBox9.Text = "";
                    panel4.Show();
                }
                else
                {
                    label10.Text = "Invalid OTP code";
                    textBox9.Text = "";
                    label10.ForeColor = System.Drawing.Color.Red;
                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string answer = textBox3.Text;
            if (String.IsNullOrEmpty(answer))
            {
                label27.Text = "Please enter the answer.";
                label27.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                string userAnswer = textBox3.Text;
                Boolean result = clientRegistration.verifyAnswer(emailAddress,userAnswer);
                if (!result)
                {
                    label27.Text = "Invalid answer submitted.";
                    label27.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label27.Text = "";
                    panel3.Show();
                    clientRegistration.sendOTP(emailAddress);
                }
            }
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
                clientRegistration.resetPassword(emailAddress,password);
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
            Regex regex = new Regex(@"^[0-9]{6}$");
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            emailTB.Text = "";


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        private void linkLabel2_Leave(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
