using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SecureDesk.Algorithms;



namespace SecureDesk.UserControls
{
    public partial class addAccounts : UserControl
    {
        public addAccounts()
        {
            InitializeComponent();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //hide this userControl
            this.Hide();
            
        }

        private void generatePasswordBtn_Click(object sender, EventArgs e)
        {
            //disable this generate Button on the userControl
            generatePasswordBtn.Enabled = false;
            //ask the user for the minimum lenght and maximum length password therefore show the panel for user input
            passwordLengthPanel.Show();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maxLengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void addAccounts_Load(object sender, EventArgs e)
        {
            passwordLengthPanel.Hide();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //get the minimum and maximum value obtinaed from the user
            int min =(int) minNumbericUpDown.Value;
            int max = (int)maxNumericUpDown.Value;

            //create the instance of the password Generator class to obtain the strong password
            PasswordGenerator passwordGenerator = new PasswordGenerator(min, max);

            //get the strong password by calling the method Generate
            string password_Obtained = passwordGenerator.Generate();

            //display the password to the user in the password TextBox on the user Control
            passwordTextBox.Text = password_Obtained;

            //work of this panel is done so simply hide this panel
            passwordLengthPanel.Hide();


            //enable the generate button again
            generatePasswordBtn.Enabled = true;
        }

        private void lenghtBtnCancel_Click(object sender, EventArgs e)
        {
            //if user press for the cancel button present on the Panel that ask for the length of the password
            passwordLengthPanel.Hide();

            //and enable the generat button again
            generatePasswordBtn.Enabled = true;
        }

        private void submitAccountBtn_Click(object sender, EventArgs e)
        {
            //finally add the account details to the database here
            string userAccountname = accountName.Text;
            string userAccountUserName = userNameTextBox.Text;
            string userAccountPassowrd = passwordTextBox.Text;
            
            
                //check that whether the user have given the vlaues in the text boc
                if (string.IsNullOrEmpty(userAccountname) || string.IsNullOrEmpty(userAccountUserName) || string.IsNullOrEmpty(userAccountPassowrd))
                {

                    MessageBox.Show("All Fields are Required");
                }
                else
                 {
                MessageBox.Show("All fields are reuqired");
                }
         

            //service logic to give the data to the service 


            //completed the service Logic


        }

    }
}
