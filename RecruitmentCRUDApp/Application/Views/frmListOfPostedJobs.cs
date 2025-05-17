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
    public partial class frmListOfPostedJobs : Form
    {
        public frmListOfPostedJobs()
        {
            InitializeComponent();
            InitializeControlButtons();
        }

        private void InitializeControlButtons()
        {
            if (dataGridPostedJobs.Columns.Contains("colControl"))
            {
                dataGridPostedJobs.Columns.Remove("colControl");
            }

            var editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "colEdit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostedJobs.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "colDelete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostedJobs.Columns.Add(deleteButtonColumn);
        }
    }
}
