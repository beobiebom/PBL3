using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.StaffSubtab
{
    public partial class StaffProfile : UserControl
    {
        public int userId { get; set; }
        public StaffProfile()
        {
         
                InitializeComponent();
           /* using (PharmacyModel phar = new PharmacyModel())
            {
                USER profile = phar.USERs.FirstOrDefault(u => u.ID == userId);
                if (profile != null)
                {
                    txtName.Text = profile.NAME;
                    txtphone.Text = profile.PHONE;
                    txtpass.Text = profile.PASSWORD;
                    txtemail.Text = profile.ADDRESS;
                }
            }*/
        }
        public void refresh()
        {
            using (PharmacyModel phar = new PharmacyModel())
            {
                USER profile = phar.USERs.FirstOrDefault(u => u.ID == userId);
                if (profile != null)
                {
                    txtName.Text = profile.NAME;
                    txtphone.Text = profile.PHONE;
                    txtpass.Text = profile.PASSWORD;
                    txtemail.Text = profile.ADDRESS;
                }
            }

        }
       

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (PharmacyModel phar = new PharmacyModel())
            {
                USER profile = phar.USERs.FirstOrDefault(u => u.ID == userId);
                if (profile != null)
                {
                    profile.NAME = txtName.Text;
                    profile.PHONE = txtphone.Text;
                    profile.PASSWORD = txtpass.Text;
                    profile.ADDRESS = txtemail.Text; 
                    phar.SaveChanges();
                }
            }
        }
    }
}
