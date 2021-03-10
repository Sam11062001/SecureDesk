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
    public partial class SecureDeskRegistration : Form
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
        public SecureDeskRegistration()
        {
            InitializeComponent();
        }

        private void SecureDeskRegistration_Load(object sender, EventArgs e)
        {
            //hide the OTP verification Panel
            guna2Panel3.Visible = false;
            //initally Hide all the incorresct labels
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
            label16.Visible = false;

            label1.Parent = guna2PictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = guna2PictureBox1;
            label2.BackColor = Color.Transparent;

            label4.Parent = guna2PictureBox1;
            label4.BackColor = Color.Transparent;

            label6.Parent = guna2PictureBox1;
            label6.BackColor = Color.Transparent;

            label5.Parent = guna2PictureBox1;
            label5.BackColor = Color.Transparent;

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

            label15.Parent = guna2PictureBox1;
            label15.BackColor = Color.Transparent;

            label16.Parent = guna2PictureBox1;
            label16.BackColor = Color.Transparent;



            guna2TextBox1.Parent = guna2PictureBox1;
            guna2TextBox1.BackColor = Color.Transparent;

            label3.Parent = guna2PictureBox1;
            label3.BackColor = Color.Transparent;

            guna2TextBox2.Parent = guna2PictureBox1;
            guna2TextBox2.BackColor = Color.Transparent;


            guna2TextBox3.Parent = guna2PictureBox1;
            guna2TextBox3.BackColor = Color.Transparent;

            guna2TextBox4.Parent = guna2PictureBox1;
            guna2TextBox4.BackColor = Color.Transparent;

            guna2TextBox5.Parent = guna2PictureBox1;
            guna2TextBox5.BackColor = Color.Transparent;

            guna2TextBox6.Parent = guna2PictureBox1;
            guna2TextBox6.BackColor = Color.Transparent;

            guna2TextBox7.Parent = guna2PictureBox1;
            guna2TextBox7.BackColor = Color.Transparent;

            guna2ComboBox1.Parent = guna2PictureBox1;
            guna2ComboBox1.BackColor = Color.Transparent;

            register.Parent = guna2PictureBox1;
            register.BackColor = Color.Transparent;

            guna2Panel3.Parent = guna2PictureBox1;
            guna2Panel3.BackColor = Color.Transparent;


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hideRegistrationControl()
        {
            
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;

            guna2TextBox1.Visible = false;
            guna2TextBox2.Visible = false;
            guna2TextBox3.Visible = false;
            guna2TextBox4.Visible = false;
            guna2TextBox5.Visible = false;
            guna2TextBox6.Visible = false;
            guna2TextBox7.Visible = false;

            guna2ComboBox1.Visible = false;


        }

        private void showRegisterControl()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            guna2TextBox1.Visible = true;
            guna2TextBox2.Visible = true;
            guna2TextBox3.Visible = true;
            guna2TextBox4.Visible = true;
            guna2TextBox5.Visible = true;
            guna2TextBox6.Visible = true;
            guna2TextBox7.Visible = true;

            guna2ComboBox1.Visible = true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            hideRegistrationControl();
            register.Visible = false;
            guna2Panel3.Visible = true;

        }
    }
}
