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
using System.ServiceModel;
using System.Threading;
using SecureDesk.StaticInfo;

namespace SecureDesk
{
    public partial class AccessPin : Form
    {

        public static bool isAutorized = false;
        public AccessPin()
        {
            InitializeComponent();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
            UserAccountService.UserAccountServiceClient userProxy = new UserAccountService.UserAccountServiceClient("BasicHttpBinding_IUserAccountService");

            try
            {
                if (String.IsNullOrEmpty(guna2TextBox1.Text) || !IsDigitsOnly( guna2TextBox1.Text ))
                {
                    label2.Visible = true;
                    guna2Button1.Enabled = true;
                }
                else
                {
                    bool result = userProxy.isAuthorized(UserConfiguration.strUserEmail, Int32.Parse(guna2TextBox1.Text));
                    if (!result)
                    {
                        label2.Visible = true;
                        guna2Button1.Enabled = true;
                    }
                    else
                    {
                        isAutorized = true;
                        this.Close();
                        
                    }
                }
            }
            catch(TimeoutException ex)
            {
                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("TimeOut For Connecting to Azure Web Service");
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();
            }
            catch(FaultException ex)
            {
                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Some Unhandled Error Occured,We Will Fix It Soon");
                MessageBox.Show(ex.Message);
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();
            }
            catch(CommunicationException ex)
            {
                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Some Unhandled Error Occured,We Will Fix It Soon");
               
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();
            }

        }

        private void AccessPin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            label2.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
