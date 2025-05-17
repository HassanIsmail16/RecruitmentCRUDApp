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
            lblHeader = new Label();
            dataGridSavedJobs = new DataGridView();
            btnSave = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSavedJobs).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(206, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(133, 32);
            lblHeader.TabIndex = 24;
            lblHeader.Text = "SavedJobs";
            // 
            // dataGridSavedJobs
            // 
            dataGridSavedJobs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridSavedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSavedJobs.Location = new Point(23, -30);
            dataGridSavedJobs.Name = "dataGridSavedJobs";
            dataGridSavedJobs.Size = new Size(524, 325);
            dataGridSavedJobs.TabIndex = 25;
            dataGridSavedJobs.CellContentClick += dataGridSavedJobs_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(472, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(23, 408);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // SavedJobsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Controls.Add(dataGridSavedJobs);
            Controls.Add(lblHeader);
            Name = "SavedJobsControl";
            Size = new Size(574, 451);
            ((System.ComponentModel.ISupportInitialize)dataGridSavedJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeader;
        private DataGridView dataGridSavedJobs;
        private Button btnSave;
        private Button btnRefresh;
    }
}
