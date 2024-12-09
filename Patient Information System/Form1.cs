using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace Patient_Information_System
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private string lastName;
        private int doctorId;
        public class database
        {
            private string connectionString = "server=localhost;database=hospital_management;username=root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text.Trim();
            string password = tbpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = HashPassword(password);
            string role = "";
            string lastName = "";

            using (MySqlConnection conn = new database().GetConnection())
            {
                try
                {
                    conn.Open();


                    string staffQuery = "SELECT role, last_name FROM staff WHERE username = @username AND password = @password";
                    MySqlCommand cmdStaff = new MySqlCommand(staffQuery, conn);
                    cmdStaff.Parameters.AddWithValue("@username", username);
                    cmdStaff.Parameters.AddWithValue("@password", hashedPassword);

                    using (MySqlDataReader reader = cmdStaff.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["role"].ToString();
                            lastName = reader["last_name"].ToString();
                        }
                    }


                    if (string.IsNullOrEmpty(role))
                    {
                        string doctorQuery = "SELECT doctor_id, 'doctor' AS role, last_name FROM doctor WHERE username = @username AND password = @password";
                        MySqlCommand cmdDoctor = new MySqlCommand(doctorQuery, conn);
                        cmdDoctor.Parameters.AddWithValue("@username", username);
                        cmdDoctor.Parameters.AddWithValue("@password", hashedPassword);

                        using (MySqlDataReader reader = cmdDoctor.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                role = reader["role"].ToString();
                                lastName = reader["last_name"].ToString();
                                doctorId = reader.GetInt32("doctor_id");  
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            switch (role.ToLower())
            {
                case "admin":
                    frmadmin n = new frmadmin(lastName);
                    n.Show();
                    this.Hide();
                    break;
               case "receptionist":
                    frmreceptionist p = new frmreceptionist(lastName);
                    p.Show();
                    this.Hide();
                    break;
                case "doctor":
                    frmdoctor d = new frmdoctor (doctorId, lastName);
                    d.Show();
                    this.Hide();
                    break;
                case "billing":
                    frmbilling fb = new frmbilling(lastName);
                     fb.Show();
                     this.Hide();
                     break;
                default:
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                tbpassword.PasswordChar = '\0'; 
            }
            else
            {
                tbpassword.PasswordChar = '*'; 
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
