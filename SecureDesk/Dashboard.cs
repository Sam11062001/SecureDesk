using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureDesk.DiaryService;
using SecureDesk.DocumentService;
using System.Net;

namespace SecureDesk
{
    public partial class Dashboard : Form
    {
        DiaryService.PersonalDiaryClient personalDiaryClient;
        DiaryService.DiaryData[] diaries;
        DocumentService.DocumentServiceClient documentServiceClient;
        DocumentService.DocumentData[] documents;
        public Dashboard()
        {
            InitializeComponent();
            //Hide the Diary Panel
            diaryPanel.Hide();
            addDocument1.Hide();
            diaryDataGridView.Visible = false;
            documentDataGridView.Visible = false;
            axAcroPDF1.Visible = false;
            //documnetDialog.Hide();
            //addDocument1.Hide();


          

            timer1.Start();
        }
       
        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            addDiaryPanel.Hide();
            diaryPanel.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           
            this.label3.Text = datetime.ToString();
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addNewDocumentBtn_Click(object sender, EventArgs e)
        {
            documentDataGridView.Visible = false;
            axAcroPDF1.Visible = false;
            //MessageBox.Show("Clicked event started");
            addDocument1.Show();
            //MessageBox.Show("Clicked event finshed");
            //documnetDialog.Show();
            //addDocument1.Show();
        }

        private void addDocument1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewDiary_Click(object sender, EventArgs e)
        {
            diaryDataGridView.Visible = false;
            addDiaryPanel.Show();
            
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            addDiaryPanel.Hide();
            addDocument1.Hide();
            
            diaryPanel.Show();

        }

        private void addDiaryPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            addDiaryPanel.Hide();
            diaryDataGridView.Visible = true ;
             personalDiaryClient = new DiaryService.PersonalDiaryClient();
             diaries = personalDiaryClient.getAllDiaryData("kamaniyash811@gmail.com");

            diaryDataGridView.Rows.Clear();
            for (int i = 0; i < diaries.Length; i++)
            {
                
                diaryDataBindingSource.Add(new DiaryData() { date = diaries[i].date , title = diaries[i].title});
            }


        }

        private void diaryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (diaryDataGridView.Columns[e.ColumnIndex].Name == "view")
            {
                WebClient webClient = new WebClient();
                byte[] dataBuffer = webClient.DownloadData( diaries[e.RowIndex].fileLink);

                string data = Encoding.ASCII.GetString(dataBuffer);
                MessageBox.Show(data);
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            addDocument1.Hide();
            axAcroPDF1.Visible = false;
            documentDataGridView.Visible = true;
             documentServiceClient = new DocumentService.DocumentServiceClient();
             documents = documentServiceClient.getAllDocumnetData("kamaniyash811@gmail.com");

            documentDataGridView.Rows.Clear();
            for (int i = 0; i < documents.Length; i++)
            {
                
                documentDataBindingSource.Add(new DocumentData() { fileName = documents[i].fileName });
            }
        }

        private void documentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (documentDataGridView.Columns[e.ColumnIndex].Name == "viewPdf")
            {
                axAcroPDF1.src = documents[e.RowIndex].fileLink;
                axAcroPDF1.Visible = true;
                addDocument1.Hide();
                MessageBox.Show(documents[e.RowIndex].fileName + " opening...");
            }

            if (documentDataGridView.Columns[e.ColumnIndex].Name == "sharePdf")
            {
                addDocument1.Hide();
                MessageBox.Show(documents[e.RowIndex].fileName + " sharing...");
            }

            if (documentDataGridView.Columns[e.ColumnIndex].Name == "deletePdf")
            {
                addDocument1.Hide();
                MessageBox.Show(documents[e.RowIndex].fileName + " deleting...");
            }
        }
    }
}
