namespace RecruitmentApplication.Views.Profiles
{
    partial class JobSeekerProfileControl
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
            this.labelUserName = new Label();
            this.linkEditPhoto = new LinkLabel();
            this.profilePictureBox = new PictureBox();
            this.tabControlProfileInfo = new TabControl();
            this.tabPersonalInfo = new TabPage();
            this.linkChangePassword = new LinkLabel();
            this.birthDatePicker = new DateTimePicker();
            this.txtEmail = new TextBox();
            this.textBox4 = new TextBox();
            this.txtPhoneNumber = new TextBox();
            this.txtPassword = new TextBox();
            this.txtFullName = new TextBox();
            this.labelSignupDate = new Label();
            this.labelBirthDate = new Label();
            this.labelPhone = new Label();
            this.labelPassword = new Label();
            this.labelEmail = new Label();
            this.labelFullName = new Label();
            this.labelPersonalInfo = new Label();
            this.tabSkillsAndInterests = new TabPage();
            this.richTextInterests = new RichTextBox();
            this.labelInterests = new Label();
            this.labelSkills = new Label();
            this.checkedListBox1 = new CheckedListBox();
            this.labelSkillAndInterests = new Label();
            this.tabResume = new TabPage();
            this.labelResumeStatus = new Label();
            this.labelCurrentResume = new Label();
            this.btnPreview = new Button();
            this.btnRemove = new Button();
            this.btnUpload = new Button();
            this.labelResume = new Label();
            this.panelHeader = new Panel();
            this.labelJobTitle = new Label();
            this.button1 = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize) this.profilePictureBox).BeginInit();
            this.tabControlProfileInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabSkillsAndInterests.SuspendLayout();
            this.tabResume.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelUserName.Location = new Point(114, 19);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new Size(144, 25);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Adham Hamdy";
            // 
            // linkEditPhoto
            // 
            this.linkEditPhoto.AutoSize = true;
            this.linkEditPhoto.Location = new Point(27, 151);
            this.linkEditPhoto.Name = "linkEditPhoto";
            this.linkEditPhoto.Size = new Size(62, 15);
            this.linkEditPhoto.TabIndex = 1;
            this.linkEditPhoto.TabStop = true;
            this.linkEditPhoto.Text = "Edit Photo";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new Point(8, 8);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new Size(100, 140);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // tabControlProfileInfo
            // 
            this.tabControlProfileInfo.Controls.Add(this.tabPersonalInfo);
            this.tabControlProfileInfo.Controls.Add(this.tabSkillsAndInterests);
            this.tabControlProfileInfo.Controls.Add(this.tabResume);
            this.tabControlProfileInfo.Location = new Point(3, 182);
            this.tabControlProfileInfo.Name = "tabControlProfileInfo";
            this.tabControlProfileInfo.SelectedIndex = 0;
            this.tabControlProfileInfo.Size = new Size(595, 385);
            this.tabControlProfileInfo.TabIndex = 21;
            this.tabControlProfileInfo.Tag = "";
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.AutoScroll = true;
            this.tabPersonalInfo.Controls.Add(this.linkChangePassword);
            this.tabPersonalInfo.Controls.Add(this.birthDatePicker);
            this.tabPersonalInfo.Controls.Add(this.txtEmail);
            this.tabPersonalInfo.Controls.Add(this.textBox4);
            this.tabPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.tabPersonalInfo.Controls.Add(this.txtPassword);
            this.tabPersonalInfo.Controls.Add(this.txtFullName);
            this.tabPersonalInfo.Controls.Add(this.labelSignupDate);
            this.tabPersonalInfo.Controls.Add(this.labelBirthDate);
            this.tabPersonalInfo.Controls.Add(this.labelPhone);
            this.tabPersonalInfo.Controls.Add(this.labelPassword);
            this.tabPersonalInfo.Controls.Add(this.labelEmail);
            this.tabPersonalInfo.Controls.Add(this.labelFullName);
            this.tabPersonalInfo.Controls.Add(this.labelPersonalInfo);
            this.tabPersonalInfo.Location = new Point(4, 24);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new Padding(3);
            this.tabPersonalInfo.Size = new Size(587, 357);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Information";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Location = new Point(384, 184);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new Size(101, 15);
            this.linkChangePassword.TabIndex = 13;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Change Password";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new Point(127, 271);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new Size(248, 23);
            this.birthDatePicker.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(127, 124);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(248, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(127, 320);
            this.textBox4.MaxLength = 15;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(248, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "16/05/2025";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new Point(127, 222);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new Size(248, 23);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.Text = "01100123456";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(127, 173);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(248, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "12345678910";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new Point(127, 75);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(248, 23);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.Text = "Adham Hamdy Hamed Abdulhameid";
            // 
            // labelSignupDate
            // 
            this.labelSignupDate.AutoSize = true;
            this.labelSignupDate.Location = new Point(33, 331);
            this.labelSignupDate.Name = "labelSignupDate";
            this.labelSignupDate.Size = new Size(74, 15);
            this.labelSignupDate.TabIndex = 6;
            this.labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new Point(33, 282);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new Size(62, 15);
            this.labelBirthDate.TabIndex = 5;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(33, 233);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(91, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(33, 184);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(33, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(33, 86);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(64, 15);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPersonalInfo.Location = new Point(27, 27);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new Size(257, 32);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information";
            // 
            // tabSkillsAndInterests
            // 
            this.tabSkillsAndInterests.Controls.Add(this.richTextInterests);
            this.tabSkillsAndInterests.Controls.Add(this.labelInterests);
            this.tabSkillsAndInterests.Controls.Add(this.labelSkills);
            this.tabSkillsAndInterests.Controls.Add(this.checkedListBox1);
            this.tabSkillsAndInterests.Controls.Add(this.labelSkillAndInterests);
            this.tabSkillsAndInterests.Location = new Point(4, 24);
            this.tabSkillsAndInterests.Name = "tabSkillsAndInterests";
            this.tabSkillsAndInterests.Padding = new Padding(3);
            this.tabSkillsAndInterests.Size = new Size(587, 357);
            this.tabSkillsAndInterests.TabIndex = 1;
            this.tabSkillsAndInterests.Text = "Skills and Interests";
            this.tabSkillsAndInterests.UseVisualStyleBackColor = true;
            // 
            // richTextInterests
            // 
            this.richTextInterests.Location = new Point(234, 89);
            this.richTextInterests.Name = "richTextInterests";
            this.richTextInterests.Size = new Size(332, 96);
            this.richTextInterests.TabIndex = 6;
            this.richTextInterests.Text = "";
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Location = new Point(237, 74);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new Size(51, 15);
            this.labelInterests.TabIndex = 5;
            this.labelInterests.Text = "Interests";
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Location = new Point(26, 74);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new Size(33, 15);
            this.labelSkills.TabIndex = 4;
            this.labelSkills.Text = "Skills";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] { "Communication", "Teamwork", "Problem-solving", "Analytical skills", "Leadership", "Sales", "Management", "Data analysis", "Team leadership", "Organizational skills", "AI literacy", "Adaptability", "Process optimization", "Innovative thinking", "Conflict mitigation", "Data skills", "Coaching skills", "Strategic thinking", "Social media management", "E-commerce optimization", "Curiosity" });
            this.checkedListBox1.Location = new Point(23, 89);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(181, 238);
            this.checkedListBox1.TabIndex = 3;
            // 
            // labelSkillAndInterests
            // 
            this.labelSkillAndInterests.AutoSize = true;
            this.labelSkillAndInterests.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelSkillAndInterests.Location = new Point(27, 27);
            this.labelSkillAndInterests.Name = "labelSkillAndInterests";
            this.labelSkillAndInterests.Size = new Size(228, 32);
            this.labelSkillAndInterests.TabIndex = 1;
            this.labelSkillAndInterests.Text = "Skills and Interests";
            // 
            // tabResume
            // 
            this.tabResume.Controls.Add(this.labelResumeStatus);
            this.tabResume.Controls.Add(this.labelCurrentResume);
            this.tabResume.Controls.Add(this.btnPreview);
            this.tabResume.Controls.Add(this.btnRemove);
            this.tabResume.Controls.Add(this.btnUpload);
            this.tabResume.Controls.Add(this.labelResume);
            this.tabResume.Location = new Point(4, 24);
            this.tabResume.Name = "tabResume";
            this.tabResume.Padding = new Padding(3);
            this.tabResume.Size = new Size(587, 357);
            this.tabResume.TabIndex = 2;
            this.tabResume.Text = "Resume";
            this.tabResume.UseVisualStyleBackColor = true;
            // 
            // labelResumeStatus
            // 
            this.labelResumeStatus.AutoSize = true;
            this.labelResumeStatus.Location = new Point(291, 164);
            this.labelResumeStatus.Name = "labelResumeStatus";
            this.labelResumeStatus.Size = new Size(104, 15);
            this.labelResumeStatus.TabIndex = 7;
            this.labelResumeStatus.Text = "No file uploaded...";
            // 
            // labelCurrentResume
            // 
            this.labelCurrentResume.AutoSize = true;
            this.labelCurrentResume.Location = new Point(190, 164);
            this.labelCurrentResume.Name = "labelCurrentResume";
            this.labelCurrentResume.Size = new Size(95, 15);
            this.labelCurrentResume.TabIndex = 6;
            this.labelCurrentResume.Text = "Current Resume:";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new Point(29, 140);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new Size(152, 36);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new Point(29, 182);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(152, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new Point(29, 98);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new Size(152, 36);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // labelResume
            // 
            this.labelResume.AutoSize = true;
            this.labelResume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelResume.Location = new Point(27, 27);
            this.labelResume.Name = "labelResume";
            this.labelResume.Size = new Size(103, 32);
            this.labelResume.TabIndex = 2;
            this.labelResume.Text = "Resume";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.GhostWhite;
            this.panelHeader.BorderStyle = BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.labelJobTitle);
            this.panelHeader.Controls.Add(this.labelUserName);
            this.panelHeader.Controls.Add(this.linkEditPhoto);
            this.panelHeader.Controls.Add(this.profilePictureBox);
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(595, 176);
            this.panelHeader.TabIndex = 20;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            this.labelJobTitle.Location = new Point(114, 44);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new Size(71, 19);
            this.labelJobTitle.TabIndex = 3;
            this.labelJobTitle.Text = "Comedian";
            // 
            // button1
            // 
            this.button1.Location = new Point(367, 569);
            this.button1.Name = "button1";
            this.button1.Size = new Size(112, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(485, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(112, 37);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // JobSeekerProfileControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tabControlProfileInfo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Name = "JobSeekerProfileControl";
            this.Size = new Size(602, 610);
            ((System.ComponentModel.ISupportInitialize) this.profilePictureBox).EndInit();
            this.tabControlProfileInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.tabSkillsAndInterests.ResumeLayout(false);
            this.tabSkillsAndInterests.PerformLayout();
            this.tabResume.ResumeLayout(false);
            this.tabResume.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label labelUserName;
        private LinkLabel linkEditPhoto;
        private PictureBox profilePictureBox;
        private TabControl tabControlProfileInfo;
        private TabPage tabPersonalInfo;
        private LinkLabel linkChangePassword;
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
        private TabPage tabSkillsAndInterests;
        private RichTextBox richTextInterests;
        private Label labelInterests;
        private Label labelSkills;
        private CheckedListBox checkedListBox1;
        private Label labelSkillAndInterests;
        private TabPage tabResume;
        private Label labelResumeStatus;
        private Label labelCurrentResume;
        private Button btnPreview;
        private Button btnRemove;
        private Button btnUpload;
        private Label labelResume;
        private Panel panelHeader;
        private Label labelJobTitle;
        private Button button1;
        private Button btnCancel;
    }
}
