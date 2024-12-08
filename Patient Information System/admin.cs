using Mysqlx.Datatypes;
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
    public partial class frmadmin : Form
    {
        
        
        private string lastName;
        public frmadmin(string lastName)
        {
            InitializeComponent();
            this.lastName = lastName;
            lblname.Text = lastName;
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
        private void btnstaff_Click(object sender, EventArgs e)
        {
           
            staffUsercon1.Visible = true;
            doctorUser1.Visible = false;
         
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
           

            staffUsercon1.Visible = false;
           doctorUser1.Visible = true;

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        
    }
}
