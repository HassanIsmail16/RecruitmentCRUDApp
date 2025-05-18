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
            this.tabControlProfileInfo = new TabControl();
            this.tabPersonalInfo = new TabPage();
            this.textBoxDescryption = new TextBox();
            this.label1 = new Label();
            this.txtEmail = new TextBox();
            this.txtPhoneNumber = new TextBox();
            this.txtName = new TextBox();
            this.labelPhone = new Label();
            this.labelEmail = new Label();
            this.labelFullName = new Label();
            this.labelPersonalInfo = new Label();
            this.panelHeader = new Panel();
            this.labelUserName = new Label();
            this.btnSaveChanges = new Button();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tabControlProfileInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProfileInfo
            // 
            this.tabControlProfileInfo.Controls.Add(this.tabPersonalInfo);
            this.tabControlProfileInfo.Dock = DockStyle.Fill;
            this.tabControlProfileInfo.Location = new Point(3, 86);
            this.tabControlProfileInfo.Name = "tabControlProfileInfo";
            this.tabControlProfileInfo.SelectedIndex = 0;
            this.tabControlProfileInfo.Size = new Size(602, 479);
            this.tabControlProfileInfo.TabIndex = 28;
            this.tabControlProfileInfo.Tag = "";
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.AutoScroll = true;
            this.tabPersonalInfo.Controls.Add(this.textBoxDescryption);
            this.tabPersonalInfo.Controls.Add(this.label1);
            this.tabPersonalInfo.Controls.Add(this.txtEmail);
            this.tabPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.tabPersonalInfo.Controls.Add(this.txtName);
            this.tabPersonalInfo.Controls.Add(this.labelPhone);
            this.tabPersonalInfo.Controls.Add(this.labelEmail);
            this.tabPersonalInfo.Controls.Add(this.labelFullName);
            this.tabPersonalInfo.Controls.Add(this.labelPersonalInfo);
            this.tabPersonalInfo.Location = new Point(4, 24);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new Padding(3);
            this.tabPersonalInfo.Size = new Size(594, 451);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Company Information";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxDescryption
            // 
            this.textBoxDescryption.Location = new Point(145, 217);
            this.textBoxDescryption.MaxLength = 20;
            this.textBoxDescryption.Name = "textBoxDescryption";
            this.textBoxDescryption.Size = new Size(248, 23);
            this.textBoxDescryption.TabIndex = 13;
            this.textBoxDescryption.Text = "Best juice company in 2021,2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(42, 220);
            this.label1.Name = "label1";
            this.label1.Size = new Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(145, 124);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(248, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new Point(145, 171);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new Size(248, 23);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.Text = "01100123456";
            this.txtPhoneNumber.TextChanged += this.txtPhoneNumber_TextChanged;
            // 
            // txtName
            // 
            this.txtName.Location = new Point(145, 75);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(248, 23);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Adham Hamdy Hamed Abdulhameid";
            this.txtName.TextChanged += this.txtFullName_TextChanged;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(42, 174);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(91, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(42, 127);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(42, 78);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(97, 15);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Company Name:";
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPersonalInfo.Location = new Point(33, 33);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new Size(257, 32);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.GhostWhite;
            this.panelHeader.BorderStyle = BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.labelUserName);
            this.panelHeader.Dock = DockStyle.Fill;
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(602, 77);
            this.panelHeader.TabIndex = 27;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelUserName.Location = new Point(210, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new Size(137, 45);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Bekhiro";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.DialogResult = DialogResult.Abort;
            this.btnSaveChanges.Dock = DockStyle.Right;
            this.btnSaveChanges.Location = new Point(493, 571);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new Size(112, 43);
            this.btnSaveChanges.TabIndex = 29;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += this.btnSaveChanges_Click;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControlProfileInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6126757F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.38732F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new Size(608, 617);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // CompanyControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CompanyControl";
            this.Size = new Size(608, 617);
            this.Load += this.CompanyControl_Load;
            this.tabControlProfileInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private Button btnSaveChanges;
        private TextBox textBoxDescryption;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
