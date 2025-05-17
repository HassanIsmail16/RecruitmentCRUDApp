using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class EditJobForm : Form
    {
        private int jobId;
        public EditJobForm(int jobId)
        {
            InitializeComponent();
            this.jobId = jobId;
        }
    }
}
