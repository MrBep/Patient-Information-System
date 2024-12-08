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
    public partial class frmreceptionist : Form
    {
        private string lastName;
        public frmreceptionist(string lastName)
        {
            InitializeComponent();
            this.lastName = lastName;
            lblname.Text = lastName;
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            patientUser1.Visible = true;
            assignedToDoctor1.Visible = false;

            patientUser patientForm = patientUser1 as patientUser;

            if (patientForm != null)
            {
                patientForm.RefreshData();
            }
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            patientUser1.Visible = false;
            assignedToDoctor1.Visible = true;

            assignedToDoctor assignForm = assignedToDoctor1 as assignedToDoctor;

            if (assignForm != null)
            {
                assignForm.RefreshData();
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
