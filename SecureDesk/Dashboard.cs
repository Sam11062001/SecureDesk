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
using SecureDesk.SharingService;
using System.IO;
using SecureDesk.StaticInfo;
using SecureDesk.Algorithms;
using SecureDesk.UserControls;

namespace SecureDesk
{
    public partial class Dashboard : Form
    {
        public static string emailAddress = "";
        public static string updateAccountName = "";
        public static string filePath = "";
        public static string currentlyOpenedFile ="";
        public static string currentlyOpenedSharedFile = "";
        public static string sharedBy="" ;
        public static string sharedTo = "";
        public static SharingService.DocumentData documentData  ;
        public static SharedDocumentData sharedDocumentData ;

        AccountService.AccountServiceClient accountServiceClient ;
        AccountService.UserAccountData[] userAccountData ;

        SharingService.SharingServiceClient sharingServiceClient;
        SharingService.SharedDocumentData[] sharedDocments;
        
        DiaryService.PersonalDiaryClient personalDiaryClient;
        DiaryService.DiaryData[] diaries;

        DocumentService.DocumentServiceClient documentServiceClient;
        DocumentService.DocumentData[] documents;
        public Dashboard()

        {
            InitializeComponent();

            guna2Button3.Visible = false;
            guna2Button6.Visible = false;
            guna2Button7.Visible = false;
            //UserConfiguration.strUserEmail = "kamaniyash813@gmail.com";
            //documentPanel.Show();
            documentPanel.Visible = true;
            //diaryPanel.Hide();
            diaryPanel.Visible = false;
            //documentSharingUC.Hide();
            //documentSharingUC1.Visible = false;
            documentSharingPanel.Visible = false;
            //addDocumentUC.Hide();
            //addDocumentUC1.Visible = false;
            addDocumentPanel.Visible = false;
            
            //documentDataGridView.Hide();
            
            //axAcroPDF1.Hide();
            axAcroPDF1.Visible = false;

            documentDataGridView.Visible = true;

            documentServiceClient = new DocumentService.DocumentServiceClient("BasicHttpBinding_IDocumentService");
            documents = documentServiceClient.getAllDocumnetData(UserConfiguration.strUserEmail);


            //documentDataGridView.Rows.Clear();
            for (int i = 0; i < documents.Length; i++)
            {

                documentDataBindingSource.Add(new DocumentService.DocumentData() { fileName = documents[i].fileName });
            }

            searchComboBox.Items.Add("Diaries");
            searchComboBox.Items.Add("Documents");
            searchComboBox.Items.Add("Accounts");
            searchComboBox.Items.Add("Shared Documents");




            accountNameLabel.Text = UserConfiguration.strUserEmail;

            timer1.Start();
        }
       
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //documentPanel.Show();
            documentPanel.Visible = true;
            //diaryPanel.Show();
            diaryPanel.Visible = true;
            //sharedPanel.Show();
            sharedPanel.Visible = true;

            accountPanel.Visible = false;
            //sharedDocumentSharingUC.Hide();
            //sharedDocumentSharingUC2.Visible = false;
            sharedDocumentSharingPanel.Visible = false;
            //sharedDocumentViewer.Hide();
            sharedDocumentViewer.Visible = false;


            //refreshSharedDocumentBtn.Show();
            refreshSharedDocumentBtn.Visible = true;
            //sharedDocumentDataGridView.Show();
            sharedDocumentDataGridView.Visible = true;

            


            sharingServiceClient = new SharingService.SharingServiceClient("BasicHttpsBinding_ISharingService");
            sharedDocments = sharingServiceClient.getSharedDocument(UserConfiguration.strUserEmail);

            
            sharedDocumentDataGridView.Rows.Clear();
            for (int i = 0; i < sharedDocments.Length; i++)
            {

                    sharedDocumentDataBindingSource.Add(new SharedDocumentData() { fileName = sharedDocments[i].fileName, sharedBy = sharedDocments[i].sharedBy });
            }
            


        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            //addDiaryPanel.Hide();
            //diaryPanel.Hide();
            documentPanel.Visible = true;
            diaryPanel.Visible = false;

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
            //documentPanel.Show();
            documentPanel.Visible = true;
            //diaryPanel.Show();
            diaryPanel.Visible = true;
            //sharedPanel.Show();
            sharedPanel.Visible = true;

