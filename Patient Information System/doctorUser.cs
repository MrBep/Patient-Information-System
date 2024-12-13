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

namespace Patient_Information_System
{
    public partial class doctorUser : UserControl
    {
        public doctorUser()
        {
            InitializeComponent();


            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;

            dtgwlistdoctor.CellClick += dtgwlistdoctor_CellClick;

           
        }

        public class database
        {
            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        public class doctor
        {
            public int doctorID { get; set; }
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
            public TimeSpan availfrom { get; set; }
            public TimeSpan availto { get; set; }

        }

        public class doctorData
        {
            private database data = new database();

            public bool AddDoctor(doctor Doctor)
            {

                string availFromFormatted;
                string availToFormatted;


                if (Doctor.availfrom is TimeSpan)
                {
                    availFromFormatted = Doctor.availfrom.ToString(@"hh\:mm");
                }
                else
                {
                    availFromFormatted = Doctor.availfrom.ToString("HH:mm");
                }

                if (Doctor.availto is TimeSpan)
                {
                    availToFormatted = Doctor.availto.ToString(@"hh\:mm");
                }
                else
                {
                    availToFormatted = Doctor.availto.ToString("HH:mm");
                }

                string query = "INSERT INTO doctor (last_name, first_name, middle_name,  gender, birth_date, address, cellphone_number,username, password, role, available_from, available_to) " +
                               "VALUES (@lastname, @firstname, @middlename,  @gender, @birthdate, @address, @cellphonenumber, @username, @password, @role, @availfrom, @availto)";

                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", Doctor.lastname);
                    cmd.Parameters.AddWithValue("@firstname", Doctor.firstname);
                    cmd.Parameters.AddWithValue("@middlename", Doctor.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", Doctor.birthdate);
                    cmd.Parameters.AddWithValue("@gender", Doctor.gender);
                    cmd.Parameters.AddWithValue("@address", Doctor.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", Doctor.cellphonenumber);
                    cmd.Parameters.AddWithValue("@username", Doctor.username);
                    cmd.Parameters.AddWithValue("@password", Doctor.password);
                    cmd.Parameters.AddWithValue("@role", Doctor.role);
                    cmd.Parameters.AddWithValue("@availfrom", availFromFormatted);
                    cmd.Parameters.AddWithValue("@availto", availToFormatted);



                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            public List<doctor> getallDoctor()
            {
                List<doctor> doctorlist = new List<doctor>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor Doctor = new doctor
                            {
                                doctorID = reader.GetInt32("doctor_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                username = reader.GetString("username"),
                                cellphonenumber = reader.GetString("cellphone_number"),
                                role = reader.GetString("role"),
                                availfrom = reader.GetTimeSpan("available_from"),
                                availto = reader.GetTimeSpan("available_to")
                            };
                            doctorlist.Add(Doctor);

                        }
                    }
                }
                return doctorlist;
            }//end of getallDoctor

            public List<doctor> searchDoctor(string searchTerm)
            {
                List<doctor> doctorList = new List<doctor>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor WHERE first_name LIKE @search OR last_name LIKE @search";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor Doctor = new doctor
                            {
                                doctorID = reader.GetInt32("doctor_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                cellphonenumber = reader.GetString("cellphone_number"),
                                username = reader.GetString("username"),
                                password = reader.GetString("password"),
                                role = reader.GetString("role"),
                                availfrom = reader.GetTimeSpan("available_from"),
                                availto = reader.GetTimeSpan("available_to")
                            };
                            doctorList.Add(Doctor);
                        }
                    }
                }
                return doctorList;
            }//end of search doctor

