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

namespace Pharmacy.AdminTab
{
    public partial class editProfilecs : UserControl
    {
       
        
        public editProfilecs()
        {

            InitializeComponent();
            buttonProfile.PerformClick();
            using(PharmacyModel phar = new PharmacyModel()){
                PHARMACY_PROFILE profile = phar.PHARMARCY_PROFILEs.FirstOrDefault();
                txtpharmname.Text = profile.PharmacyName;
                txtaddress.Text = profile.Address;
                txtphone.Text = profile.PhoneNumber;
                txtbusiness.Text = profile.BusinessHours;
                txtemail.Text = profile.Email; 
            }
          
        }
       

        

        private void btnreset_Click(object sender, EventArgs e)
        {

            txtaddress.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtbusiness.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (PharmacyModel phar = new PharmacyModel())
            {
                PHARMACY_PROFILE profile = phar.PHARMARCY_PROFILEs.FirstOrDefault();
                profile.PharmacyName = txtpharmname.Text;
                profile.Address = txtaddress.Text;
                profile.PhoneNumber = txtphone.Text;
                profile.BusinessHours = txtbusiness.Text;
                profile.Email = txtemail.Text;
                phar.SaveChanges();

            }

        }

        private void txtpharmname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
