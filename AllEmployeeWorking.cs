﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    public partial class AllEmployeeWorking : Form
    {
        Dashboard dashboardForm = new Dashboard();

        String query;
        function fn = new function();
        public AllEmployeeWorking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fn.close();
        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 131);
            query = "SELECT * FROM newEmployee WHERE working = 'Yes'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fn.back(this, dashboardForm);
        }
    }
}
