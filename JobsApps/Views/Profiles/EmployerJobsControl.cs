using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views.Profiles
{
    public partial class EmployerJobsControl : UserControl
    {
        public event Action OnRequestRefresh;
        public EmployerJobsControl()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            var editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(deleteButtonColumn);

            // TODO: make columns read only
        }

        public void RenderVacancies()
        {
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            OnRequestRefresh?.Invoke();
        }

    }
}
