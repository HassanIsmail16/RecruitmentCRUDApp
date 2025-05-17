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
    public partial class JobDetailsForm : Form
    {
        private int jobId;
        public JobDetailsForm(int jobId)
        {
            InitializeComponent();
            this.jobId = jobId;
        }
    }
}
