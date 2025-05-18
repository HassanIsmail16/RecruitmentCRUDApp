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
            labelUserName = new Label();
            tabControlProfileInfo = new TabControl();
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
            tabSkillsAndInterests = new TabPage();
            textBoxInterests = new TextBox();
            textBoxSkills = new TextBox();
            labelInterests = new Label();
            labelSkills = new Label();
            labelSkillAndInterests = new Label();
            tabResume = new TabPage();
            lblCurrentResumeFileName = new Label();
            lblCurrentResume = new Label();
            btnRemove = new Button();
            btnUpload = new Button();
            labelResume = new Label();
            btnSaveChangesSkills = new Button();
            panelHeader = new Panel();
            layout = new TableLayoutPanel();
            panel1 = new Panel();
            tabControlProfileInfo.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabSkillsAndInterests.SuspendLayout();
            tabResume.SuspendLayout();
            panelHeader.SuspendLayout();
            layout.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(119, 22);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(322, 37);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Adham Hamdy's Profile";
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Controls.Add(tabSkillsAndInterests);
            tabControlProfileInfo.Controls.Add(tabResume);
            tabControlProfileInfo.Dock = DockStyle.Fill;
            tabControlProfileInfo.Location = new Point(3, 93);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(596, 469);
            tabControlProfileInfo.TabIndex = 3;
            tabControlProfileInfo.Tag = "";
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
            tabPersonalInfo.Size = new Size(588, 441);
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
            labelSignupDate.Location = new Point(34, 325);
            labelSignupDate.Name = "labelSignupDate";
            labelSignupDate.Size = new Size(74, 15);
            labelSignupDate.TabIndex = 6;
            labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(33, 274);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(62, 15);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(33, 224);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(33, 177);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(34, 128);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(33, 77);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(27, 27);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(257, 32);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // tabSkillsAndInterests
            // 
            tabSkillsAndInterests.AutoScroll = true;
            tabSkillsAndInterests.Controls.Add(textBoxInterests);
            tabSkillsAndInterests.Controls.Add(textBoxSkills);
            tabSkillsAndInterests.Controls.Add(labelInterests);
            tabSkillsAndInterests.Controls.Add(labelSkills);
            tabSkillsAndInterests.Controls.Add(labelSkillAndInterests);
            tabSkillsAndInterests.Location = new Point(4, 24);
            tabSkillsAndInterests.Name = "tabSkillsAndInterests";
            tabSkillsAndInterests.Padding = new Padding(3);
            tabSkillsAndInterests.Size = new Size(588, 441);
            tabSkillsAndInterests.TabIndex = 1;
            tabSkillsAndInterests.Text = "Skills and Interests";
            tabSkillsAndInterests.UseVisualStyleBackColor = true;
            // 
            // textBoxInterests
            // 
            textBoxInterests.Location = new Point(102, 207);
            textBoxInterests.Multiline = true;
            textBoxInterests.Name = "textBoxInterests";
            textBoxInterests.Size = new Size(444, 124);
            textBoxInterests.TabIndex = 7;
            textBoxInterests.TextChanged += textBox2_TextChanged;
            // 
            // textBoxSkills
            // 
            textBoxSkills.Location = new Point(102, 65);
            textBoxSkills.Multiline = true;
            textBoxSkills.Name = "textBoxSkills";
            textBoxSkills.PlaceholderText = "e.g., Java, SQL, Project Management\n\n";
            textBoxSkills.Size = new Size(444, 122);
            textBoxSkills.TabIndex = 6;
            textBoxSkills.TextChanged += textBox1_TextChanged;
            // 
            // labelInterests
            // 
            labelInterests.AutoSize = true;
            labelInterests.Location = new Point(40, 210);
            labelInterests.Name = "labelInterests";
            labelInterests.Size = new Size(51, 15);
            labelInterests.TabIndex = 5;
            labelInterests.Text = "Interests";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Location = new Point(40, 65);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(33, 15);
            labelSkills.TabIndex = 4;
            labelSkills.Text = "Skills";
            // 
            // labelSkillAndInterests
            // 
            labelSkillAndInterests.AutoSize = true;
            labelSkillAndInterests.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSkillAndInterests.Location = new Point(27, 27);
            labelSkillAndInterests.Name = "labelSkillAndInterests";
            labelSkillAndInterests.Size = new Size(228, 32);
            labelSkillAndInterests.TabIndex = 1;
            labelSkillAndInterests.Text = "Skills and Interests";
            // 
            // tabResume
            // 
            tabResume.AutoScroll = true;
            tabResume.Controls.Add(lblCurrentResumeFileName);
            tabResume.Controls.Add(lblCurrentResume);
            tabResume.Controls.Add(btnRemove);
            tabResume.Controls.Add(btnUpload);
            tabResume.Controls.Add(labelResume);
            tabResume.Location = new Point(4, 24);
            tabResume.Name = "tabResume";
            tabResume.Padding = new Padding(3);
            tabResume.Size = new Size(588, 441);
            tabResume.TabIndex = 2;
            tabResume.Text = "Resume";
            tabResume.UseVisualStyleBackColor = true;
            // 
            // lblCurrentResumeFileName
            // 
            lblCurrentResumeFileName.AutoSize = true;
            lblCurrentResumeFileName.ForeColor = SystemColors.WindowFrame;
            lblCurrentResumeFileName.Location = new Point(140, 73);
            lblCurrentResumeFileName.Name = "lblCurrentResumeFileName";
            lblCurrentResumeFileName.Size = new Size(74, 15);
            lblCurrentResumeFileName.TabIndex = 5;
            lblCurrentResumeFileName.Text = "filename.pdf";
            // 
            // lblCurrentResume
            // 
            lblCurrentResume.AutoSize = true;
            lblCurrentResume.Location = new Point(40, 73);
            lblCurrentResume.Name = "lblCurrentResume";
            lblCurrentResume.Size = new Size(95, 15);
            lblCurrentResume.TabIndex = 5;
            lblCurrentResume.Text = "Current Resume:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(37, 145);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(534, 36);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(37, 98);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(534, 36);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // labelResume
            // 
            labelResume.AutoSize = true;
            labelResume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResume.Location = new Point(27, 27);
            labelResume.Name = "labelResume";
            labelResume.Size = new Size(103, 32);
            labelResume.TabIndex = 2;
            labelResume.Text = "Resume";
            // 
            // btnSaveChangesSkills
            // 
            btnSaveChangesSkills.DialogResult = DialogResult.Abort;
            btnSaveChangesSkills.Location = new Point(481, 3);
            btnSaveChangesSkills.Name = "btnSaveChangesSkills";
            btnSaveChangesSkills.Size = new Size(112, 34);
            btnSaveChangesSkills.TabIndex = 23;
            btnSaveChangesSkills.Text = "Save Changes";
            btnSaveChangesSkills.UseVisualStyleBackColor = true;
            btnSaveChangesSkills.Click += btnSaveChanges_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(596, 84);
            panelHeader.TabIndex = 20;
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(tabControlProfileInfo, 0, 1);
            layout.Controls.Add(panelHeader, 0, 0);
            layout.Controls.Add(panel1, 0, 2);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            layout.Size = new Size(602, 610);
            layout.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSaveChangesSkills);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 568);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 39);
            panel1.TabIndex = 22;
            // 
            // JobSeekerProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layout);
            Name = "JobSeekerProfileControl";
            Size = new Size(602, 610);
            Load += JobSeekerProfileControl_Load;
            tabControlProfileInfo.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            tabSkillsAndInterests.ResumeLayout(false);
            tabSkillsAndInterests.PerformLayout();
            tabResume.ResumeLayout(false);
            tabResume.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            layout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelUserName;
        private TabControl tabControlProfileInfo;
        private TabPage tabPersonalInfo;
        private DateTimePicker birthDatePicker;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private Label labelBirthDate;
        private Label labelPhone;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelPersonalInfo;
        private TabPage tabSkillsAndInterests;
        private Label labelInterests;
        private Label labelSkills;
        private Label labelSkillAndInterests;
        private TabPage tabResume;
        private Button btnRemove;
        private Button btnUpload;
        private Label labelResume;
        private Panel panelHeader;
        private Button btnSaveChangesSkills;
        private TextBox textBox4;
        private Label labelSignupDate;
        private TextBox textBoxInterests;
        private TextBox textBoxSkills;
        private TableLayoutPanel layout;
        private Panel panel1;
        private Label lblCurrentResume;
        private Label lblCurrentResumeFileName;
    }
}
