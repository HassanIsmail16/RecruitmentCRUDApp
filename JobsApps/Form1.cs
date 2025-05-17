using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=LAPTOP-7RP4DTQ6;Initial Catalog=jobs;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connStr);
        }
    }
}
            
