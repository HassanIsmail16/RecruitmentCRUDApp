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
            btnSaveChanges = new Button();
            tabCompany = new TabPage();
            labelSelectCompany = new Label();
            buttonCreateCompany = new Button();
            comboBoxCompany = new ComboBox();
            labelCompany = new Label();
            tabPersonalInfo = new TabPage();
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
            layout = new TableLayoutPanel();
            birthDatePicker = new DateTimePicker();
            panelHeader.SuspendLayout();
            tabCompany.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabControlProfileInfo.SuspendLayout();
            layout.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(611, 88);
            panelHeader.TabIndex = 24;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(18, 16);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(222, 40);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Adham Hamdy";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.DialogResult = DialogResult.Abort;
            btnSaveChanges.Dock = DockStyle.Right;
            btnSaveChanges.Location = new Point(502, 577);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(112, 38);
            btnSaveChanges.TabIndex = 9;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tabCompany
            // 
            tabCompany.Controls.Add(labelSelectCompany);
            tabCompany.Controls.Add(buttonCreateCompany);
            tabCompany.Controls.Add(comboBoxCompany);
            tabCompany.Controls.Add(labelCompany);
            tabCompany.Location = new Point(4, 24);
            tabCompany.Name = "tabCompany";
            tabCompany.Padding = new Padding(3);
            tabCompany.Size = new Size(603, 446);
            tabCompany.TabIndex = 1;
            tabCompany.Text = "Company";
            tabCompany.UseVisualStyleBackColor = true;
            // 
            // labelSelectCompany
            // 
            labelSelectCompany.AutoSize = true;
            labelSelectCompany.Location = new Point(28, 95);
            labelSelectCompany.Name = "labelSelectCompany";
            labelSelectCompany.Size = new Size(96, 15);
            labelSelectCompany.TabIndex = 4;
            labelSelectCompany.Text = "Select Company:";
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(203, 30);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(106, 32);
            buttonCreateCompany.TabIndex = 3;
            buttonCreateCompany.Text = "Create Company";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // comboBoxCompany
            // 
            comboBoxCompany.FormattingEnabled = true;
            comboBoxCompany.Location = new Point(130, 91);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(179, 23);
            comboBoxCompany.TabIndex = 4;
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
            tabPersonalInfo.Size = new Size(603, 446);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Personal Information";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 133);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "ez_peasy@hotdog.com";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 331);
            textBox4.MaxLength = 15;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(248, 23);
            textBox4.TabIndex = 8;
            textBox4.Text = "16/05/2025";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(127, 232);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 6;
            txtPhoneNumber.Text = "01100123456";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 184);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "12345678910";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(127, 86);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(248, 23);
            txtFullName.TabIndex = 3;
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
            labelBirthDate.Location = new Point(48, 287);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(62, 15);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(19, 235);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(50, 187);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(71, 136);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(46, 89);
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
            tabControlProfileInfo.Dock = DockStyle.Fill;
            tabControlProfileInfo.Location = new Point(3, 97);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(611, 474);
            tabControlProfileInfo.TabIndex = 1;
            tabControlProfileInfo.Tag = "";
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout.Controls.Add(tabControlProfileInfo, 0, 1);
            layout.Controls.Add(panelHeader, 0, 0);
            layout.Controls.Add(btnSaveChanges, 0, 2);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 91.60305F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 8.396947F));
            layout.Size = new Size(617, 618);
            layout.TabIndex = 27;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(127, 281);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(248, 23);
            birthDatePicker.TabIndex = 7;
            // 
            // EmployerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layout);
            Name = "EmployerControl";
            Size = new Size(617, 618);
            Load += EmployerControl_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tabCompany.ResumeLayout(false);
            tabCompany.PerformLayout();
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            tabControlProfileInfo.ResumeLayout(false);
            layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelUserName;
        private Button btnSaveChanges;
        private TabPage tabCompany;
        private Label labelCompany;
        private TabPage tabPersonalInfo;
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
        private TableLayoutPanel layout;
        private Label labelSelectCompany;
        private DateTimePicker birthDatePicker;
    }
}
