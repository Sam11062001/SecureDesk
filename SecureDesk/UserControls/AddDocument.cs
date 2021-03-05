using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SecureDesk.DocumentService;
using SecureDesk.StaticInfo;

namespace SecureDesk.UserControls
{
    public partial class addDocument : UserControl
    {
        private static string filePath = "";
        
        public addDocument()
        {
            InitializeComponent();
            fileNameTextBox.Text = "";
            filePathTextBox.Text = "";
            //filePathTextBox.Hide();
            filePathTextBox.Visible = false;
            //guna2PictureBox1.Show();
            guna2PictureBox1.Visible = true;
            //browseBtn.Show();
            browseBtn.Visible = true;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select your file from here";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                filePath = openFileDialog1.FileName;
                //guna2PictureBox1.Hide();
                guna2PictureBox1.Visible = false;
                //browseBtn.Hide();
                browseBtn.Visible = false;
                filePathTextBox.Text = filePath;
                //filePathTextBox.Show();
                filePathTextBox.Visible = true;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fileName = fileNameTextBox.Text;
            fileName = fileName + ".pdf";
            byte[] readFile = File.ReadAllBytes(filePath);
            DocumentService.DocumentServiceClient documentServiceClient = new DocumentService.DocumentServiceClient();
            documentServiceClient.uploadDocument( readFile, fileName, UserConfiguration.strUserEmail);
            MessageBox.Show("Document Uploaded");
            this.Visible = false;



        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
