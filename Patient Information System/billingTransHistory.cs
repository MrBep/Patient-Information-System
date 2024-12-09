using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Information_System
{
    public partial class frmbillingTransHistory : Form
    {
        private string lastName;
        public frmbillingTransHistory(string lastName)
        {
            InitializeComponent();
            this.lastName = lastName;
            lblname.Text = lastName;
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult logout;

            logout = MessageBox.Show("Are you want to logout", "Logout", MessageBoxButtons.YesNo);

            if (logout == DialogResult.Yes)
            {
                frmlogin m = new frmlogin();
                this.Hide();
                m.Show();
            }
        }

        private void btnmedhistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            frmbilling bl = new frmbilling(lastName);
            bl.Show();
            this.Hide();
        }
    }
}
