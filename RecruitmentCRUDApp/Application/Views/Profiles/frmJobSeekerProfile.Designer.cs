﻿namespace RecruitmentApplication.Views.Profiles
{
    partial class frmJobSeekerProfile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobSeekerProfile));
            toolStrip1 = new ToolStrip();
            navJobsBtn = new ToolStripButton();
            navProfileBtn = new ToolStripButton();
            navLogoutBtn = new ToolStripButton();
            panelHeader = new Panel();
            labelJobTitle = new Label();
            labelUserName = new Label();
            linkEditPhoto = new LinkLabel();
            profilePictureBox = new PictureBox();
            button1 = new Button();
            btnCancel = new Button();
            tabResume = new TabPage();
            labelResumeStatus = new Label();
            labelCurrentResume = new Label();
            btnPreview = new Button();
            btnRemove = new Button();
            btnUpload = new Button();
            labelResume = new Label();
            tabSkillsAndInterests = new TabPage();
            richTextInterests = new RichTextBox();
            labelInterests = new Label();
            labelSkills = new Label();
            checkedListBox1 = new CheckedListBox();
            labelSkillAndInterests = new Label();
            tabPersonalInfo = new TabPage();
            linkChangePassword = new LinkLabel();
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
            toolStrip1.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            tabResume.SuspendLayout();
            tabSkillsAndInterests.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabControlProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { navJobsBtn, navProfileBtn, navLogoutBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(171, 619);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // navJobsBtn
            // 
            navJobsBtn.AutoSize = false;
            navJobsBtn.Image = (Image)resources.GetObject("navJobsBtn.Image");
            navJobsBtn.ImageTransparentColor = Color.Magenta;
            navJobsBtn.Name = "navJobsBtn";
            navJobsBtn.Overflow = ToolStripItemOverflow.Never;
            navJobsBtn.Padding = new Padding(10);
            navJobsBtn.Size = new Size(170, 45);
            navJobsBtn.Text = "Jobs";
            // 
            // navProfileBtn
            // 
            navProfileBtn.AutoSize = false;
            navProfileBtn.Image = (Image)resources.GetObject("navProfileBtn.Image");
            navProfileBtn.ImageTransparentColor = Color.Magenta;
            navProfileBtn.Name = "navProfileBtn";
            navProfileBtn.Overflow = ToolStripItemOverflow.Never;
            navProfileBtn.Padding = new Padding(10);
            navProfileBtn.Size = new Size(170, 45);
            navProfileBtn.Text = "Profile";
            // 
            // navLogoutBtn
            // 
            navLogoutBtn.AutoSize = false;
            navLogoutBtn.Image = (Image)resources.GetObject("navLogoutBtn.Image");
            navLogoutBtn.ImageTransparentColor = Color.Magenta;
            navLogoutBtn.Name = "navLogoutBtn";
            navLogoutBtn.Overflow = ToolStripItemOverflow.Never;
            navLogoutBtn.Padding = new Padding(10);
            navLogoutBtn.Size = new Size(170, 45);
            navLogoutBtn.Text = "Log Out";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelJobTitle);
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Controls.Add(linkEditPhoto);
            panelHeader.Controls.Add(profilePictureBox);
            panelHeader.Location = new Point(172, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(595, 176);
            panelHeader.TabIndex = 2;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJobTitle.Location = new Point(114, 44);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(71, 19);
            labelJobTitle.TabIndex = 3;
            labelJobTitle.Text = "Comedian";
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
            linkEditPhoto.LinkClicked += linkEditPhoto_LinkClicked;
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(8, 8);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(100, 140);
            profilePictureBox.TabIndex = 0;
            profilePictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(533, 577);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 19;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(651, 577);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 37);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabResume
            // 
            tabResume.Controls.Add(labelResumeStatus);
            tabResume.Controls.Add(labelCurrentResume);
            tabResume.Controls.Add(btnPreview);
            tabResume.Controls.Add(btnRemove);
            tabResume.Controls.Add(btnUpload);
            tabResume.Controls.Add(labelResume);
            tabResume.Location = new Point(4, 24);
            tabResume.Name = "tabResume";
            tabResume.Padding = new Padding(3);
            tabResume.Size = new Size(587, 357);
            tabResume.TabIndex = 2;
            tabResume.Text = "Resume";
            tabResume.UseVisualStyleBackColor = true;
            // 
            // labelResumeStatus
            // 
            labelResumeStatus.AutoSize = true;
            labelResumeStatus.Location = new Point(288, 161);
            labelResumeStatus.Name = "labelResumeStatus";
            labelResumeStatus.Size = new Size(104, 15);
            labelResumeStatus.TabIndex = 7;
            labelResumeStatus.Text = "No file uploaded...";
            // 
            // labelCurrentResume
            // 
            labelCurrentResume.AutoSize = true;
            labelCurrentResume.Location = new Point(187, 161);
            labelCurrentResume.Name = "labelCurrentResume";
            labelCurrentResume.Size = new Size(95, 15);
            labelCurrentResume.TabIndex = 6;
            labelCurrentResume.Text = "Current Resume:";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(29, 140);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(152, 36);
            btnPreview.TabIndex = 5;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(29, 182);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(152, 36);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(29, 98);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(152, 36);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // labelResume
            // 
            labelResume.AutoSize = true;
            labelResume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResume.Location = new Point(24, 24);
            labelResume.Name = "labelResume";
            labelResume.Size = new Size(103, 32);
            labelResume.TabIndex = 2;
            labelResume.Text = "Resume";
            // 
            // tabSkillsAndInterests
            // 
            tabSkillsAndInterests.Controls.Add(richTextInterests);
            tabSkillsAndInterests.Controls.Add(labelInterests);
            tabSkillsAndInterests.Controls.Add(labelSkills);
            tabSkillsAndInterests.Controls.Add(checkedListBox1);
            tabSkillsAndInterests.Controls.Add(labelSkillAndInterests);
            tabSkillsAndInterests.Location = new Point(4, 24);
            tabSkillsAndInterests.Name = "tabSkillsAndInterests";
            tabSkillsAndInterests.Padding = new Padding(3);
            tabSkillsAndInterests.Size = new Size(587, 357);
            tabSkillsAndInterests.TabIndex = 1;
            tabSkillsAndInterests.Text = "Skills and Interests";
            tabSkillsAndInterests.UseVisualStyleBackColor = true;
            // 
            // richTextInterests
            // 
            richTextInterests.Location = new Point(234, 89);
            richTextInterests.Name = "richTextInterests";
            richTextInterests.Size = new Size(332, 96);
            richTextInterests.TabIndex = 6;
            richTextInterests.Text = "";
            // 
            // labelInterests
            // 
            labelInterests.AutoSize = true;
            labelInterests.Location = new Point(234, 71);
            labelInterests.Name = "labelInterests";
            labelInterests.Size = new Size(51, 15);
            labelInterests.TabIndex = 5;
            labelInterests.Text = "Interests";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Location = new Point(23, 71);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(33, 15);
            labelSkills.TabIndex = 4;
            labelSkills.Text = "Skills";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Communication", "Teamwork", "Problem-solving", "Analytical skills", "Leadership", "Sales", "Management", "Data analysis", "Team leadership", "Organizational skills", "AI literacy", "Adaptability", "Process optimization", "Innovative thinking", "Conflict mitigation", "Data skills", "Coaching skills", "Strategic thinking", "Social media management", "E-commerce optimization", "Curiosity" });
            checkedListBox1.Location = new Point(23, 89);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(181, 238);
            checkedListBox1.TabIndex = 3;
            // 
            // labelSkillAndInterests
            // 
            labelSkillAndInterests.AutoSize = true;
            labelSkillAndInterests.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSkillAndInterests.Location = new Point(24, 24);
            labelSkillAndInterests.Name = "labelSkillAndInterests";
            labelSkillAndInterests.Size = new Size(228, 32);
            labelSkillAndInterests.TabIndex = 1;
            labelSkillAndInterests.Text = "Skills and Interests";
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.Controls.Add(linkChangePassword);
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
            // linkChangePassword
            // 
            linkChangePassword.AutoSize = true;
            linkChangePassword.Location = new Point(381, 181);
            linkChangePassword.Name = "linkChangePassword";
            linkChangePassword.Size = new Size(101, 15);
            linkChangePassword.TabIndex = 13;
            linkChangePassword.TabStop = true;
            linkChangePassword.Text = "Change Password";
            linkChangePassword.LinkClicked += linkChangePassword_LinkClicked;
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
            labelSignupDate.Location = new Point(30, 328);
            labelSignupDate.Name = "labelSignupDate";
            labelSignupDate.Size = new Size(74, 15);
            labelSignupDate.TabIndex = 6;
            labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(30, 279);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(62, 15);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(30, 230);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 181);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(30, 132);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(30, 83);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(24, 24);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(257, 32);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Controls.Add(tabSkillsAndInterests);
            tabControlProfileInfo.Controls.Add(tabResume);
            tabControlProfileInfo.Location = new Point(172, 186);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(595, 385);
            tabControlProfileInfo.TabIndex = 3;
            tabControlProfileInfo.Tag = "";
            // 
            // frmJobSeekerProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(button1);
            Controls.Add(btnCancel);
            Controls.Add(tabControlProfileInfo);
            Controls.Add(panelHeader);
            Controls.Add(toolStrip1);
            Name = "frmJobSeekerProfile";
            Text = "frmJobSeekerProfile";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            tabResume.ResumeLayout(false);
            tabResume.PerformLayout();
            tabSkillsAndInterests.ResumeLayout(false);
            tabSkillsAndInterests.PerformLayout();
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            tabControlProfileInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton navJobsBtn;
        private ToolStripButton navProfileBtn;
        private ToolStripButton navLogoutBtn;
        private Panel panelHeader;
        private PictureBox profilePictureBox;
        private LinkLabel linkEditPhoto;
        private Label labelUserName;
        private Label labelJobTitle;
        private Button button1;
        private Button btnCancel;
        private TabPage tabResume;
        private Label labelResumeStatus;
        private Label labelCurrentResume;
        private Button btnPreview;
        private Button btnRemove;
        private Button btnUpload;
        private Label labelResume;
        private TabPage tabSkillsAndInterests;
        private RichTextBox richTextInterests;
        private Label labelInterests;
        private Label labelSkills;
        private CheckedListBox checkedListBox1;
        private Label labelSkillAndInterests;
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
        private TabControl tabControlProfileInfo;
    }
}