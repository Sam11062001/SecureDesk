


namespace SecureDesk.UserControls
{
    partial class addDocumentFileUserControl 
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.documentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.submitDocument = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.instructionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(344, 143);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(99, 103);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "button1";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Document Name";
            // 
            // documentName
            // 
            this.documentName.Animated = true;
            this.documentName.BorderRadius = 10;
            this.documentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.documentName.DefaultText = "";
            this.documentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.documentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.documentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.documentName.DisabledState.Parent = this.documentName;
            this.documentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.documentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.documentName.FocusedState.Parent = this.documentName;
            this.documentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.documentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.documentName.HoverState.Parent = this.documentName;
            this.documentName.Location = new System.Drawing.Point(181, 14);
            this.documentName.Name = "documentName";
            this.documentName.PasswordChar = '\0';
            this.documentName.PlaceholderText = "";
            this.documentName.SelectedText = "";
            this.documentName.ShadowDecoration.Parent = this.documentName;
            this.documentName.Size = new System.Drawing.Size(424, 37);
            this.documentName.TabIndex = 4;
            // 
            // submitDocument
            // 
            this.submitDocument.BorderRadius = 15;
            this.submitDocument.CheckedState.Parent = this.submitDocument;
            this.submitDocument.CustomImages.Parent = this.submitDocument;
            this.submitDocument.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.submitDocument.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitDocument.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.submitDocument.HoverState.Parent = this.submitDocument;
            this.submitDocument.Location = new System.Drawing.Point(514, 384);
            this.submitDocument.Name = "submitDocument";
            this.submitDocument.ShadowDecoration.Parent = this.submitDocument;
            this.submitDocument.Size = new System.Drawing.Size(108, 45);
            this.submitDocument.TabIndex = 5;
            this.submitDocument.Text = "Add";
            // 
            // cancelButton
            // 
            this.cancelButton.BorderRadius = 15;
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(642, 384);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(108, 45);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.White;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.instructionLabel.Location = new System.Drawing.Point(288, 75);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(200, 27);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Click on arrow to browse";
            // 
            // addDocumentFileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitDocument);
            this.Controls.Add(this.documentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Name = "addDocumentFileUserControl";
            this.Size = new System.Drawing.Size(773, 442);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox documentName;
        private Guna.UI2.WinForms.Guna2Button submitDocument;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel instructionLabel;
    }
}
