﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeramecNetFlixProject.UI
{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamgDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.teamgDataSet.Member);

            this.reportViewer1.RefreshReport();
        }
    }
}
