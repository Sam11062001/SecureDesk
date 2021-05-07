using SecureDesk.StaticInfo;
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
    public partial class demo : Form
    {
        string emailAddress;
        ClientRegistrationService.RegistrationServiceClient clientRegistration = null;
        UserAccountService.UserAccountServiceClient userAccountServiceClient;
        private const int CS_DrapShadow = 0x00020000;
        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DrapShadow;
                return cp;
            }

        }
        public demo()
        {
            InitializeComponent();
            clientRegistration = new ClientRegistrationService.RegistrationServiceClient("BasicHttpsBinding_RegistrationService");

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void demo_Load(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
            
            loginButton.Parent = guna2CirclePictureBox1;
            loginButton.BackColor = Color.Transparent;
            label1.Parent = guna2PictureBox1;
            label1.BackColor = Color.Transparent;

            label3.Parent = guna2PictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = guna2PictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = guna2PictureBox1;
            label5.BackColor = Color.Transparent;

            label6.Parent = guna2PictureBox1;
            label6.BackColor = Color.Transparent;


            label7.Parent = guna2PictureBox1;
            label7.BackColor = Color.Transparent;

            label8.Parent = guna2PictureBox1;
            label8.BackColor = Color.Transparent;

            label9.Parent = guna2PictureBox1;
            label9.BackColor = Color.Transparent;

            label10.Parent = guna2PictureBox1;
            label10.BackColor = Color.Transparent;

            label11.Parent = guna2PictureBox1;
            label11.BackColor = Color.Transparent;

            label12.Parent = guna2PictureBox1;
            label12.BackColor = Color.Transparent;

            label13.Parent = guna2PictureBox1;
            label13.BackColor = Color.Transparent;

            label14.Parent = guna2PictureBox1;
            label14.BackColor = Color.Transparent;

            label17.Parent = guna2PictureBox1;
            label17.BackColor = Color.Transparent;
            label17.Visible = false;

            label18.Parent = guna2PictureBox1;
            label18.BackColor = Color.Transparent;


            userNameTextBox.Parent = guna2PictureBox1;
            userNameTextBox.BackColor = Color.Transparent;
            userNameTextBox.BorderColor = Color.Transparent;
            userNameTextBox.DisabledState.BorderColor = Color.Transparent;

            userNameTextBox.FocusedState.BorderColor = Color.Transparent;

            PasswordTextBox.Parent = guna2PictureBox1;
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BorderColor = Color.Transparent;
            PasswordTextBox.DisabledState.BorderColor = Color.Transparent;

            PasswordTextBox.FocusedState.BorderColor = Color.Transparent;

            guna2CirclePictureBox1.Parent = guna2PictureBox1;
            guna2CirclePictureBox1.BackColor = Color.Transparent;

            guna2CirclePictureBox2.Parent = guna2PictureBox1;
            guna2CirclePictureBox2.BackColor = Color.Transparent;

            guna2CirclePictureBox3.Parent = guna2PictureBox1;
            guna2CirclePictureBox3.BackColor = Color.Transparent;

            guna2CirclePictureBox4.Parent = guna2PictureBox1;
            guna2CirclePictureBox4.BackColor = Color.Transparent;



            guna2VSeparator1.Parent = guna2PictureBox1;
            guna2VSeparator1.BackColor = Color.Transparent;

            
            guna2Panel1.Parent = guna2PictureBox1;
            guna2Panel1.BackColor = Color.SeaGreen;

            guna2Panel2.Parent = guna2PictureBox1;
            guna2Panel2.BackColor = Color.Transparent;

            guna2Panel3.Parent = guna2PictureBox1;
            guna2Panel3.BackColor = Color.Transparent;



        }
        private void HideLogin()
        {
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            userNameTextBox.Visible = false;
            PasswordTextBox.Visible = false;
            loginButton.Visible = false;
            label18.Visible = false;


        }

        private void showLogin()
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            userNameTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            loginButton.Visible = true;
            label18.Visible = true;

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //off the display of the Security Check Panel
            guna2Panel2.Visible = false;

            //showLogin
            showLogin();

        }

        private void label18_Click(object sender, EventArgs e)
        {
            //Forget Password Clicked
            //Hide the Login Controls
            HideLogin();
            //display the Security Check Panel
            guna2Panel2.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Check Button is clicked for th3 OTP verification
            //hide the Security Panel
            guna2Panel2.Visible = false;
            //display the OTP verification panel
            guna2Panel3.Visible = true;
            //label for the incorrect OTP
            label22.Visible = false;


        }

        private void label7_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //make the OTP verification panel Disabel
            guna2Panel3.Visible = true;

            //Make the reset Password Visisble
            guna2Panel4.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //make the reset panel show off
            guna2Panel4.Visible = false;

            //make the OTP verification panel Disabel
            guna2Panel3.Visible = false;

            //showLogin Control
            showLogin();

        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
            //instance of service procy
            AuthenticateClient.IAuthService serviceProcy = new AuthenticateClient.AuthServiceClient("BasicHttpsBinding_IAuthService");

            //creating the instance of the userCredential object required for validating the client
            AuthenticateClient.UserCredentials userCredentials = new AuthenticateClient.UserCredentials();

            //user email address
            userCredentials.User_Auth_Email = userNameTextBox.Text;

            //user password
            userCredentials.User_Auth_Password = PasswordTextBox.Text;

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
                //invalidLabel.Show();
                //invalidLabel.Text = "Incorrect Credentials";

                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Incorrect Credential");
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();



                loginButton.Enabled = true;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
           
            //instance of service procy
            //AuthenticateClient.IAuthService serviceProcy = new AuthenticateClient.AuthServiceClient("BasicHttpBinding_IAuthService");
            AuthenticateClient.AuthServiceClient serviceProcy = new AuthenticateClient.AuthServiceClient("BasicHttpsBinding_IAuthService");

            //creating the instance of the userCredential object required for validating the client
            AuthenticateClient.UserCredentials userCredentials = new AuthenticateClient.UserCredentials();

            //user email address
            userCredentials.User_Auth_Email = userNameTextBox.Text;

            //user password
            userCredentials.User_Auth_Password = PasswordTextBox.Text;

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
                //invalidLabel.Show();
                //invalidLabel.Text = "Incorrect Credentials";

                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Incorrect Credential");
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();



                guna2Button1.Enabled = true;

            }
        }
    }
}
