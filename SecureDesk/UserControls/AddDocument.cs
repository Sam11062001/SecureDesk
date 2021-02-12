using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDesk.UserControls
{
    public partial class AddDocument : UserControl
    {

        public AddDocument()
        {
            InitializeComponent();
            fileLocationLabel.Hide();
            FileNametext.Hide();
            documentUpload.Hide();
            Cancelbtn.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            
            //showing the dialog box
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            var res=openFileDialog1.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                    //do Nothing
            }
            else
            {


                //get the file name from the fileName
                string FileName = openFileDialog1.FileName;
                
                //verifying that the user has selected the correct extension for uploading the file
                while (!openFileDialog1.FileName.EndsWith(".pdf"))
                {
                    MessageBox.Show("Please Select the Document with .pdf Extension");
                    var result=openFileDialog1.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                label1.Hide();
                pictureBox1.Hide();
                browseBtn.Hide();
                
                this.Width = 700;
                this.Height = 300;
                
                
                fileLocationLabel.Show();
                FileNametext.Show();
                FileNametext.Text = FileName;
                documentUpload.Show();
                Cancelbtn.Show();

            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
