using DAL;
using Pharmacy.StaffSubtab;
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
        string s = "";
        public Staff(string s)
        {
            InitializeComponent();
            this.s = s;
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
            using(PharmacyModel phar = new PharmacyModel())
            {
                USER user = phar.USERs.FirstOrDefault(u => u.USER_NAME == s);
                int id = user.ID;
                staffProfile1.userId = id;
                staffProfile1.refresh();
            }
            
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
