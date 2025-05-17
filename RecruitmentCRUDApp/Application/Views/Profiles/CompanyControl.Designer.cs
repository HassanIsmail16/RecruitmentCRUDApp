namespace RecruitmentApplication.Views.Profiles
{
    partial class CompanyControl
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
            tabControlProfileInfo = new TabControl();
            tabPersonalInfo = new TabPage();
            textBoxDescryption = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            labelPhone = new Label();
            labelEmail = new Label();
            labelFullName = new Label();
            labelPersonalInfo = new Label();
            panelHeader = new Panel();
            labelUserName = new Label();
            linkEditPhoto = new LinkLabel();
            profilePictureBox = new PictureBox();
            btnSaveChanges = new Button();
            tabControlProfileInfo.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Location = new Point(6, 185);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(595, 385);
            tabControlProfileInfo.TabIndex = 28;
            tabControlProfileInfo.Tag = "";
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.AutoScroll = true;
            tabPersonalInfo.Controls.Add(textBoxDescryption);
            tabPersonalInfo.Controls.Add(label1);
            tabPersonalInfo.Controls.Add(txtEmail);
            tabPersonalInfo.Controls.Add(txtPhoneNumber);
            tabPersonalInfo.Controls.Add(txtName);
            tabPersonalInfo.Controls.Add(labelPhone);
            tabPersonalInfo.Controls.Add(labelEmail);
            tabPersonalInfo.Controls.Add(labelFullName);
            tabPersonalInfo.Controls.Add(labelPersonalInfo);
            tabPersonalInfo.Location = new Point(4, 24);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3);
            tabPersonalInfo.Size = new Size(587, 357);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Personal Information";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxDescryption
            // 
            textBoxDescryption.Location = new Point(145, 217);
            textBoxDescryption.MaxLength = 20;
            textBoxDescryption.Name = "textBoxDescryption";
            textBoxDescryption.Size = new Size(248, 23);
            textBoxDescryption.TabIndex = 13;
            textBoxDescryption.Text = "Best juice company in 2021,2022";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 220);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 12;
            label1.Text = "Descryption:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 124);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(145, 171);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 9;
            txtPhoneNumber.Text = "01100123456";
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 75);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 23);
            txtName.TabIndex = 7;
            txtName.Text = "Adham Hamdy Hamed Abdulhameid";
            txtName.TextChanged += txtFullName_TextChanged;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(42, 174);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(42, 127);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(42, 78);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(97, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Company Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(33, 33);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(257, 32);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Controls.Add(linkEditPhoto);
            panelHeader.Controls.Add(profilePictureBox);
            panelHeader.Location = new Point(6, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(595, 176);
            panelHeader.TabIndex = 27;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(114, 19);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(81, 25);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Bekhiro";
            // 
            // linkEditPhoto
            // 
            linkEditPhoto.AutoSize = true;
            linkEditPhoto.Location = new Point(27, 151);
            linkEditPhoto.Name = "linkEditPhoto";
            linkEditPhoto.Size = new Size(62, 15);
            linkEditPhoto.TabIndex = 1;
            linkEditPhoto.TabStop = true;
            linkEditPhoto.Text = "Edit Photo";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(8, 8);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(100, 140);
            profilePictureBox.TabIndex = 0;
            profilePictureBox.TabStop = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.DialogResult = DialogResult.Abort;
            btnSaveChanges.Location = new Point(485, 573);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(112, 37);
            btnSaveChanges.TabIndex = 29;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // CompanyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlProfileInfo);
            Controls.Add(panelHeader);
            Controls.Add(btnSaveChanges);
            Name = "CompanyControl";
            Size = new Size(608, 617);
            tabControlProfileInfo.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProfileInfo;
        private TabPage tabPersonalInfo;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelPersonalInfo;
        private Panel panelHeader;
        private Label labelUserName;
        private LinkLabel linkEditPhoto;
        private PictureBox profilePictureBox;
        private Button btnSaveChanges;
        private TextBox textBoxDescryption;
        private Label label1;
    }
}
