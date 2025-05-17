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
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            comboBoxQuestions.Items.Add("What was the most interesting job “title” that had maximum number of applicants?");
            comboBoxQuestions.Items.Add("What was the announced job “title” that hadn’t any applicants last month?");
            comboBoxQuestions.Items.Add("Who was the employer with the maximum announcements last month?");
            comboBoxQuestions.Items.Add("Who were the employers didn’t announce any job last month?");
            comboBoxQuestions.Items.Add("What were the available positions at each employer last month?");
            comboBoxQuestions.Items.Add("For each seeker, retrieve all his/her information and the number of jobs he applied for");
            comboBoxQuestions.SelectedIndex = 0;
            comboBoxQuestions.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
