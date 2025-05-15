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
            labelLogin.Location = new Point(46, 20);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(703, 41);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Welcome back! Log in to continue your career path.";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(251, 131);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(292, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(251, 236);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(292, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // linkSignup
            // 
            linkSignup.Anchor = AnchorStyles.Bottom;
            linkSignup.AutoSize = true;
            linkSignup.Location = new Point(441, 357);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(59, 20);
            linkSignup.TabIndex = 4;
            linkSignup.TabStop = true;
            linkSignup.Text = "Sign up";
            linkSignup.LinkClicked += linkSignup_LinkClicked;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(252, 108);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(350, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(252, 213);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // labelSignupMsg
            // 
            labelSignupMsg.Anchor = AnchorStyles.Bottom;
            labelSignupMsg.AutoSize = true;
            labelSignupMsg.Location = new Point(272, 357);
            labelSignupMsg.Name = "labelSignupMsg";
            labelSignupMsg.Size = new Size(163, 20);
            labelSignupMsg.TabIndex = 8;
            labelSignupMsg.Text = "Don't have an account?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSignupMsg);
            Controls.Add(labelPassword);
            Controls.Add(btnLogin);
            Controls.Add(labelEmail);
            Controls.Add(linkSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(labelLogin);
            MinimumSize = new Size(600, 400);
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