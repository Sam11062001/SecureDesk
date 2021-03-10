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
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void demo_Load(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
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

            guna2Button1.Parent = guna2PictureBox1;
            guna2Button1.BackColor = Color.Transparent;
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
            guna2Button1.Visible = false;
            label18.Visible = false;


        }

        private void showLogin()
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            userNameTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            guna2Button1.Visible = true;
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
    }
}