            accountPanel.Visible = true;

            addAccountPanel.Visible = false;

            updateAccountPanel.Visible = false;

            accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
            userAccountData = accountServiceClient.getAllAccounts(UserConfiguration.strUserEmail);

            accountDataGirdView.Rows.Clear();

            
            for (int i = 0; i < userAccountData.Length; i++)
            {
                
                userAccountDataBindingSource.Add(new AccountService.UserAccountData() { UserAccountName = userAccountData[i].UserAccountName });
                
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addNewDocumentBtn_Click(object sender, EventArgs e)
        {
            //documentDataGridView.Hide();
            //documentDataGridView.Visible = false;
            //axAcroPDF1.Hide();
            axAcroPDF1.Visible = false;
            //documentSharingUC.Hide();
            //documentSharingUC1.Visible = false;
            documentSharingPanel.Visible = false;
            //addDocumentUC.Show();
            //addDocumentUC1.Visible = true;
            addDocfileNameTextBox.Text = "";
            addDocfilePathTextBox.Text = "";
            addDocumentPanel.Visible = true;
            addDocfilePathTextBox.Visible = false;
            guna2PictureBox1.Visible = true;
            addDocBrowseBtn.Visible = true;


        }

        private void addDocument1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewDiary_Click(object sender, EventArgs e)
        {
            //diaryDataGridView.Visible = false;
            //addDiaryUC1.Visible = true;
            addDiaryPanel1.Visible = true;
            addDiaryDateTextBox.Text = "";
            addDiaryTitleTextBox.Text = "";
            addDiaryContetTextBox.Text = "";
            
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            //documentPanel.Show();
            documentPanel.Visible = true;
            //diaryPanel.Show();
            diaryPanel.Visible = true;
            //sharedPanel.Hide();
            sharedPanel.Visible = false;
            //addDiaryUC.Hide();
            //addDiaryUC1.Visible = false;
            addDiaryPanel1.Visible = false;
            //diaryDataGridView.Hide();
            diaryDataGridView.Visible = true;
            personalDiaryClient = new DiaryService.PersonalDiaryClient("BasicHttpsBinding_IPersonalDiary");
            diaries = personalDiaryClient.getAllDiaryData(UserConfiguration.strUserEmail);

            diaryDataGridView.Rows.Clear();
            for (int i = 0; i < diaries.Length; i++)
            {

                diaryDataBindingSource.Add(new DiaryData() { date = diaries[i].date, title = diaries[i].title });
            }

        }

        private void addDiaryPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //addDiaryUC1.Visible = false;
            addDiaryPanel1.Visible = false;
             diaryDataGridView.Visible = true ;
             personalDiaryClient = new DiaryService.PersonalDiaryClient("BasicHttpsBinding_IPersonalDiary");
             diaries = personalDiaryClient.getAllDiaryData(UserConfiguration.strUserEmail);

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
            //addDocumentUC.Hide();
            //addDocumentUC1.Visible = false;
            addDocumentPanel.Visible = false;
            //documentSharingUC.Hide();
            documentSharingUC1.Visible = false;
            //axAcroPDF1.Hide();
            axAcroPDF1.Visible = false;
            //documentDataGridView.Show();
            documentDataGridView.Visible = true;
            
             documentServiceClient = new DocumentService.DocumentServiceClient("BasicHttpBinding_IDocumentService");
             documents = documentServiceClient.getAllDocumnetData(UserConfiguration.strUserEmail);

            
                documentDataGridView.Rows.Clear();
                for (int i = 0; i < documents.Length; i++)
                {

                    documentDataBindingSource.Add(new DocumentService.DocumentData() { fileName = documents[i].fileName });
                }
            
        }

        private void documentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (documentDataGridView.Columns[e.ColumnIndex].Name == "viewPdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;
                    currentlyOpenedFile = documents[e.RowIndex].fileName;
                    axAcroPDF1.src = documents[e.RowIndex].fileLink;
                    
                    axAcroPDF1.Visible = true;
                    
                    MessageBox.Show(documents[e.RowIndex].fileName + " opening...");
                }

                
            }

