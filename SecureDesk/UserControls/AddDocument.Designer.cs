
namespace SecureDesk.UserControls
{
    partial class AddDocument
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.documentUpload = new Guna.UI2.WinForms.Guna2Button();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.FileNametext = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Document Using Secure Desk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(185, 17);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(455, 33);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Your File Name";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2TextBox1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecureDesk.Properties.Resources.documnetUpload;
            this.pictureBox1.Location = new System.Drawing.Point(-384, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1565, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Animated = true;
            this.browseBtn.AnimatedGIF = true;
            this.browseBtn.AutoRoundedCorners = true;
            this.browseBtn.BackColor = System.Drawing.Color.Transparent;
            this.browseBtn.BorderRadius = 21;
            this.browseBtn.CheckedState.Parent = this.browseBtn;
            this.browseBtn.CustomImages.Parent = this.browseBtn;
            this.browseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.HoverState.Parent = this.browseBtn;
            this.browseBtn.Location = new System.Drawing.Point(313, 317);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.ShadowDecoration.Parent = this.browseBtn;
            this.browseBtn.Size = new System.Drawing.Size(155, 45);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse Files";
            this.browseBtn.UseTransparentBackground = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "@\"C:\\\"";
            // 
            // documentUpload
            // 
            this.documentUpload.Animated = true;
            this.documentUpload.AnimatedGIF = true;
            this.documentUpload.BorderRadius = 12;
            this.documentUpload.CheckedState.Parent = this.documentUpload;
            this.documentUpload.CustomImages.Parent = this.documentUpload;
            this.documentUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.documentUpload.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.documentUpload.ForeColor = System.Drawing.Color.FloralWhite;
            this.documentUpload.HoverState.Parent = this.documentUpload;
            this.documentUpload.Location = new System.Drawing.Point(20, 157);
            this.documentUpload.Name = "documentUpload";
            this.documentUpload.ShadowDecoration.Parent = this.documentUpload;
            this.documentUpload.Size = new System.Drawing.Size(106, 35);
            this.documentUpload.TabIndex = 5;
            this.documentUpload.Text = "Upload";
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocationLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fileLocationLabel.Location = new System.Drawing.Point(16, 82);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(103, 21);
            this.fileLocationLabel.TabIndex = 8;
            this.fileLocationLabel.Text = "File Location";
            // 
            // FileNametext
            // 
            this.FileNametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileNametext.DefaultText = "";
            this.FileNametext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileNametext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileNametext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNametext.DisabledState.Parent = this.FileNametext;
            this.FileNametext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNametext.FillColor = System.Drawing.Color.WhiteSmoke;
            this.FileNametext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNametext.FocusedState.Parent = this.FileNametext;
            this.FileNametext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNametext.ForeColor = System.Drawing.Color.Black;
            this.FileNametext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNametext.HoverState.Parent = this.FileNametext;
            this.FileNametext.Location = new System.Drawing.Point(185, 70);
            this.FileNametext.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FileNametext.Name = "FileNametext";
            this.FileNametext.PasswordChar = '\0';
            this.FileNametext.PlaceholderText = "";
            this.FileNametext.SelectedText = "";
            this.FileNametext.ShadowDecoration.Parent = this.FileNametext;
            this.FileNametext.Size = new System.Drawing.Size(455, 33);
            this.FileNametext.TabIndex = 9;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Animated = true;
            this.Cancelbtn.AnimatedGIF = true;
            this.Cancelbtn.BorderRadius = 12;
            this.Cancelbtn.CheckedState.Parent = this.Cancelbtn;
            this.Cancelbtn.CustomImages.Parent = this.Cancelbtn;
            this.Cancelbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.Cancelbtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.Cancelbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.Cancelbtn.HoverState.Parent = this.Cancelbtn;
            this.Cancelbtn.Location = new System.Drawing.Point(185, 157);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.ShadowDecoration.Parent = this.Cancelbtn;
            this.Cancelbtn.Size = new System.Drawing.Size(106, 35);
            this.Cancelbtn.TabIndex = 10;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.AnimatedGIF = true;
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.BorderRadius = 12;
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.cancelButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(629, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.FileNametext);
            this.Controls.Add(this.fileLocationLabel);
            this.Controls.Add(this.documentUpload);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddDocument";
            this.Size = new System.Drawing.Size(793, 397);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button browseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button documentUpload;
        private System.Windows.Forms.Label fileLocationLabel;
        private Guna.UI2.WinForms.Guna2TextBox FileNametext;
        private Guna.UI2.WinForms.Guna2Button Cancelbtn;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
    }
}
