namespace RecruitmentApplication.Views
{
    partial class SavedJobsControl
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
            this.lblHeader = new Label();
            this.dataGridSavedJobs = new DataGridView();
            this.btnSave = new Button();
            this.btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize) this.dataGridSavedJobs).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(206, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(133, 32);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "SavedJobs";
            // 
            // dataGridSavedJobs
            // 
            this.dataGridSavedJobs.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridSavedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSavedJobs.Location = new Point(23, 76);
            this.dataGridSavedJobs.Name = "dataGridSavedJobs";
            this.dataGridSavedJobs.Size = new Size(524, 325);
            this.dataGridSavedJobs.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(472, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new Point(23, 408);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // SavedJobsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridSavedJobs);
            this.Controls.Add(this.lblHeader);
            this.Name = "SavedJobsControl";
            this.Size = new Size(574, 451);
            ((System.ComponentModel.ISupportInitialize) this.dataGridSavedJobs).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label lblHeader;
        private DataGridView dataGridSavedJobs;
        private Button btnSave;
        private Button btnRefresh;
    }
}