            if (documentDataGridView.Columns[e.ColumnIndex].Name == "sharePdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;
                    sharedBy = UserConfiguration.strUserEmail;
                    documentData = new SharingService.DocumentData();
                    documentData.fileName = documents[e.RowIndex].fileName;
                    documentData.fileLink = documents[e.RowIndex].fileLink;

                    documentSharingPanel.Visible = true;
                    sharedToTextBox.Text = "";
                }

               
            }

            if (documentDataGridView.Columns[e.ColumnIndex].Name == "deletePdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;
                    documentServiceClient = new DocumentService.DocumentServiceClient("BasicHttpBinding_IDocumentService");

                    documentServiceClient.deleteDocument(UserConfiguration.strUserEmail, documents[e.RowIndex].fileName);

                    MessageBox.Show(documents[e.RowIndex].fileName + " deleted.");

                    if (currentlyOpenedFile == documents[e.RowIndex].fileName)
                    {
                        axAcroPDF1.Visible = false;
                    }
                    documents = documentServiceClient.getAllDocumnetData(UserConfiguration.strUserEmail);

                    documentDataGridView.Rows.Clear();
                    for (int i = 0; i < documents.Length; i++)
                    {

                        documentDataBindingSource.Add(new DocumentService.DocumentData() { fileName = documents[i].fileName });
                    }
                }

                               
                
                
            }
        }

        private void addDocument1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            sharedPanel.Visible = false;
        }

        private void sharedDocumentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( sharedDocumentDataGridView.Columns[e.ColumnIndex].Name == "viewSharedPdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;
                    currentlyOpenedSharedFile = sharedDocments[e.RowIndex].fileName;
                    sharedDocumentViewer.src = sharedDocments[e.RowIndex].fileLink;
                    
                    sharedDocumentViewer.Visible = true;


                    MessageBox.Show(sharedDocments[e.RowIndex].fileName + " opening...");
                }

                
            }

            if ( sharedDocumentDataGridView.Columns[e.ColumnIndex].Name == "shareSharedPdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;
                    sharedBy = UserConfiguration.strUserEmail;
                    documentData = new SharingService.DocumentData();
                    documentData.fileName = sharedDocments[e.RowIndex].fileName;
                    documentData.fileLink = sharedDocments[e.RowIndex].fileLink;


                    
                    sharedDocumentSharingPanel.Visible = true;
                    sharedDocSharingTextBox.Text = "";
                }

                
            }

            if (sharedDocumentDataGridView.Columns[e.ColumnIndex].Name == "deleteSharedPdf")
            {

                AccessPin ap1 = new AccessPin();
                ap1.ShowDialog();

                if (AccessPin.isAutorized)
                {
                    AccessPin.isAutorized = false;

                    sharedTo = UserConfiguration.strUserEmail;
                    sharedDocumentData = new SharedDocumentData();
                    sharedDocumentData.fileName = sharedDocments[e.RowIndex].fileName;
                    sharedDocumentData.fileLink = sharedDocments[e.RowIndex].fileLink;
                    sharedDocumentData.sharedBy = sharedDocments[e.RowIndex].sharedBy;

                    sharingServiceClient = new SharingServiceClient("BasicHttpsBinding_ISharingService");
                    sharingServiceClient.deleteSharedDocument(sharedDocumentData, sharedTo);


                    MessageBox.Show(sharedDocments[e.RowIndex].fileName + " deleted.");

                    if (currentlyOpenedSharedFile == sharedDocments[e.RowIndex].fileName)
                    {
                        sharedDocumentViewer.Visible = false;
                    }

                    sharingServiceClient = new SharingService.SharingServiceClient("BasicHttpsBinding_ISharingService");
                    sharedDocments = sharingServiceClient.getSharedDocument(UserConfiguration.strUserEmail);


                    sharedDocumentDataGridView.Rows.Clear();
                    for (int i = 0; i < sharedDocments.Length; i++)
                    {

                        sharedDocumentDataBindingSource.Add(new SharedDocumentData() { fileName = sharedDocments[i].fileName, sharedBy = sharedDocments[i].sharedBy });
                    }
                }

                
                

                


            }
        }

        private void diaryAddPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addDiary1_Load(object sender, EventArgs e)
        {

        }

        private void sharedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            documentSharingPanel.Visible = false;
        }

        private void docSharingPanelShareBtn_Click(object sender, EventArgs e)
        {
            sharingServiceClient = new SharingServiceClient("BasicHttpsBinding_ISharingService");
            sharingServiceClient.shareDocument(documentData,  sharedBy, sharedToTextBox.Text);
            documentSharingPanel.Visible = false;
            MessageBox.Show("Document shared to " + sharedToTextBox.Text);
        }

        private void addDocCancelBtn_Click(object sender, EventArgs e)
        {
            addDocumentPanel.Visible = false;
        }

        private void addDocUploadBtn_Click(object sender, EventArgs e)
        {
            string fileName = addDocfileNameTextBox.Text;
            fileName = fileName + ".pdf";
            byte[] readFile = File.ReadAllBytes(filePath);
            documentServiceClient = new DocumentService.DocumentServiceClient("BasicHttpBinding_IDocumentService");
            documentServiceClient.uploadDocument(readFile, fileName, UserConfiguration.strUserEmail);
            MessageBox.Show("Document Uploaded");
            addDocumentPanel.Visible = false;
        }

        private void addDocBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select your file from here";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 filePath = openFileDialog1.FileName;

                guna2PictureBox1.Visible = false;

                addDocBrowseBtn.Visible = false;
                addDocfilePathTextBox.Text = filePath;

                addDocfilePathTextBox.Visible = true;
            }

        }

        private void addDiaryCancelBtn_Click(object sender, EventArgs e)
        {
            addDiaryPanel1.Visible = false;
        }

        private void addDiarySubmitBtn_Click(object sender, EventArgs e)
        {
            string date = addDiaryDateTextBox.Text;
            string title = addDiaryTitleTextBox.Text;
            string content = addDiaryContetTextBox.Text;

            personalDiaryClient = new DiaryService.PersonalDiaryClient("BasicHttpsBinding_IPersonalDiary");
            personalDiaryClient.UploadDayThought(date, title, content, UserConfiguration.strUserEmail);
            MessageBox.Show("Diary saved.");
            addDiaryPanel1.Visible = false;
        }

        private void sharedDocumentSharingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sharedDocSharingCancelBtn_Click(object sender, EventArgs e)
        {
            sharedDocumentSharingPanel.Visible = false;
        }

        private void sharedDocSharingShareBtn_Click(object sender, EventArgs e)
        {
            string sharedTo = sharedDocSharingTextBox.Text;
            sharingServiceClient = new SharingService.SharingServiceClient("BasicHttpsBinding_ISharingService");
            sharingServiceClient.shareDocument(documentData, sharedBy, sharedTo);
            sharedDocumentSharingPanel.Visible = false;
            MessageBox.Show("Document shared to " + sharedTo);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UserConfiguration.strUserEmail = "";
            this.Close();
            Environment.Exit(0);
        }

        private void addAccCancelBtn_Click(object sender, EventArgs e)
        {

            addAccountPanel.Visible = false;
        }

        private void addAccountAddBtn_Click(object sender, EventArgs e)
        {
            string userAccountname = addAccNameTextBox.Text;
            string userAccountUserName = addAccUserNameTextBox.Text;
            string userAccountPassowrd = addAccPasswordTextBox.Text;

            if (string.IsNullOrEmpty(userAccountname) || string.IsNullOrEmpty(userAccountUserName) || string.IsNullOrEmpty(userAccountPassowrd))
            {

                MessageBox.Show("All Fields are Required");
            }
            else
            {
                AccountService.UserAccountData userAccountData = new AccountService.UserAccountData();
                userAccountData.UserAccountName = userAccountname;
                userAccountData.UserName = userAccountUserName;
                userAccountData.Password = userAccountPassowrd;
                userAccountData.userEmail = UserConfiguration.strUserEmail;
                accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                accountServiceClient.addAccount(userAccountData);
                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Your Account is Successfully Added.");
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();
                addAccountPanel.Visible = false;
            }
            
        }

        private void passGenCancelBtn_Click(object sender, EventArgs e)
        {
            addAccGenerateBtn.Enabled = true;
            passwordGeneratorPanel.Visible = false;
        }

        private void passGenCreateBtn_Click(object sender, EventArgs e)
        {
            int min = (int)passGenMinNumUD.Value;
            int max = (int)passGenMaxNumUD.Value;

            PasswordGenerator passwordGenerator = new PasswordGenerator(min, max);

            string password_Obtained = passwordGenerator.Generate();

            addAccPasswordTextBox.Text = password_Obtained;

            passwordGeneratorPanel.Visible = false;

            addAccGenerateBtn.Enabled = true;
        }

        private void addAccGenerateBtn_Click(object sender, EventArgs e)
        {
            addAccGenerateBtn.Enabled = false;
            passwordGeneratorPanel.Visible = true;
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            addAccountPanel.Visible = true;

            passwordGeneratorPanel.Visible = false;

            addAccNameTextBox.Text = "";
            addAccUserNameTextBox.Text = "";
            addAccPasswordTextBox.Text = "";
        }

        private void updateAccCancelBtn_Click(object sender, EventArgs e)
        {
            updateAccountPanel.Visible = false;
        }

        private void updateAccAddBtn_Click(object sender, EventArgs e)
        {
            string userAccountname = updateAccountName;
            string userAccountUserName = updateAccUserNameTextBox.Text;
            string userAccountPassowrd = updateAccPasswordTextBox.Text;

            if (string.IsNullOrEmpty(userAccountname) || string.IsNullOrEmpty(userAccountUserName) || string.IsNullOrEmpty(userAccountPassowrd))
            {

                MessageBox.Show("All Fields are Required");
            }
            else
            {
                AccountService.UserAccountData userAccountData = new AccountService.UserAccountData();
                userAccountData.UserAccountName = userAccountname;
                userAccountData.UserName = userAccountUserName;
                userAccountData.Password = userAccountPassowrd;
                userAccountData.userEmail = UserConfiguration.strUserEmail;
                accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                accountServiceClient.updateAccount(userAccountData);
                SDMessageBox messageBox = new SDMessageBox();
                messageBox.setLabelMessage("Your Account is Successfully Updated.");
                System.Media.SystemSounds.Exclamation.Play();
                messageBox.ShowDialog();
                updateAccountPanel.Visible = false;
            }
        }

        private void accountDataGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accountDataGirdView.Columns[e.ColumnIndex].Name == "Proceed")
            {
                if (accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value == null)
                {
                    MessageBox.Show("You haven't selected any task.");
                    return;
                }
                //MessageBox.Show(accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString() +" : "+ accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString());
                if (accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString() == "View Account")
                {
                    
                    AccessPin ap1 = new AccessPin();
                    ap1.ShowDialog();

                    if(AccessPin.isAutorized)
                    {
                        AccessPin.isAutorized = false;
                        accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                        AccountService.UserAccountData userAccountData = new AccountService.UserAccountData();
                        userAccountData = accountServiceClient.requestDecryption(UserConfiguration.strUserEmail, accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString());
                        MessageBox.Show("Account Name : " + accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString() + "\nUsername : " + userAccountData.UserName + "\nPassword : " + userAccountData.Password);
                    }
                    
                }
                if (accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString() == "Update Account")
                {
                    //MessageBox.Show(accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString() + " : " + accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString());

                    AccessPin ap1 = new AccessPin();
                    ap1.ShowDialog();

                    if (AccessPin.isAutorized)
                    {
                        AccessPin.isAutorized = false;
                        updateAccountPanel.Visible = true;
                        updatePasswordGeneratorPanel.Visible = false;

                        updateAccUserNameTextBox.Text = "";
                        updateAccPasswordTextBox.Text = "";

                        updateAccountName = accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString();
                        updateAccLabel.Text = "Update Your " + updateAccountName + " Account ";
                    }

                    
                }
                if (accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString() == "Delete Account")
                {
                    //MessageBox.Show(accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString() + " : " + accountDataGirdView.Rows[e.RowIndex].Cells["Task"].Value.ToString());

                    AccessPin ap1 = new AccessPin();
                    ap1.ShowDialog();

                    if (AccessPin.isAutorized)
                    {
                        AccessPin.isAutorized = false;
                        accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                        AccountService.UserAccountData userAccountData1 = new AccountService.UserAccountData();
                        userAccountData1.userEmail = UserConfiguration.strUserEmail;
                        userAccountData1.UserAccountName = accountDataGirdView.Rows[e.RowIndex].Cells["userAccountNameDataGridViewTextBoxColumn"].Value.ToString();
                        accountServiceClient.deleteAccount(userAccountData1);
                        SDMessageBox messageBox = new SDMessageBox();
                        messageBox.setLabelMessage("Your Account is Successfully Deleted.");
                        System.Media.SystemSounds.Exclamation.Play();
                        messageBox.ShowDialog();

                        accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                        userAccountData = accountServiceClient.getAllAccounts(UserConfiguration.strUserEmail);

                        accountDataGirdView.Rows.Clear();


                        for (int i = 0; i < userAccountData.Length; i++)
                        {

                            userAccountDataBindingSource.Add(new AccountService.UserAccountData() { UserAccountName = userAccountData[i].UserAccountName });

                        }
                    }

                    
                }
            }
            
        }

        private void accountRefreshBtn_Click(object sender, EventArgs e)
        {
            addAccountPanel.Visible = false;

            updateAccountPanel.Visible = false;

            accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
            userAccountData = accountServiceClient.getAllAccounts(UserConfiguration.strUserEmail);

            accountDataGirdView.Rows.Clear();


            for (int i = 0; i < userAccountData.Length; i++)
            {

                userAccountDataBindingSource.Add(new AccountService.UserAccountData() { UserAccountName = userAccountData[i].UserAccountName });

            }
        }

        private void updateAccGenerateBtn_Click(object sender, EventArgs e)
        {
            updateAccGenerateBtn.Enabled = false;
            updatePasswordGeneratorPanel.Visible = true;
        }

        private void upPassGenCancelBtn_Click(object sender, EventArgs e)
        {
            updateAccGenerateBtn.Enabled = true;
            updatePasswordGeneratorPanel.Visible = false;
        }

        private void upPassGenCreateBtn_Click(object sender, EventArgs e)
        {
            int min = (int)upPassGenMinNumUD.Value;
            int max = (int)upPassGenMaxNumUD.Value;

            PasswordGenerator passwordGenerator = new PasswordGenerator(min, max);

            string password_Obtained = passwordGenerator.Generate();

            updateAccPasswordTextBox.Text = password_Obtained;

            updatePasswordGeneratorPanel.Visible = false;

            updateAccGenerateBtn.Enabled = true;
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("Enter search text.");
                return;
            }
            if (searchComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select type for search text");
                return;
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Diaries")
            {

                //MessageBox.Show("Search type : "+ searchComboBox.Items[searchComboBox.SelectedIndex].ToString()+"\nSearch text : "+ searchTextBox.Text);
                guna2Button4.PerformClick();

                diaryDataGridView.Visible = true;
                personalDiaryClient = new DiaryService.PersonalDiaryClient("BasicHttpsBinding_IPersonalDiary");
                diaries = personalDiaryClient.getAllDiaryData(UserConfiguration.strUserEmail);
                bool[] isMatched = new bool[diaries.Length];

                diaryDataGridView.Rows.Clear();
                for (int i = 0; i < diaries.Length; i++)
                {
                    if (diaries[i].title.ToLower().Contains(searchTextBox.Text.ToLower()))
                        isMatched[i] = true;
                    else
                        isMatched[i] = false;
                    
                }
                for (int i = 0; i < diaries.Length; i++)
                {
                    if (isMatched[i])
                    {
                        diaryDataBindingSource.Add(new DiaryData() { date = diaries[i].date, title = diaries[i].title });
                    }
                    
                }
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Documents")
            {
                //MessageBox.Show("Search type : " + searchComboBox.Items[searchComboBox.SelectedIndex].ToString() + "\nSearch text : " + searchTextBox.Text);
                guna2Button1.PerformClick();

                documentDataGridView.Visible = true;

                documentServiceClient = new DocumentService.DocumentServiceClient("BasicHttpBinding_IDocumentService");
                documents = documentServiceClient.getAllDocumnetData(UserConfiguration.strUserEmail);
                bool[] isMatched = new bool[documents.Length];

                documentDataGridView.Rows.Clear();
                for (int i = 0; i < documents.Length; i++)
                {
                    if (documents[i].fileName.ToLower().Contains(searchTextBox.Text.ToLower()))
                        isMatched[i] = true;
                    else
                        isMatched[i] = false;
                    
                }
                for (int i = 0; i < documents.Length; i++)
                {
                    if (isMatched[i])
                    {
                        documentDataBindingSource.Add(new DocumentService.DocumentData() { fileName = documents[i].fileName });
                    }
                }
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Accounts")
            {
                //MessageBox.Show("Search type : " + searchComboBox.Items[searchComboBox.SelectedIndex].ToString() + "\nSearch text : " + searchTextBox.Text);
                
                AccountsBtn.PerformClick();
                accountServiceClient = new AccountService.AccountServiceClient("BasicHttpsBinding_IAccountService");
                userAccountData = accountServiceClient.getAllAccounts(UserConfiguration.strUserEmail);
                bool[] isMatched = new bool[userAccountData.Length];


                accountDataGirdView.Rows.Clear();
                

                for (int i = 0; i < userAccountData.Length; i++)
                {
                    if (userAccountData[i].UserAccountName.ToLower().Contains(searchTextBox.Text.ToLower()))
                        isMatched[i] = true;
                    else
                        isMatched[i] = false;
                    
                }
                for (int i = 0; i < userAccountData.Length; i++)
                {
                    if (isMatched[i])
                    {
                        userAccountDataBindingSource.Add(new AccountService.UserAccountData() { UserAccountName = userAccountData[i].UserAccountName });
                    }


                }
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Shared Documents")
            {
                //MessageBox.Show("Search type : " + searchComboBox.Items[searchComboBox.SelectedIndex].ToString() + "\nSearch text : " + searchTextBox.Text);
                guna2Button5.PerformClick();
                

                sharingServiceClient = new SharingService.SharingServiceClient("BasicHttpsBinding_ISharingService");
                sharedDocments = sharingServiceClient.getSharedDocument(UserConfiguration.strUserEmail);
                bool[] isMatched = new bool[sharedDocments.Length];

                sharedDocumentDataGridView.Rows.Clear();
                for (int i = 0; i < sharedDocments.Length; i++)
                {
                    if (sharedDocments[i].fileName.ToLower().Contains(searchTextBox.Text.ToLower()))
                        isMatched[i] = true;
                    else
                        isMatched[i] = false;

                    
                }
                for (int i = 0; i < sharedDocments.Length; i++)
                {

                    if (isMatched[i])
                    {
                        sharedDocumentDataBindingSource.Add(new SharedDocumentData() { fileName = sharedDocments[i].fileName, sharedBy = sharedDocments[i].sharedBy });
                    }
                    
                }
            }
            
        }

        private void refreshSharedDocumentBtn_Click(object sender, EventArgs e)
        {
            sharedDocumentDataGridView.Visible = true;




            sharingServiceClient = new SharingService.SharingServiceClient("BasicHttpsBinding_ISharingService");
            sharedDocments = sharingServiceClient.getSharedDocument(UserConfiguration.strUserEmail);


            sharedDocumentDataGridView.Rows.Clear();
            for (int i = 0; i < sharedDocments.Length; i++)
            {

                sharedDocumentDataBindingSource.Add(new SharedDocumentData() { fileName = sharedDocments[i].fileName, sharedBy = sharedDocments[i].sharedBy });
            }


        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Diaries")
            {

                guna2Button4.PerformClick();

                
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Documents")
            {
                guna2Button1.PerformClick();

                
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Accounts")
            {
                
                AccountsBtn.PerformClick();
                
            }
            if (searchComboBox.Items[searchComboBox.SelectedIndex].ToString() == "Shared Documents")
            {
                guna2Button5.PerformClick();


                
            }
        }
    }
}
