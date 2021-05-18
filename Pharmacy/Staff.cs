﻿using Pharmacy.StaffSubtab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Staff : Form
    {
        public Staff(string s)
        {
            InitializeComponent();
            NameStaffLabel.Text=s;
            ButtonDashBoard.PerformClick();
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void ButtonDashBoard_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Dashboard";
            staffDashBoard1.BringToFront();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Report";
            staffReport1.BringToFront();
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Profile";
            staffProfile1.BringToFront();
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            Sell f = new Sell();
            f.Show();
        }

        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
