namespace RecruitmentApplication.Views.Profiles
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
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { navJobsBtn, navProfileBtn, navLogoutBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(171, 825);
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
            panelHeader.Location = new Point(197, 5);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(679, 233);
            panelHeader.TabIndex = 2;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJobTitle.Location = new Point(130, 59);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(88, 23);
            labelJobTitle.TabIndex = 3;
            labelJobTitle.Text = "Comedian";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(130, 25);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(174, 31);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Adham Hamdy";
            labelUserName.Click += labelUserName_Click;
            // 
            // linkEditPhoto
            // 
            linkEditPhoto.AutoSize = true;
            linkEditPhoto.Location = new Point(31, 201);
            linkEditPhoto.Name = "linkEditPhoto";
            linkEditPhoto.Size = new Size(78, 20);
            linkEditPhoto.TabIndex = 1;
            linkEditPhoto.TabStop = true;
            linkEditPhoto.Text = "Edit Photo";
            linkEditPhoto.LinkClicked += linkEditPhoto_LinkClicked;
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(9, 11);
            profilePictureBox.Margin = new Padding(3, 4, 3, 4);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(114, 187);
            profilePictureBox.TabIndex = 0;
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
            // 
            // button1
            // 
            button1.Location = new Point(609, 769);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 49);
            button1.TabIndex = 19;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(744, 769);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 49);
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
            tabResume.Location = new Point(4, 29);
            tabResume.Margin = new Padding(3, 4, 3, 4);
            tabResume.Name = "tabResume";
            tabResume.Padding = new Padding(3, 4, 3, 4);
            tabResume.Size = new Size(672, 480);
            tabResume.TabIndex = 2;
            tabResume.Text = "Resume";
            tabResume.UseVisualStyleBackColor = true;
            // 
            // labelResumeStatus
            // 
            labelResumeStatus.AutoSize = true;
            labelResumeStatus.Location = new Point(329, 215);
            labelResumeStatus.Name = "labelResumeStatus";
            labelResumeStatus.Size = new Size(131, 20);
            labelResumeStatus.TabIndex = 7;
            labelResumeStatus.Text = "No file uploaded...";
            // 
            // labelCurrentResume
            // 
            labelCurrentResume.AutoSize = true;
            labelCurrentResume.Location = new Point(214, 215);
            labelCurrentResume.Name = "labelCurrentResume";
            labelCurrentResume.Size = new Size(116, 20);
            labelCurrentResume.TabIndex = 6;
            labelCurrentResume.Text = "Current Resume:";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(33, 187);
            btnPreview.Margin = new Padding(3, 4, 3, 4);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(174, 48);
            btnPreview.TabIndex = 5;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(33, 243);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(174, 48);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(33, 131);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(174, 48);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // labelResume
            // 
            labelResume.AutoSize = true;
            labelResume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResume.Location = new Point(27, 32);
            labelResume.Name = "labelResume";
            labelResume.Size = new Size(127, 41);
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
            tabSkillsAndInterests.Location = new Point(4, 29);
            tabSkillsAndInterests.Margin = new Padding(3, 4, 3, 4);
            tabSkillsAndInterests.Name = "tabSkillsAndInterests";
            tabSkillsAndInterests.Padding = new Padding(3, 4, 3, 4);
            tabSkillsAndInterests.Size = new Size(672, 480);
            tabSkillsAndInterests.TabIndex = 1;
            tabSkillsAndInterests.Text = "Skills and Interests";
            tabSkillsAndInterests.UseVisualStyleBackColor = true;
            // 
            // richTextInterests
            // 
            richTextInterests.Location = new Point(267, 119);
            richTextInterests.Margin = new Padding(3, 4, 3, 4);
            richTextInterests.Name = "richTextInterests";
            richTextInterests.Size = new Size(379, 127);
            richTextInterests.TabIndex = 6;
            richTextInterests.Text = "";
            // 
            // labelInterests
            // 
            labelInterests.AutoSize = true;
            labelInterests.Location = new Point(267, 95);
            labelInterests.Name = "labelInterests";
            labelInterests.Size = new Size(64, 20);
            labelInterests.TabIndex = 5;
            labelInterests.Text = "Interests";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Location = new Point(26, 95);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(42, 20);
            labelSkills.TabIndex = 4;
            labelSkills.Text = "Skills";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Communication", "Teamwork", "Problem-solving", "Analytical skills", "Leadership", "Sales", "Management", "Data analysis", "Team leadership", "Organizational skills", "AI literacy", "Adaptability", "Process optimization", "Innovative thinking", "Conflict mitigation", "Data skills", "Coaching skills", "Strategic thinking", "Social media management", "E-commerce optimization", "Curiosity" });
            checkedListBox1.Location = new Point(26, 119);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(206, 312);
            checkedListBox1.TabIndex = 3;
            // 
            // labelSkillAndInterests
            // 
            labelSkillAndInterests.AutoSize = true;
            labelSkillAndInterests.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSkillAndInterests.Location = new Point(27, 32);
            labelSkillAndInterests.Name = "labelSkillAndInterests";
            labelSkillAndInterests.Size = new Size(283, 41);
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
            tabPersonalInfo.Location = new Point(4, 29);
            tabPersonalInfo.Margin = new Padding(3, 4, 3, 4);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3, 4, 3, 4);
            tabPersonalInfo.Size = new Size(672, 480);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Personal Information";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // linkChangePassword
            // 
            linkChangePassword.AutoSize = true;
            linkChangePassword.Location = new Point(435, 241);
            linkChangePassword.Name = "linkChangePassword";
            linkChangePassword.Size = new Size(124, 20);
            linkChangePassword.TabIndex = 13;
            linkChangePassword.TabStop = true;
            linkChangePassword.Text = "Change Password";
            linkChangePassword.LinkClicked += linkChangePassword_LinkClicked;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(145, 361);
            birthDatePicker.Margin = new Padding(3, 4, 3, 4);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(283, 27);
            birthDatePicker.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 165);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 27);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 427);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.MaxLength = 15;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(283, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "16/05/2025";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(145, 296);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(283, 27);
            txtPhoneNumber.TabIndex = 9;
            txtPhoneNumber.Text = "01100123456";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 231);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(283, 27);
            txtPassword.TabIndex = 8;
            txtPassword.Text = "12345678910";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(145, 100);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(283, 27);
            txtFullName.TabIndex = 7;
            txtFullName.Text = "Adham Hamdy Hamed Abdulhameid";
            // 
            // labelSignupDate
            // 
            labelSignupDate.AutoSize = true;
            labelSignupDate.Location = new Point(34, 437);
            labelSignupDate.Name = "labelSignupDate";
            labelSignupDate.Size = new Size(94, 20);
            labelSignupDate.TabIndex = 6;
            labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(34, 372);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(79, 20);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(34, 307);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(111, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(34, 241);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(34, 176);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(34, 111);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(79, 20);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(27, 32);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(315, 41);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Controls.Add(tabSkillsAndInterests);
            tabControlProfileInfo.Controls.Add(tabResume);
            tabControlProfileInfo.Location = new Point(197, 248);
            tabControlProfileInfo.Margin = new Padding(3, 4, 3, 4);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(680, 513);
            tabControlProfileInfo.TabIndex = 3;
            tabControlProfileInfo.Tag = "";
            // 
            // frmJobSeekerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 825);
            Controls.Add(button1);
            Controls.Add(btnCancel);
            Controls.Add(tabControlProfileInfo);
            Controls.Add(panelHeader);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
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