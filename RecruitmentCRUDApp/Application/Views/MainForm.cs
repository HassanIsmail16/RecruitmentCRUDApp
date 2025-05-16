using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Navigator.Initialize(centralPanel);
        }

        private void navJobsBtn_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new JobsControl());
        }
    }
}
