using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Patient_Information_System.doctorUser;

namespace Patient_Information_System
{
    public partial class staffUsercon : UserControl
    {
        
        public staffUsercon()
        {
            InitializeComponent();

            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;

            dtgwlist.CellClick += dtgwlist_CellClick;

           
        }

        public class Database
        {
            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        

        public class Staff
        {
            public int staffID { get; set; }
            public string lastname { get; set; }
            public string firstname { get; set; }
            public string middlename { get; set; }
            public DateTime birthdate { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string cellphonenumber { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
        }

        public class Staffdata
        {
            private Database data = new Database();

            public void AddStaff(Staff staff)
            {
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO staff (last_name, first_name, middle_name, birth_date, gender, address, cellphone_number, username, password, role) " +
                           "VALUES (@lastname, @firstname, @middlename, @birthdate, @gender, @address, @cellphonenumber, @username, @password, @role)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", staff.lastname);
                    cmd.Parameters.AddWithValue("@firstname", staff.firstname);
                    cmd.Parameters.AddWithValue("@middlename", staff.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", staff.birthdate);
                    cmd.Parameters.AddWithValue("@gender", staff.gender);
                    cmd.Parameters.AddWithValue("@address", staff.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", staff.cellphonenumber);
                    cmd.Parameters.AddWithValue("@username", staff.username);
                    cmd.Parameters.AddWithValue("@password", staff.password);
                    cmd.Parameters.AddWithValue("@role", staff.role);
                    cmd.ExecuteNonQuery();

                }
            }

            public List<Staff> Getallstaff()//kinukuha lahat ng information ng staff sa database
            {
                List<Staff> stafflist = new List<Staff>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM staff";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staff staff = new Staff
                            {
                                staffID = reader.GetInt32("staff_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                username = reader.GetString("username"),
                                cellphonenumber = reader.GetString("cellphone_number"),
                                role = reader.GetString("role")
                            };
                            stafflist.Add(staff);

                        }
                    }
                }
                return stafflist;
            }



            public List<Staff> searchStaff(string searchTerm)
            {
                List<Staff> staffList = new List<Staff>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM staff WHERE first_name LIKE @search OR last_name LIKE @search";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staff staff = new Staff
                            {
                                staffID = reader.GetInt32("staff_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                cellphonenumber = reader.GetString("cellphone_number"),
                                username = reader.GetString("username"),
                                password = reader.GetString("password"),
                                role = reader.GetString("role")
                            };
                            staffList.Add(staff);
                        }
                    }
                }
                return staffList;
            }

