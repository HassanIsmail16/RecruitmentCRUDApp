using Models;
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
    public partial class JobCardControl : UserControl
    {
        private Vacancy vacancy;

        public event Action OnApplyClicked;
        public event Action OnDetailsClicked;

        public JobCardControl(Vacancy vacancy)
        {
            InitializeComponent();
            this.vacancy = vacancy;
            lblCompany.Text = "whatever co"; // TODO: replace with actual data
            lblTitle.Text = vacancy.Title;
            lblLocation.Text = "wherever"; // TODO: replace with actual data
            //pictureBoxLogo.Image = TODO: add logo here
        }
    }
}
