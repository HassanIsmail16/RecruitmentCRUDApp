using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication
{
    internal static class Navigator
    {
        private static Panel centralPanel;

        public static void Initialize(Panel mainPanel)
        {
            centralPanel = mainPanel;
        }

        public static void Navigate(UserControl view)
        {
            if (centralPanel == null || view == null) 
                return;

            centralPanel.SuspendLayout();

            centralPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(view);

            centralPanel.ResumeLayout();
            centralPanel.PerformLayout();
        }
    }
}
