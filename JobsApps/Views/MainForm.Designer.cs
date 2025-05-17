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
            navPanel = new Panel();
            toolStrip1 = new ToolStrip();
            navJobsBtn = new ToolStripButton();
            navSavedJobsBtn = new ToolStripButton();
            navProfileBtn = new ToolStripButton();
            navLogoutBtn = new ToolStripButton();
            centralPanel = new Panel();
            navPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            navPanel.BackgroundImageLayout = ImageLayout.Center;
            navPanel.Controls.Add(toolStrip1);
            navPanel.Location = new Point(0, 0);
            navPanel.Margin = new Padding(3, 4, 3, 4);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(203, 600);
            navPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { navJobsBtn, navSavedJobsBtn, navProfileBtn, navLogoutBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(171, 600);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // navJobsBtn
            // 
            navJobsBtn.AutoSize = false;
            navJobsBtn.Image = (Image)resources.GetObject("navJobsBtn.Image");
            navJobsBtn.ImageTransparentColor = Color.Magenta;
            navJobsBtn.Name = "navJobsBtn";
            navJobsBtn.Overflow = ToolStripItemOverflow.Never;
            navJobsBtn.Padding = new Padding(10);
            navJobsBtn.Size = new Size(170, 45);
            navJobsBtn.Text = "Jobs";
            navJobsBtn.Click += navJobsBtn_Click;
            // 
            // navSavedJobsBtn
            // 
            navSavedJobsBtn.AutoSize = false;
            navSavedJobsBtn.Image = (Image)resources.GetObject("navSavedJobsBtn.Image");
            navSavedJobsBtn.ImageTransparentColor = Color.Magenta;
            navSavedJobsBtn.Name = "navSavedJobsBtn";
            navSavedJobsBtn.Overflow = ToolStripItemOverflow.Never;
            navSavedJobsBtn.Padding = new Padding(10);
            navSavedJobsBtn.Size = new Size(170, 45);
            navSavedJobsBtn.Text = "Saved Jobs";
            navSavedJobsBtn.Click += navSavedJobsBtn_Click;
            // 
            // navProfileBtn
            // 
            navProfileBtn.AutoSize = false;
            navProfileBtn.Image = (Image)resources.GetObject("navProfileBtn.Image");
            navProfileBtn.ImageTransparentColor = Color.Magenta;
            navProfileBtn.Name = "navProfileBtn";
            navProfileBtn.Overflow = ToolStripItemOverflow.Never;
            navProfileBtn.Padding = new Padding(10);
            navProfileBtn.Size = new Size(170, 45);
            navProfileBtn.Text = "Profile";
            navProfileBtn.Click += navProfileBtn_Click;
            // 
            // navLogoutBtn
            // 
            navLogoutBtn.AutoSize = false;
            navLogoutBtn.Image = (Image)resources.GetObject("navLogoutBtn.Image");
            navLogoutBtn.ImageTransparentColor = Color.Magenta;
            navLogoutBtn.Name = "navLogoutBtn";
            navLogoutBtn.Overflow = ToolStripItemOverflow.Never;
            navLogoutBtn.Padding = new Padding(10);
            navLogoutBtn.Size = new Size(170, 45);
            navLogoutBtn.Text = "Log Out";
            navLogoutBtn.Click += navLogoutBtn_Click;
            // 
            // centralPanel
            // 
            centralPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            centralPanel.Location = new Point(199, 0);
            centralPanel.Margin = new Padding(3, 4, 3, 4);
            centralPanel.Name = "centralPanel";
            centralPanel.Size = new Size(715, 600);
            centralPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(centralPanel);
            Controls.Add(navPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton navJobsBtn;
        private ToolStripButton navLogoutBtn;
        private ToolStripButton navProfileBtn;
        private Panel centralPanel;
        private ToolStripButton navSavedJobsBtn;
    }
}