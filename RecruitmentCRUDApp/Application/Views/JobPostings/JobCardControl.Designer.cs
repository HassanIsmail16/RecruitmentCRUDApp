namespace RecruitmentApplication.Views
{
    partial class JobCardControl
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
            this.lblCompany = new Label();
            this.lblTitle = new Label();
            this.lblLocation = new Label();
            this.pictureBoxLogo = new PictureBox();
            this.btnApply = new Button();
            this.btnDetails = new Button();
            ((System.ComponentModel.ISupportInitialize) this.pictureBoxLogo).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new Point(21, 25);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new Size(38, 15);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(68, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(38, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label2";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new Point(138, 25);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new Size(38, 15);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "label3";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new Point(219, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Size(100, 50);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new Point(344, 21);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new Point(438, 21);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new Size(75, 23);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // JobCardControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompany);
            this.Name = "JobCardControl";
            this.Size = new Size(732, 70);
            ((System.ComponentModel.ISupportInitialize) this.pictureBoxLogo).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblCompany;
        private Label lblTitle;
        private Label lblLocation;
        private PictureBox pictureBoxLogo;
        private Button btnApply;
        private Button btnDetails;
    }
}