            public bool Updatedoctor(doctor Doctor)
            {
                using (var conn = data.GetConnection())
                {
                    conn.Open();

                    string availFromFormatted;
                    string availToFormatted;

                    if (Doctor.availfrom is TimeSpan)
                    {
                        availFromFormatted = Doctor.availfrom.ToString(@"hh\:mm");
                    }
                    else
                    {
                        availFromFormatted = Doctor.availfrom.ToString("HH:mm");
                    }

                    if (Doctor.availto is TimeSpan)
                    {
                        availToFormatted = Doctor.availto.ToString(@"hh\:mm");
                    }
                    else
                    {
                        availToFormatted = Doctor.availto.ToString("HH:mm");
                    }

                    string query = "UPDATE doctor SET last_name = @lastname, first_name = @firstname, middle_name = @middlename, " +
                                   "birth_date = @birthdate, gender = @gender, address = @address, cellphone_number = @cellphonenumber, " +
                                   "username = COALESCE(@username, username), password = COALESCE(@password, password), role = @role,  available_from = @availfrom, available_to = @availto " +
                                   "WHERE doctor_id = @doctorID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", Doctor.lastname);
                    cmd.Parameters.AddWithValue("@firstname", Doctor.firstname);
                    cmd.Parameters.AddWithValue("@middlename", Doctor.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", Doctor.birthdate);
                    cmd.Parameters.AddWithValue("@gender", Doctor.gender);
                    cmd.Parameters.AddWithValue("@address", Doctor.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", Doctor.cellphonenumber);
                    cmd.Parameters.AddWithValue("@username", Doctor.username);
                    cmd.Parameters.AddWithValue("@password", Doctor.password);
                    cmd.Parameters.AddWithValue("@role", Doctor.role);
                    cmd.Parameters.AddWithValue("@availfrom", availFromFormatted);
                    cmd.Parameters.AddWithValue("@availto", availToFormatted);
                    cmd.Parameters.AddWithValue("@doctorID", Doctor.doctorID);

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
            }//end of updateDoctor

            public bool deleteDoctor(int doctorID)
            {
                using (var conn = data.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM doctor WHERE doctor_id = @doctorID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }


        doctorData doctorAccess = new doctorData();
        private HashSet<string> usernameSet = new HashSet<string>();// Pag-declare ng HashSet para mag-imbak ang mga unique usernames
        private int selectedDoctor = -1;
        private string selectedDoctorUsername;

        private void loaddoctorData()
        {
            // Kinukuha ang listahan ng mga doctor mula sa database
            List<doctor> doctorlist = doctorAccess.getallDoctor();

            usernameSet.Clear();  // Nililinis ang set ng usernames para maiwasan ang duplicates
            dtgwlistdoctor.DataSource = null;
            dtgwlistdoctor.Rows.Clear();

            // I-loop ang bawat doctor mula sa list at idagdag sa DataGridView
            foreach (var doctor in doctorlist)
            {
                usernameSet.Add(doctor.username);// add the username
                dtgwlistdoctor.Rows.Add(
                    doctor.doctorID,
                    doctor.lastname,
                    doctor.firstname,
                    doctor.middlename,
                    doctor.birthdate.ToString("yyyy-MM-dd"),
                    doctor.cellphonenumber,
                    doctor.role,
                    doctor.gender,
                    doctor.address,
                    doctor.username,
                    doctor.availfrom,
                    doctor.availto
                    );
            }
        }//end of loaddoctordata

        private string HashPassword(string password)
        {
            // Gumagamit ng SHA256 algorithm para i-hash ang password
            using (SHA256 sha256 = SHA256.Create())
            {
                // Kinukuha ang hash ng password sa pamamagitan ng encoding
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();// Binubuo ang string ng hash value
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();// Ibinabalik ang hashed password
            }
        }//end of hashpassword

        private void doctorUser_Load(object sender, EventArgs e)
        {
            loaddoctorData();
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
          string.IsNullOrWhiteSpace(txtrole.Text))
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
            txtlastname.Text.Any(char.IsDigit) ||
            txtmiddlename.Text.Any(char.IsDigit) ||
            txtrole.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, Middle name, Role and Specialization cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtcpnum.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Cellphone number must contain only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string middlename = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;

            string hashedPassword = HashPassword(txtpassword.Text);
            TimeSpan availableFrom = dtpAvialFrom.Value.TimeOfDay;
            TimeSpan availableTo = dtpAvailTo.Value.TimeOfDay;

            DialogResult result = MessageBox.Show(
            "Do you want to save this doctor's information?",
            "Confirm Save",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {
                doctor newDoctor = new doctor
                {
                    lastname = txtlastname.Text,
                    firstname = txtfirstname.Text,
                    middlename = middlename,
                    birthdate = dpbirthdate.Value,
                    gender = rbmale.Checked ? "Male" : "Female",
                    address = txtaddress.Text,
                    cellphonenumber = txtcpnum.Text,
                    username = txtusername.Text,
                    password = hashedPassword,
                    role = txtrole.Text,
                    availfrom = availableFrom,
                    availto = availableTo
                };

                bool success = doctorAccess.AddDoctor(newDoctor);

                if (success)
                {
                    usernameSet.Add(newDoctor.username);//add the username
                    MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearform();
                    loaddoctorData();
                }
                else
                {
                    MessageBox.Show("Failed to add doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Doctor Information was not saved..", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchInfo = txtsearch.Text.Trim();
            List<doctor> doctorList = doctorAccess.searchDoctor(searchInfo);

            if (doctorList.Count == 0)
            {
                MessageBox.Show("Doctor Information not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgwlistdoctor.DataSource = null;
                dtgwlistdoctor.Rows.Clear();
            }
            else
            {
                dtgwlistdoctor.DataSource = null;
                dtgwlistdoctor.Rows.Clear();

                foreach (var doctor in doctorList)
                {
                    dtgwlistdoctor.Rows.Add(
                        doctor.doctorID,
                        doctor.lastname,
                        doctor.firstname,
                        doctor.middlename,
                        doctor.birthdate.ToString("yyyy-MM-dd"),
                        doctor.cellphonenumber,
                        doctor.role,
                        doctor.gender,
                        doctor.address,
                        doctor.username,
                        doctor.availfrom,
                        doctor.availto
                        );
                }
            }
        }

        private void dtgwlistdoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgwlistdoctor.Rows[e.RowIndex];

                selectedDoctor = Convert.ToInt32(row.Cells[0]?.Value);
                selectedDoctorUsername = row.Cells[9]?.Value?.ToString();

                txtlastname.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtfirstname.Text = row.Cells[2]?.Value?.ToString() ?? "";
                txtmiddlename.Text = row.Cells[3]?.Value?.ToString() ?? "";

                if (row.Cells[4]?.Value != null)
                {
                    dpbirthdate.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                txtcpnum.Text = row.Cells[5]?.Value?.ToString() ?? "";
                txtrole.Text = row.Cells[6]?.Value?.ToString() ?? "";

                if (row.Cells[7]?.Value?.ToString() == "Male")
                    rbmale.Checked = true;
                else
                    rbfemale.Checked = true;

                txtaddress.Text = row.Cells[8]?.Value?.ToString() ?? "";
                txtusername.Text = row.Cells[9]?.Value.ToString() ?? "";

                if (row.Cells[10]?.Value != null)
                {
                    if (row.Cells[10].Value is TimeSpan)
                    {

                        TimeSpan time = (TimeSpan)row.Cells[10].Value;
                        dtpAvialFrom.Value = DateTime.Today.Add(time);
                    }
                    else
                    {

                        dtpAvialFrom.Value = Convert.ToDateTime(row.Cells[10].Value);
                    }
                }

                if (row.Cells[11]?.Value != null)
                {
                    if (row.Cells[11].Value is TimeSpan)
                    {

                        TimeSpan time = (TimeSpan)row.Cells[11].Value;
                        dtpAvailTo.Value = DateTime.Today.Add(time);
                    }
                    else
                    {

                        dtpAvailTo.Value = Convert.ToDateTime(row.Cells[11].Value);
                    }
                }

                btnedit.Enabled = true;
                btnedit.BackColor = Color.White;
                btnsave.Enabled = false;
                btnsave.BackColor = SystemColors.ButtonFace;
            }
        }//end cellclick

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != null && txtusername.Text != selectedDoctorUsername && usernameSet.Contains(txtusername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//Conformation to kapag ang na type na username is existing na

            if (string.IsNullOrWhiteSpace(txtlastname.Text) ||
                string.IsNullOrWhiteSpace(txtfirstname.Text) ||
                dpbirthdate.Value == null ||
                string.IsNullOrWhiteSpace(txtaddress.Text) ||
                string.IsNullOrWhiteSpace(txtcpnum.Text) ||
                string.IsNullOrWhiteSpace(txtrole.Text))
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
                txtlastname.Text.Any(char.IsDigit) ||
                txtmiddlename.Text.Any(char.IsDigit) ||
                txtrole.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, Middle name, Role and Specialization cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtcpnum.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Cellphone number must contain only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string middlename = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;

            string hashedPassword = string.IsNullOrEmpty(txtpassword.Text) ? null : HashPassword(txtpassword.Text);


            if (selectedDoctor != -1)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to edit this information?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    string currentUsername = txtusername.Text;
                    string currentPassword = txtpassword.Text;
                    TimeSpan availableFrom = dtpAvialFrom.Value.TimeOfDay;
                    TimeSpan availableTo = dtpAvailTo.Value.TimeOfDay;

                    doctor updateDoctor = new doctor
                    {
                        doctorID = selectedDoctor,
                        lastname = txtlastname.Text,
                        firstname = txtfirstname.Text,
                        middlename = txtmiddlename.Text,
                        birthdate = dpbirthdate.Value,
                        gender = rbmale.Checked ? "Male" : "Female",
                        address = txtaddress.Text,
                        cellphonenumber = txtcpnum.Text,
                        username = string.IsNullOrEmpty(currentUsername) ? null : currentUsername,
                        password = hashedPassword,
                        role = txtrole.Text,
                        availfrom = availableFrom,
                        availto = availableTo
                    };

                    bool success = doctorAccess.Updatedoctor(updateDoctor);

                    if (success)
                    {
                        usernameSet.Remove(selectedDoctorUsername); // Remove old username
                        usernameSet.Add(updateDoctor.username); // Add new username
                        MessageBox.Show("Doctor information updated successfully.");
                        loaddoctorData();
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update doctor information.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor information to edit.");
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
            dtpAvialFrom.Value = DateTime.Now;
            dtpAvailTo.Value = DateTime.Now;

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
            txtcpnum.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            rbmale.Checked = false;
            rbmale.Checked = false;
            dpbirthdate.Value = DateTime.Now;
            dtpAvialFrom.Value = DateTime.Now;
            dtpAvailTo.Value = DateTime.Now;


            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;
            btnsave.BackColor = Color.White;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dtgwlistdoctor.Rows.Count > 1)
            {
                if (dtgwlistdoctor.CurrentRow == null || dtgwlistdoctor.CurrentRow.Index == dtgwlistdoctor.Rows.Count - 1)
                {
                    MessageBox.Show("Please select a doctor information to delete.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int doctorID = Convert.ToInt32(dtgwlistdoctor.CurrentRow.Cells[0].Value);

                        bool isDeleted = doctorAccess.deleteDoctor(doctorID);

                        if (isDeleted)
                        {
                            usernameSet.Remove(dtgwlistdoctor.CurrentRow.Cells[9].Value.ToString());//Remove username
                            MessageBox.Show("Doctor information deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddoctorData();
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
