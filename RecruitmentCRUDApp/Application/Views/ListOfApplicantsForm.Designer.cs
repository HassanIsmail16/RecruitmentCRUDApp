namespace RecruitmentApplication.Views
{
    partial class ListOfApplicantsForm
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
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(331, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new Point(349, 12);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListOfApplicantsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(541, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "ListOfApplicantsForm";
            this.Text = "ListOfApplicantsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
    }
}