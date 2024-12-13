using MySql.Data.MySqlClient;
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
    public partial class patientUser : UserControl
    {
        public patientUser()
        {
            InitializeComponent();

            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;

            dtgwlistpatient.CellClick += dtgwlistpatient_CellClick;
        }

        public class database
        {

            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        public class patient
        {
            public int patientID { get; set; }
            public string lastname { get; set; }
            public string firstname { get; set; }
            public string middlename { get; set; }
            public DateTime birthdate { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string cellphonenumber { get; set; }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            loadPatientData();
        }
        public class patientData
        {
            private database data = new database();

            // Cache para mapag imbakan ng data ng patient upang mapabili ang proseso
            private Dictionary<string, List<patient>> searchCache = new Dictionary<string, List<patient>>();
            private Dictionary<int, patient> patientCache = new Dictionary<int, patient>();

            public void addPatient(patient Patient)
            {
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO patient (last_name, first_name, middle_name, birth_date, gender, address, cellphone_number) " +
                           "VALUES (@lastname, @firstname, @middlename, @birthdate, @gender, @address, @cellphonenumber)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", Patient.lastname);
                    cmd.Parameters.AddWithValue("@firstname", Patient.firstname);
                    cmd.Parameters.AddWithValue("@middlename", Patient.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", Patient.birthdate);
                    cmd.Parameters.AddWithValue("@gender", Patient.gender);
                    cmd.Parameters.AddWithValue("@address", Patient.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", Patient.cellphonenumber);

                    cmd.ExecuteNonQuery();
                }
            }//end of addPatient

            public List<patient> getllallPatient()// paraan upang kunin ang mga list ng patient mula sa databse
            {
                List<patient> patientList = new List<patient>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM patient";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            patient Patient = new patient
                            {
                                patientID = reader.GetInt32("patient_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                cellphonenumber = reader.GetString("cellphone_number")
                            };
                            patientList.Add(Patient); // Idagdag ang patient sa listathan.
                            patientCache[Patient.patientID] = Patient;// I-cache ang patient ayon sa ID.
                        }
                    }
                }
                return patientList;
            }//end of getallPatient

            public patient getPatientbyID(int patientID)//paraan upang kunin ang isang patient ayon sa kanilang ID.
            {
                if (patientCache.ContainsKey(patientID))// I-checheck kung ang patient ay nasa cache.
                {
                    return patientCache[patientID];// tas ibabalik ang patient mula sa cache.
                }
                return null;// Ibabalik ang null kung hindi nahanap ang patient sa cache.
            }//end of getPatientbyID

            public List<patient> searchPatient(string searchTerm)//paraan upang maghanap ng mga patient gamit ang kanilang unang pangalan o apelyido.
            {
                if (searchCache.ContainsKey(searchTerm))// I-checheck kung ang search term ay nasa cache 
                {
                    return searchCache[searchTerm];// Ibabalik ng search ang nakuhang resulta galing sa cached.
                }

                List<patient> patientList = new List<patient>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM patient WHERE first_name LIKE @search OR last_name LIKE @search";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient Patient = new patient
                            {
                                patientID = reader.GetInt32("patient_id"),
                                lastname = reader.GetString("last_name"),
                                firstname = reader.GetString("first_name"),
                                middlename = reader.GetString("middle_name"),
                                birthdate = reader.GetDateTime("birth_date"),
                                gender = reader.GetString("gender"),
                                address = reader.GetString("address"),
                                cellphonenumber = reader.GetString("cellphone_number"),
                            };
                            patientList.Add(Patient);
                        }
                    }
                }


                searchCache[searchTerm] = patientList;// Icacahe ang mga resulta ng search para sa susunod na paggamit.

                return patientList;
            }

            public bool Updatepatient(patient Patient)
            {
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE patient SET last_name = @lastname, first_name = @firstname, middle_name = @middlename, " +
                                   "birth_date = @birthdate, gender = @gender, address = @address, cellphone_number = @cellphonenumber " +
                                   "WHERE patient_id = @patientID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastname", Patient.lastname);
                    cmd.Parameters.AddWithValue("@firstname", Patient.firstname);
                    cmd.Parameters.AddWithValue("@middlename", Patient.middlename);
                    cmd.Parameters.AddWithValue("@birthdate", Patient.birthdate);
                    cmd.Parameters.AddWithValue("@gender", Patient.gender);
                    cmd.Parameters.AddWithValue("@address", Patient.address);
                    cmd.Parameters.AddWithValue("@cellphonenumber", Patient.cellphonenumber);
                    cmd.Parameters.AddWithValue("@patientID", Patient.patientID);
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
            }//end of updatePatient

            public bool deletePatient(int patientID)
            {
                using (var conn = data.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM patient WHERE patient_id = @patientID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@patientID", patientID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (MySqlException ex) when (ex.Number == 1451) 
                    {
                        MessageBox.Show("Cannot delete this patient as they are assigned to other records. Please remove those assignments first.", "Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }//end of patient data

        private int currentPage = 1;//Kasalukuyang pahina sa listahan ng mga patient.
        private int itemsPerPage = 10;//Bilang ng mga patient na ipapakita sa bawat pahina.
        private List<patient> allPatient = new List<patient>();//Listahan ng lahat ng patient na galing sa database.
        patientData patientAccess = new patientData();
        private int selectedPatient = -1;


        private void loadPatientData()
        {
            List<patient> allPatient = patientAccess.getllallPatient();//ang pagkuha ng lahat ng pasyente mula sa database

            //Pag-compute ng kabuuang bilang ng mga pahina base sa bilang ng mga patient sa database
            int totalPages = (int)Math.Ceiling(allPatient.Count / (double)itemsPerPage);

            //Paghahati sa listahan ng mga patient batay sa kasalukuyang pahina at ang bilang ng dapat na nakalagay sa bawat pahina
            List<patient> pagedPatient = allPatient.Skip((currentPage - 1) * itemsPerPage).Take(itemsPerPage).ToList();

            dtgwlistpatient.DataSource = null;
            dtgwlistpatient.Rows.Clear();

            foreach (var patient in pagedPatient)
            {
                dtgwlistpatient.Rows.Add(
                    patient.patientID,
                    patient.lastname,
                    patient.firstname,
                    patient.middlename,
                    patient.birthdate.ToString("yyyy-MM-dd"),
                     patient.cellphonenumber,
                    patient.gender,
                    patient.address

                    );
            }
            
        }//end of loadPatientData

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if ((currentPage * itemsPerPage) < allPatient.Count)
            {
                currentPage++;
                loadPatientData();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if ((currentPage * itemsPerPage) < allPatient.Count)
            {
                currentPage++;
                loadPatientData();
            }
        }

        private void patientUser_Load(object sender, EventArgs e)
        {
            loadPatientData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlastname.Text) ||
            string.IsNullOrWhiteSpace(txtfirstname.Text) ||
            dpbirthdate.Value == null ||
            string.IsNullOrWhiteSpace(txtaddress.Text) ||
            string.IsNullOrWhiteSpace(txtcpnum.Text))

            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
            txtlastname.Text.Any(char.IsDigit) ||
            txtmiddlename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, Middle name, Role and Specialization cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            string middlename = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;



            DialogResult result = MessageBox.Show(
             "Do you want to save this information?",
             "Confirm Save",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (result == DialogResult.Yes)
            {
                patient newPatient = new patient
                {
                    lastname = txtlastname.Text,
                    firstname = txtfirstname.Text,
                    middlename = txtmiddlename.Text,
                    birthdate = dpbirthdate.Value,
                    gender = rbmale.Checked ? "Male" : "Female",
                    address = txtaddress.Text,
                    cellphonenumber = txtcpnum.Text
                };

                patientAccess.addPatient(newPatient);
                MessageBox.Show("Patient information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPatientData();
                clearform();
            }
            else
            {
                MessageBox.Show("Patient Information was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchInfo = txtsearch.Text.Trim();

            List<patient> patientList = patientAccess.searchPatient(searchInfo);//ang paghanap ng patient batay sa input na nakalagay.

            if (patientList.Count == 0)
            {
                MessageBox.Show("Patient Information not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgwlistpatient.DataSource = null;
                dtgwlistpatient.Rows.Clear();
            }
            else
            {
                dtgwlistpatient.DataSource = null;
                dtgwlistpatient.Rows.Clear();

                //I-didisplay ang mga nahanap na information ng patient.
                foreach (var patient in patientList)
                {
                    dtgwlistpatient.Rows.Add(
                        patient.patientID,
                        patient.lastname,
                        patient.firstname,
                        patient.middlename,
                        patient.birthdate.ToString("yyyy-MM-dd"),
                        patient.cellphonenumber,
                        patient.gender,
                        patient.address

                        );
                }
            }
        }

        private void dtgwlistpatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgwlistpatient.Rows[e.RowIndex];

                selectedPatient = Convert.ToInt32(row.Cells[0]?.Value);

                txtlastname.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtfirstname.Text = row.Cells[2]?.Value?.ToString() ?? "";
                txtmiddlename.Text = row.Cells[3]?.Value?.ToString() ?? "";

                if (row.Cells[4]?.Value != null)
                {
                    dpbirthdate.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                txtcpnum.Text = row.Cells[5]?.Value?.ToString() ?? "";


                if (row.Cells[6]?.Value?.ToString() == "Male")
                    rbmale.Checked = true;
                else
                    rbfemale.Checked = true;

                txtaddress.Text = row.Cells[7]?.Value?.ToString() ?? "";



                btnedit.Enabled = true;
                btnedit.BackColor = Color.White;
                btnsave.Enabled = false;
                btnsave.BackColor = SystemColors.ButtonFace;


            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlastname.Text) ||
                 string.IsNullOrWhiteSpace(txtfirstname.Text) ||
                 dpbirthdate.Value == null ||
                 string.IsNullOrWhiteSpace(txtaddress.Text) ||
                 string.IsNullOrWhiteSpace(txtcpnum.Text)
                 )
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtfirstname.Text.Any(char.IsDigit) ||
                txtlastname.Text.Any(char.IsDigit) ||
                txtmiddlename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name, Last name, Middle name, Role and Specialization cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string middlename = string.IsNullOrWhiteSpace(txtmiddlename.Text) ? "N/A" : txtmiddlename.Text;


            if (selectedPatient != -1)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to edit this information?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {


                    patient updatePatient = new patient
                    {
                        patientID = selectedPatient,
                        lastname = txtlastname.Text,
                        firstname = txtfirstname.Text,
                        middlename = txtmiddlename.Text,
                        birthdate = dpbirthdate.Value,
                        gender = rbmale.Checked ? "Male" : "Female",
                        cellphonenumber = txtcpnum.Text,
                        address = txtaddress.Text

                    };

                    bool success = patientAccess.Updatepatient(updatePatient);

                    if (success)
                    {
                        MessageBox.Show("Patient information updated successfully.");
                        loadPatientData();
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient information.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient information to edit.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dtgwlistpatient.Rows.Count > 1)
            {
                if (dtgwlistpatient.CurrentRow == null || dtgwlistpatient.CurrentRow.Index == dtgwlistpatient.Rows.Count - 1)
                {
                    MessageBox.Show("Please select a Patient information to delete.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        int patientID = Convert.ToInt32(dtgwlistpatient.CurrentRow.Cells[0].Value);

                        bool isDeleted = patientAccess.deletePatient(patientID);

                        if (isDeleted)
                        {
                            MessageBox.Show("Patient information deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadPatientData();
                            clearform();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete patient information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data in the table right now.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            txtaddress.Text = "";
            txtcpnum.Text = "";
            rbmale.Checked = false;
            rbmale.Checked = false;
            dpbirthdate.Value = DateTime.Now;


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
            rbmale.Checked = false;
            rbmale.Checked = false;
            dpbirthdate.Value = DateTime.Now;


            btnedit.Enabled = false;
            btnedit.BackColor = SystemColors.ButtonFace;
            btnsave.Enabled = true;
            btnsave.BackColor = Color.White;
        }
    }
}
