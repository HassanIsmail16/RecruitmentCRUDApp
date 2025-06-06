﻿using Models;
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
    public partial class JobsControl : UserControl
    {
        public event Action OnRequestRefresh;
        public JobsControl()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            var applyButtonColumn = new DataGridViewButtonColumn();
            applyButtonColumn.Name = "Apply";
            applyButtonColumn.HeaderText = "Apply";
            applyButtonColumn.Text = "Apply";
            applyButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(applyButtonColumn);

            var detailsButtonColumn = new DataGridViewButtonColumn();
            detailsButtonColumn.Name = "Details";
            detailsButtonColumn.HeaderText = "Details";
            detailsButtonColumn.Text = "Details";
            detailsButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(detailsButtonColumn);

            // TODO: make columns read only
        }

        public void RenderVacancies(List<Vacancy> vacancies)
        {
            dataGridPostings.DataSource = vacancies;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            OnRequestRefresh?.Invoke();
        }
    }
}
