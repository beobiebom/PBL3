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
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();

        }

        

        private void buttonDetail_Click_1(object sender, EventArgs e)
        {
            Detail f = new Detail();
            f.Show();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            
            AddUser f = new AddUser();
            
            f.Show();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateUser f = new UpdateUser();
            
            f.Show();
        }
    }
}
