
namespace SecureDesk.UserControls
{
    partial class addAccounts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.accountName = new Guna.UI2.WinForms.Guna2TextBox();
            this.generatePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.submitAccountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordLengthPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lenghtBtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.maxLengthTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.minLenghtTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoLabel.Location = new System.Drawing.Point(11, 11);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(454, 33);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Add Your Account Details On Secure Desk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(22, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Animated = true;
            this.userNameTextBox.BorderRadius = 7;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.Parent = this.userNameTextBox;
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.userNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.FocusedState.Parent = this.userNameTextBox;
            this.userNameTextBox.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Italic);
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.userNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.HoverState.Parent = this.userNameTextBox;
            this.userNameTextBox.Location = new System.Drawing.Point(188, 124);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.ShadowDecoration.Parent = this.userNameTextBox;
            this.userNameTextBox.Size = new System.Drawing.Size(168, 21);
            this.userNameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.BorderRadius = 7;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Italic);
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(188, 168);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(168, 21);
            this.passwordTextBox.TabIndex = 6;
            // 
            // accountName
            // 
            this.accountName.Animated = true;
            this.accountName.BorderRadius = 7;
            this.accountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountName.DefaultText = "";
            this.accountName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.accountName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.accountName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.accountName.DisabledState.Parent = this.accountName;
            this.accountName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.accountName.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.accountName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accountName.FocusedState.Parent = this.accountName;
            this.accountName.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Italic);
            this.accountName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.accountName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accountName.HoverState.Parent = this.accountName;
            this.accountName.Location = new System.Drawing.Point(188, 79);
            this.accountName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountName.Name = "accountName";
            this.accountName.PasswordChar = '\0';
            this.accountName.PlaceholderText = "";
            this.accountName.SelectedText = "";
            this.accountName.ShadowDecoration.Parent = this.accountName;
            this.accountName.Size = new System.Drawing.Size(168, 21);
            this.accountName.TabIndex = 7;
            // 
            // generatePasswordBtn
            // 
            this.generatePasswordBtn.Animated = true;
            this.generatePasswordBtn.BorderRadius = 7;
            this.generatePasswordBtn.CheckedState.Parent = this.generatePasswordBtn;
            this.generatePasswordBtn.CustomImages.Parent = this.generatePasswordBtn;
            this.generatePasswordBtn.FillColor = System.Drawing.SystemColors.Highlight;
            this.generatePasswordBtn.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.generatePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.generatePasswordBtn.HoverState.Parent = this.generatePasswordBtn;
            this.generatePasswordBtn.Location = new System.Drawing.Point(362, 168);
            this.generatePasswordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generatePasswordBtn.Name = "generatePasswordBtn";
            this.generatePasswordBtn.ShadowDecoration.Parent = this.generatePasswordBtn;
            this.generatePasswordBtn.Size = new System.Drawing.Size(86, 22);
            this.generatePasswordBtn.TabIndex = 8;
            this.generatePasswordBtn.Text = "Generate";
            this.generatePasswordBtn.Click += new System.EventHandler(this.generatePasswordBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.BorderRadius = 7;
            this.CancelBtn.CheckedState.Parent = this.CancelBtn;
            this.CancelBtn.CustomImages.Parent = this.CancelBtn;
            this.CancelBtn.FillColor = System.Drawing.SystemColors.Highlight;
            this.CancelBtn.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.HoverState.Parent = this.CancelBtn;
            this.CancelBtn.Location = new System.Drawing.Point(255, 222);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.ShadowDecoration.Parent = this.CancelBtn;
            this.CancelBtn.Size = new System.Drawing.Size(108, 24);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // submitAccountBtn
            // 
            this.submitAccountBtn.Animated = true;
            this.submitAccountBtn.BorderRadius = 7;
            this.submitAccountBtn.CheckedState.Parent = this.submitAccountBtn;
            this.submitAccountBtn.CustomImages.Parent = this.submitAccountBtn;
            this.submitAccountBtn.FillColor = System.Drawing.SystemColors.Highlight;
            this.submitAccountBtn.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.submitAccountBtn.ForeColor = System.Drawing.Color.White;
            this.submitAccountBtn.HoverState.Parent = this.submitAccountBtn;
            this.submitAccountBtn.Location = new System.Drawing.Point(117, 222);
            this.submitAccountBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitAccountBtn.Name = "submitAccountBtn";
            this.submitAccountBtn.ShadowDecoration.Parent = this.submitAccountBtn;
            this.submitAccountBtn.Size = new System.Drawing.Size(108, 24);
            this.submitAccountBtn.TabIndex = 10;
            this.submitAccountBtn.Text = "Add";
            this.submitAccountBtn.Click += new System.EventHandler(this.submitAccountBtn_Click);
            // 
            // passwordLengthPanel
            // 
            this.passwordLengthPanel.Controls.Add(this.lenghtBtnCancel);
            this.passwordLengthPanel.Controls.Add(this.maxNumericUpDown);
            this.passwordLengthPanel.Controls.Add(this.minNumbericUpDown);
            this.passwordLengthPanel.Controls.Add(this.okBtn);
            this.passwordLengthPanel.Controls.Add(this.maxLengthTextBox);
            this.passwordLengthPanel.Controls.Add(this.minLenghtTextBox);
            this.passwordLengthPanel.Controls.Add(this.maxLabel);
            this.passwordLengthPanel.Controls.Add(this.minLabel);
            this.passwordLengthPanel.Location = new System.Drawing.Point(116, 89);
            this.passwordLengthPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordLengthPanel.Name = "passwordLengthPanel";
            this.passwordLengthPanel.ShadowDecoration.Parent = this.passwordLengthPanel;
            this.passwordLengthPanel.Size = new System.Drawing.Size(240, 120);
            this.passwordLengthPanel.TabIndex = 11;
            // 
            // lenghtBtnCancel
            // 
            this.lenghtBtnCancel.Animated = true;
            this.lenghtBtnCancel.BorderRadius = 7;
            this.lenghtBtnCancel.CheckedState.Parent = this.lenghtBtnCancel;
            this.lenghtBtnCancel.CustomImages.Parent = this.lenghtBtnCancel;
            this.lenghtBtnCancel.FillColor = System.Drawing.SystemColors.Highlight;
            this.lenghtBtnCancel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lenghtBtnCancel.ForeColor = System.Drawing.Color.White;
            this.lenghtBtnCancel.HoverState.Parent = this.lenghtBtnCancel;
            this.lenghtBtnCancel.Location = new System.Drawing.Point(153, 89);
            this.lenghtBtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lenghtBtnCancel.Name = "lenghtBtnCancel";
            this.lenghtBtnCancel.ShadowDecoration.Parent = this.lenghtBtnCancel;
            this.lenghtBtnCancel.Size = new System.Drawing.Size(66, 22);
            this.lenghtBtnCancel.TabIndex = 12;
            this.lenghtBtnCancel.Text = "Cancel";
            this.lenghtBtnCancel.Click += new System.EventHandler(this.lenghtBtnCancel_Click);
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.maxNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxNumericUpDown.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNumericUpDown.Location = new System.Drawing.Point(178, 56);
            this.maxNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.maxNumericUpDown.TabIndex = 11;
            this.maxNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.maxNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // minNumbericUpDown
            // 
            this.minNumbericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minNumbericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minNumbericUpDown.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumbericUpDown.Location = new System.Drawing.Point(182, 13);
            this.minNumbericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minNumbericUpDown.Name = "minNumbericUpDown";
            this.minNumbericUpDown.Size = new System.Drawing.Size(45, 20);
            this.minNumbericUpDown.TabIndex = 10;
            this.minNumbericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minNumbericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // okBtn
            // 
            this.okBtn.Animated = true;
            this.okBtn.BorderRadius = 7;
            this.okBtn.CheckedState.Parent = this.okBtn;
            this.okBtn.CustomImages.Parent = this.okBtn;
            this.okBtn.FillColor = System.Drawing.SystemColors.Highlight;
            this.okBtn.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.HoverState.Parent = this.okBtn;
            this.okBtn.Location = new System.Drawing.Point(81, 89);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.ShadowDecoration.Parent = this.okBtn;
            this.okBtn.Size = new System.Drawing.Size(66, 22);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Ok";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.Animated = true;
            this.maxLengthTextBox.BorderRadius = 7;
            this.maxLengthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxLengthTextBox.DefaultText = "";
            this.maxLengthTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maxLengthTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maxLengthTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxLengthTextBox.DisabledState.Parent = this.maxLengthTextBox;
            this.maxLengthTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maxLengthTextBox.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.maxLengthTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxLengthTextBox.FocusedState.Parent = this.maxLengthTextBox;
            this.maxLengthTextBox.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Italic);
            this.maxLengthTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maxLengthTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maxLengthTextBox.HoverState.Parent = this.maxLengthTextBox;
            this.maxLengthTextBox.Location = new System.Drawing.Point(153, 51);
            this.maxLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.PasswordChar = '\0';
            this.maxLengthTextBox.PlaceholderText = "";
            this.maxLengthTextBox.SelectedText = "";
            this.maxLengthTextBox.ShadowDecoration.Parent = this.maxLengthTextBox;
            this.maxLengthTextBox.Size = new System.Drawing.Size(74, 24);
            this.maxLengthTextBox.TabIndex = 6;
            this.maxLengthTextBox.TextChanged += new System.EventHandler(this.maxLengthTextBox_TextChanged);
            // 
            // minLenghtTextBox
            // 
            this.minLenghtTextBox.Animated = true;
            this.minLenghtTextBox.BorderRadius = 7;
            this.minLenghtTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minLenghtTextBox.DefaultText = "";
            this.minLenghtTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.minLenghtTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.minLenghtTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minLenghtTextBox.DisabledState.Parent = this.minLenghtTextBox;
            this.minLenghtTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minLenghtTextBox.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.minLenghtTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minLenghtTextBox.FocusedState.Parent = this.minLenghtTextBox;
            this.minLenghtTextBox.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Italic);
            this.minLenghtTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.minLenghtTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minLenghtTextBox.HoverState.Parent = this.minLenghtTextBox;
            this.minLenghtTextBox.Location = new System.Drawing.Point(153, 10);
            this.minLenghtTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minLenghtTextBox.Name = "minLenghtTextBox";
            this.minLenghtTextBox.PasswordChar = '\0';
            this.minLenghtTextBox.PlaceholderText = "";
            this.minLenghtTextBox.SelectedText = "";
            this.minLenghtTextBox.ShadowDecoration.Parent = this.minLenghtTextBox;
            this.minLenghtTextBox.Size = new System.Drawing.Size(74, 24);
            this.minLenghtTextBox.TabIndex = 5;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.maxLabel.Location = new System.Drawing.Point(10, 49);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(149, 23);
            this.maxLabel.TabIndex = 4;
            this.maxLabel.Text = "Maximum Length:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.minLabel.Location = new System.Drawing.Point(10, 10);
            this.minLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(144, 23);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "Minimum Lenght:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // addAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.passwordLengthPanel);
            this.Controls.Add(this.submitAccountBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.generatePasswordBtn);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addAccounts";
            this.Size = new System.Drawing.Size(471, 263);
            this.Load += new System.EventHandler(this.addAccounts_Load);
            this.passwordLengthPanel.ResumeLayout(false);
            this.passwordLengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox accountName;
        private Guna.UI2.WinForms.Guna2Button generatePasswordBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button submitAccountBtn;
        private Guna.UI2.WinForms.Guna2Panel passwordLengthPanel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minNumbericUpDown;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2TextBox maxLengthTextBox;
        private Guna.UI2.WinForms.Guna2TextBox minLenghtTextBox;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private Guna.UI2.WinForms.Guna2Button lenghtBtnCancel;
    }
}
