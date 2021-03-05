using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDesk.UserControls
{
    public partial class shareDocument : UserControl
    {
        

        public shareDocument()
        {
            InitializeComponent();
            sharedToTextBox.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string sharedTo = sharedToTextBox.Text;
            SharingService.SharingServiceClient sharingServiceClient = new SharingService.SharingServiceClient();
            sharingServiceClient.shareDocument( Dashboard.documentData , Dashboard.sharedBy , sharedTo );
            this.Hide();
            MessageBox.Show("Document shared to " + sharedTo);
            
        }
    }
}