            public bool updateStaff(Staff staff)
            {
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE staff SET last_name = @lastname, first_name = @firstname, middle_name = @middlename, " +
                                   "birth_date = @birthdate, gender = @gender, address = @address, cellphone_number = @cellphonenumber, " +
                                   "username = COALESCE(@username, username), password = COALESCE(@password, password), role = @role " +
                                   "WHERE staff_id = @staffID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", staff.lastname);
                    cmd.Parameters.AddWithValue("@firstname", staff.firstname);
                    cmd.Parameters.AddWithValue("@middlename", staff.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", staff.birthdate);
                    cmd.Parameters.AddWithValue("@gender", staff.gender);
                    cmd.Parameters.AddWithValue("@address", staff.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", staff.cellphonenumber);
                    cmd.Parameters.AddWithValue("@username", staff.username);
                    cmd.Parameters.AddWithValue("@password", staff.password); 
                    cmd.Parameters.AddWithValue("@role", staff.role);
                    cmd.Parameters.AddWithValue("@staffID", staff.staffID);

                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }



            public bool deleteStaff(int staffID)
            {
                using (var conn = data.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM staff WHERE staff_id = @staffID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@staffID", staffID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }



        }



        Staffdata staffaccess = new Staffdata();
        private HashSet<string> usernameSet = new HashSet<string>();// Pag-declare ng HashSet para mag-imbak ang mga unique usernames
        private int selectedStaff = -1;
        private string selectedStaffUsername;

        private void loadstaffdata()
        {
            // Kinukuha ang listahan ng mga staff mula sa database
            List<Staff> staffList = staffaccess.Getallstaff();

            usernameSet.Clear();// Nililinis ang set ng usernames para maiwasan ang duplicates
            dtgwlist.DataSource = null;
            dtgwlist.Rows.Clear();

            foreach (var staff in staffList)// I-loop ang bawat staff mula sa list at idagdag sa DataGridView
            {
                usernameSet.Add(staff.username);// add the username
                dtgwlist.Rows.Add(
                    staff.staffID,
                    staff.lastname,
                    staff.firstname,
                    staff.middlename,
                    staff.birthdate.ToString("yyyy-MM-dd"),
                    staff.cellphonenumber,
                    staff.role,
                    staff.gender,
                    staff.address,
                    staff.username
                );
            }


        }

        private string HashPassword(string password)
        {
            // Gumagamit ng SHA256 algorithm para i-hash ang password
            using (SHA256 sha256 = SHA256.Create())
            {
                // Kinukuha ang hash ng password sa pamamagitan ng encoding
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Binubuo ang string ng hash value
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));// Ibinabalik ang hashed password
                }
                return builder.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (usernameSet.Contains(txtusername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//Conformation to kapag ang na type na username is existing na

            if (string.IsNullOrWhiteSpace(txtlastname.Text) ||
          string.IsNullOrWhiteSpace(txtfirstname.Text) ||
          dpbirthdate.Value == null ||
          string.IsNullOrWhiteSpace(txtaddress.Text) ||
          string.IsNullOrWhiteSpace(txtcpnum.Text) ||
          string.IsNullOrWhiteSpace(txtusername.Text) ||
          string.IsNullOrWhiteSpace(txtpassword.Text) ||
          cbrole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
            txtlastname.Text.Any(char.IsDigit) ||
            txtmiddlename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, and Middle name cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtcpnum.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Cellphone number must contain only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtcpnum.Text.Length != 11)
            {
                MessageBox.Show("Cellphone number must contain exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtcpnum.Text.Length > 11)
            {
                MessageBox.Show("Cellphone number is too long. It must contain exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string middleName = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;

            string hashedPassword = HashPassword(txtpassword.Text);

            DialogResult result = MessageBox.Show(
            "Do you want to save this staff information?",
            "Confirm Save",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {
                Staff newSTAFF = new Staff
                {
                    lastname = txtlastname.Text,
                    firstname = txtfirstname.Text,
                    middlename = middleName,
                    birthdate = dpbirthdate.Value,
                    gender = rbmale.Checked ? "Male" : "Female",
                    address = txtaddress.Text,
                    cellphonenumber = txtcpnum.Text,
                    username = txtusername.Text,
                    password = hashedPassword,
                    role = cbrole.SelectedItem.ToString()
                };

                staffaccess.AddStaff(newSTAFF);
                usernameSet.Add(newSTAFF.username);//add the username
                MessageBox.Show("Staff information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadstaffdata();
                clearform();
            }
            else
            {
                MessageBox.Show("Staff information was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchInfo = txtsearch.Text.Trim();
            List<Staff> staffList = staffaccess.searchStaff(searchInfo);

            if (staffList.Count == 0)
            {
                MessageBox.Show("Staff Information not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgwlist.DataSource = null;
                dtgwlist.Rows.Clear();
            }
            else
            {

                dtgwlist.DataSource = null;
                dtgwlist.Rows.Clear();

                foreach (var staff in staffList)
                {
                    dtgwlist.Rows.Add(
                        staff.staffID,
                        staff.lastname,
                        staff.firstname,
                        staff.middlename,
                        staff.birthdate.ToString("yyyy-MM-dd"),
                        staff.cellphonenumber,
                        staff.role,
                        staff.gender,
                        staff.address,
                        staff.username
                    );
                }
            }
        }

        private void dtgwlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtgwlist.Rows[e.RowIndex];

                selectedStaff = Convert.ToInt32(row.Cells[0]?.Value);
                selectedStaffUsername = row.Cells[9]?.Value?.ToString();

                txtlastname.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtfirstname.Text = row.Cells[2]?.Value?.ToString() ?? "";
                txtmiddlename.Text = row.Cells[3]?.Value?.ToString() ?? "";

                if (row.Cells[4]?.Value != null)
                {
                    dpbirthdate.Value = Convert.ToDateTime(row.Cells[4].Value);
                }

                cbrole.SelectedItem = row.Cells[6]?.Value?.ToString() ?? "";
                txtcpnum.Text = row.Cells[5]?.Value?.ToString() ?? "";

                if (row.Cells[7]?.Value?.ToString() == "Male")
                    rbmale.Checked = true;
                else
                    rbfemale.Checked = true;

                txtaddress.Text = row.Cells[8]?.Value?.ToString() ?? "";
                txtusername.Text = row.Cells[9]?.Value.ToString() ?? "";


                btnedit.Enabled = true;
                btnedit.BackColor = Color.White;
                btnsave.Enabled = false;
                btnsave.BackColor = SystemColors.ButtonFace;

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != null && txtusername.Text != selectedStaffUsername && usernameSet.Contains(txtusername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//Conformation to kapag ang na type na username is existing na

            if (string.IsNullOrWhiteSpace(txtlastname.Text) ||
                string.IsNullOrWhiteSpace(txtfirstname.Text) ||
                dpbirthdate.Value == null ||
                string.IsNullOrWhiteSpace(txtaddress.Text) ||
                string.IsNullOrWhiteSpace(txtcpnum.Text) ||
                cbrole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
                txtlastname.Text.Any(char.IsDigit) ||
                txtmiddlename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, and Middle name cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtcpnum.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Cellphone number must contain only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtcpnum.Text.Length != 11)
            {
                MessageBox.Show("Cellphone number must contain exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string middleName = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;
            string hashedPassword = string.IsNullOrEmpty(txtpassword.Text) ? null : HashPassword(txtpassword.Text); 

            if (selectedStaff != -1)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to edit this information?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    string currentUsername = txtusername.Text;

                    Staff UpdatedStaff = new Staff
                    {
                        staffID = selectedStaff,
                        lastname = txtlastname.Text,
                        firstname = txtfirstname.Text,
                        middlename = middleName,
                        birthdate = dpbirthdate.Value,
                        gender = rbmale.Checked ? "Male" : "Female",
                        address = txtaddress.Text,
                        cellphonenumber = txtcpnum.Text,
                        username = string.IsNullOrEmpty(currentUsername) ? null : currentUsername,
                        password = hashedPassword, 
                        role = cbrole.SelectedItem.ToString()
                    };

                    bool success = staffaccess.updateStaff(UpdatedStaff);

                    if (success)
                    {
                        usernameSet.Remove(selectedStaffUsername); // Remove old username
                        usernameSet.Add(UpdatedStaff.username); // Add new username
                        MessageBox.Show("Staff information updated successfully.");
                        loadstaffdata();
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update staff information.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff information to edit.");
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            txtaddress.Text = "";
            txtcpnum.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            rbmale.Checked = false;
            rbmale.Checked = false;
            dpbirthdate.Value = DateTime.Now;
            cbrole.SelectedIndex = -1;

            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;
            btnsave.BackColor = Color.White;
        }

        private void clearform()
        {
            txtlastname.Text = string.Empty;
            txtfirstname.Text = string.Empty;
            txtmiddlename.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtcpnum.Text = string.Empty; ;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            rbmale.Checked = false;
            rbmale.Checked = false;
            dpbirthdate.Value = DateTime.Now;
            cbrole.SelectedIndex = -1;

            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;
            btnsave.BackColor = Color.White;
        }

        private void staffUsercon_Load(object sender, EventArgs e)
        {
            loadstaffdata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dtgwlist.Rows.Count > 1)
            {
                if (dtgwlist.CurrentRow == null || dtgwlist.CurrentRow.Index == dtgwlist.Rows.Count - 1)
                {
                    MessageBox.Show("Please select a staff information to delete.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        int staffID = Convert.ToInt32(dtgwlist.CurrentRow.Cells[0].Value);

                        bool isDeleted = staffaccess.deleteStaff(staffID);

                        if (isDeleted)
                        {
                            usernameSet.Remove(dtgwlist.CurrentRow.Cells[9].Value.ToString());//Remove username
                            MessageBox.Show("Staff information deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadstaffdata();
                            clearform();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete staff information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data in the table right now.");
            }

           
        }
    }
}
