namespace RecruitmentApplication.Views
{
    partial class JobsControl
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
            this.vacanciesPanel = new FlowLayoutPanel();
            this.refreshBtn = new Button();
            this.SuspendLayout();
            // 
            // vacanciesPanel
            // 
            this.vacanciesPanel.Location = new Point(22, 20);
            this.vacanciesPanel.Name = "vacanciesPanel";
            this.vacanciesPanel.Size = new Size(648, 260);
            this.vacanciesPanel.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new Point(55, 298);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new Size(75, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += this.refreshBtn_Click;
            // 
            // JobsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.vacanciesPanel);
            this.Name = "JobsControl";
            this.Size = new Size(688, 501);
            this.ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel vacanciesPanel;
        private Button refreshBtn;
    }
}
