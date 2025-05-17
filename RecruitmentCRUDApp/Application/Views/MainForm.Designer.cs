namespace RecruitmentApplication.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navPanel = new Panel();
            this.toolStrip1 = new ToolStrip();
            this.navJobsBtn = new ToolStripButton();
            this.navSavedJobsBtn = new ToolStripButton();
            this.navProfileBtn = new ToolStripButton();
            this.navLogoutBtn = new ToolStripButton();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.centralPanel = new Panel();
            this.navPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.navPanel.BackgroundImageLayout = ImageLayout.Center;
            this.navPanel.Controls.Add(this.toolStrip1);
            this.navPanel.Location = new Point(3, 3);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new Size(163, 539);
            this.navPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = DockStyle.Left;
            this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new ToolStripItem[] { this.navJobsBtn, this.navSavedJobsBtn, this.navProfileBtn, this.navLogoutBtn });
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new Size(171, 539);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // navJobsBtn
            // 
            this.navJobsBtn.AutoSize = false;
            this.navJobsBtn.Image = (Image) resources.GetObject("navJobsBtn.Image");
            this.navJobsBtn.ImageTransparentColor = Color.Magenta;
            this.navJobsBtn.Name = "navJobsBtn";
            this.navJobsBtn.Overflow = ToolStripItemOverflow.Never;
            this.navJobsBtn.Padding = new Padding(10);
            this.navJobsBtn.Size = new Size(170, 45);
            this.navJobsBtn.Text = "Jobs";
            this.navJobsBtn.Click += this.navJobsBtn_Click;
            // 
            // navSavedJobsBtn
            // 
            this.navSavedJobsBtn.AutoSize = false;
            this.navSavedJobsBtn.Image = (Image) resources.GetObject("navSavedJobsBtn.Image");
            this.navSavedJobsBtn.ImageTransparentColor = Color.Magenta;
            this.navSavedJobsBtn.Name = "navSavedJobsBtn";
            this.navSavedJobsBtn.Overflow = ToolStripItemOverflow.Never;
            this.navSavedJobsBtn.Padding = new Padding(10);
            this.navSavedJobsBtn.Size = new Size(170, 45);
            this.navSavedJobsBtn.Text = "Saved Jobs";
            this.navSavedJobsBtn.Click += this.navSavedJobsBtn_Click;
            // 
            // navProfileBtn
            // 
            this.navProfileBtn.AutoSize = false;
            this.navProfileBtn.Image = (Image) resources.GetObject("navProfileBtn.Image");
            this.navProfileBtn.ImageTransparentColor = Color.Magenta;
            this.navProfileBtn.Name = "navProfileBtn";
            this.navProfileBtn.Overflow = ToolStripItemOverflow.Never;
            this.navProfileBtn.Padding = new Padding(10);
            this.navProfileBtn.Size = new Size(170, 45);
            this.navProfileBtn.Text = "Profile";
            this.navProfileBtn.Click += this.navProfileBtn_Click;
            // 
            // navLogoutBtn
            // 
            this.navLogoutBtn.AutoSize = false;
            this.navLogoutBtn.Image = (Image) resources.GetObject("navLogoutBtn.Image");
            this.navLogoutBtn.ImageTransparentColor = Color.Magenta;
            this.navLogoutBtn.Name = "navLogoutBtn";
            this.navLogoutBtn.Overflow = ToolStripItemOverflow.Never;
            this.navLogoutBtn.Padding = new Padding(10);
            this.navLogoutBtn.Size = new Size(170, 45);
            this.navLogoutBtn.Text = "Log Out";
            this.navLogoutBtn.Click += this.navLogoutBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.navPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.centralPanel, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(800, 545);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // centralPanel
            // 
            this.centralPanel.Dock = DockStyle.Fill;
            this.centralPanel.Location = new Point(172, 3);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new Size(625, 539);
            this.centralPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton navJobsBtn;
        private ToolStripButton navLogoutBtn;
        private ToolStripButton navProfileBtn;
        private ToolStripButton navSavedJobsBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel centralPanel;
    }
}