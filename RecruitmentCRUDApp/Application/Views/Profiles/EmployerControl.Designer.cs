namespace RecruitmentApplication.Views.Profiles
{
    partial class EmployerControl
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
            panelHeader = new Panel();
            labelUserName = new Label();
            linkEditPhoto = new LinkLabel();
            profilePictureBox = new PictureBox();
            btnSaveChanges = new Button();
            tabCompany = new TabPage();
            buttonCreateCompany = new Button();
            comboBoxCompany = new ComboBox();
            labelCompany = new Label();
            tabPersonalInfo = new TabPage();
            birthDatePicker = new DateTimePicker();
            txtEmail = new TextBox();
            textBox4 = new TextBox();
            txtPhoneNumber = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            labelSignupDate = new Label();
            labelBirthDate = new Label();
            labelPhone = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelFullName = new Label();
            labelPersonalInfo = new Label();
            tabControlProfileInfo = new TabControl();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            tabCompany.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabControlProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Controls.Add(linkEditPhoto);
            panelHeader.Controls.Add(profilePictureBox);
            panelHeader.Location = new Point(8, 11);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(595, 176);
            panelHeader.TabIndex = 24;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(114, 19);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(144, 25);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Adham Hamdy";
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
            btnSaveChanges.Location = new Point(487, 578);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(112, 37);
            btnSaveChanges.TabIndex = 26;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChangesCompany_Click;
            // 
            // tabCompany
            // 
            tabCompany.Controls.Add(buttonCreateCompany);
            tabCompany.Controls.Add(comboBoxCompany);
            tabCompany.Controls.Add(labelCompany);
            tabCompany.Location = new Point(4, 24);
            tabCompany.Name = "tabCompany";
            tabCompany.Padding = new Padding(3);
            tabCompany.Size = new Size(587, 357);
            tabCompany.TabIndex = 1;
            tabCompany.Text = "Company";
            tabCompany.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(30, 187);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(106, 39);
            buttonCreateCompany.TabIndex = 3;
            buttonCreateCompany.Text = "Create company";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // comboBoxCompany
            // 
            comboBoxCompany.FormattingEnabled = true;
            comboBoxCompany.Location = new Point(30, 91);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(226, 23);
            comboBoxCompany.TabIndex = 2;
            comboBoxCompany.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompany.Location = new Point(30, 30);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(122, 32);
            labelCompany.TabIndex = 1;
            labelCompany.Text = "Company";
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.AutoScroll = true;
            tabPersonalInfo.Controls.Add(birthDatePicker);
            tabPersonalInfo.Controls.Add(txtEmail);
            tabPersonalInfo.Controls.Add(textBox4);
            tabPersonalInfo.Controls.Add(txtPhoneNumber);
            tabPersonalInfo.Controls.Add(txtPassword);
            tabPersonalInfo.Controls.Add(txtFullName);
            tabPersonalInfo.Controls.Add(labelSignupDate);
            tabPersonalInfo.Controls.Add(labelBirthDate);
            tabPersonalInfo.Controls.Add(labelPhone);
            tabPersonalInfo.Controls.Add(labelPassword);
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
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(127, 271);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(248, 23);
            birthDatePicker.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 124);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 320);
            textBox4.MaxLength = 15;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(248, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "16/05/2025";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(127, 222);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 9;
            txtPhoneNumber.Text = "01100123456";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 173);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 23);
            txtPassword.TabIndex = 8;
            txtPassword.Text = "12345678910";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(127, 75);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(248, 23);
            txtFullName.TabIndex = 7;
            txtFullName.Text = "Adham Hamdy Hamed Abdulhameid";
            // 
            // labelSignupDate
            // 
            labelSignupDate.AutoSize = true;
            labelSignupDate.Location = new Point(36, 334);
            labelSignupDate.Name = "labelSignupDate";
            labelSignupDate.Size = new Size(74, 15);
            labelSignupDate.TabIndex = 6;
            labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(36, 285);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(62, 15);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(36, 236);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(36, 187);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(36, 138);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(36, 89);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(30, 30);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(257, 32);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Controls.Add(tabCompany);
            tabControlProfileInfo.Location = new Point(8, 190);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(595, 385);
            tabControlProfileInfo.TabIndex = 25;
            tabControlProfileInfo.Tag = "";
            // 
            // EmployerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlProfileInfo);
            Controls.Add(panelHeader);
            Controls.Add(btnSaveChanges);
            Name = "EmployerControl";
            Size = new Size(617, 618);
            Load += EmployerControl_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            tabCompany.ResumeLayout(false);
            tabCompany.PerformLayout();
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            tabControlProfileInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelUserName;
        private LinkLabel linkEditPhoto;
        private PictureBox profilePictureBox;
        private Button btnSaveChanges;
        private TabPage tabCompany;
        private Label labelCompany;
        private TabPage tabPersonalInfo;
        private DateTimePicker birthDatePicker;
        private TextBox txtEmail;
        private TextBox textBox4;
        private TextBox txtPhoneNumber;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private Label labelSignupDate;
        private Label labelBirthDate;
        private Label labelPhone;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelPersonalInfo;
        private TabControl tabControlProfileInfo;
        private ComboBox comboBoxCompany;
        private Button buttonCreateCompany;
    }
}
