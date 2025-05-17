namespace RecruitmentApplication.Views
{
    partial class frmLogin
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
            labelLogin = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            linkSignup = new LinkLabel();
            labelEmail = new Label();
            btnLogin = new Button();
            labelPassword = new Label();
            labelSignupMsg = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(40, 15);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(566, 32);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Welcome back! Log in to continue your career path.";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(220, 98);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(256, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(220, 177);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(256, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // linkSignup
            // 
            linkSignup.Anchor = AnchorStyles.Bottom;
            linkSignup.AutoSize = true;
            linkSignup.Location = new Point(375, 268);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(47, 15);
            linkSignup.TabIndex = 4;
            linkSignup.TabStop = true;
            linkSignup.Text = "Sign up";
            linkSignup.LinkClicked += linkSignup_LinkClicked;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(220, 81);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(306, 219);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(220, 160);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // labelSignupMsg
            // 
            labelSignupMsg.Anchor = AnchorStyles.Bottom;
            labelSignupMsg.AutoSize = true;
            labelSignupMsg.Location = new Point(238, 268);
            labelSignupMsg.Name = "labelSignupMsg";
            labelSignupMsg.Size = new Size(131, 15);
            labelSignupMsg.TabIndex = 8;
            labelSignupMsg.Text = "Don't have an account?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelSignupMsg);
            Controls.Add(labelPassword);
            Controls.Add(btnLogin);
            Controls.Add(labelEmail);
            Controls.Add(linkSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(labelLogin);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(527, 310);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private LinkLabel linkSignup;
        private Label labelEmail;
        private Button btnLogin;
        private Label labelPassword;
        private Label labelSignupMsg;
    }
}