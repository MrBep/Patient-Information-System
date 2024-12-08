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
using static Patient_Information_System.doctorUser;
using static Patient_Information_System.patientUser;
using static Patient_Information_System.staffUsercon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Patient_Information_System
{
    public partial class frmdoctor : Form
    {
        private string lastName;
        private int doctorId;
        public frmdoctor(int doctorId, string lastName)
        {
            InitializeComponent();
            this.doctorId = doctorId; 
            this.lastName = lastName;
            lblname.Text = lastName;

            LoadAssignedPatients();
            dgvAssignedPatients.Refresh();
        }
        public class database
        {
            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        public class AssignedPatient
        {
            public int PatientID { get; set; }
            public string FirstName { get; set; } 
            public string LastName { get; set; }  
            public string MiddleName { get; set; } 
            public DateTime BirthDate { get; set; }
            public string CellphoneNumber { get; set; }
            public string Gender { get; set; }
            public string BloodPressure { get; set; }
            public decimal? Height { get; set; }
            public decimal? Weight { get; set; }
            public decimal Temperature { get; set; }
            public string Concern { get; set; } 
            public string Status { get; set; }

            
        }


        private void LoadAssignedPatients(string searchTerm = "")
        {
            try
            {
                using (var conn = new database().GetConnection())
                {
                    conn.Open();

                    
                    string query = @"
                SELECT 
                    ap.patient_id, 
                    p.last_name, 
                    p.first_name, 
                    p.middle_name, 
                    p.birth_date, 
                    p.cellphone_number, 
                    p.gender,
                    ap.blood_pressure,
                    ap.height,
                    ap.weight,
                    ap.temperature,
                    ap.concern,
                    ap.status
                FROM assigned_patient ap
                INNER JOIN patient p ON ap.patient_id = p.patient_id
                WHERE ap.doctor_id = @DoctorId AND ap.status = 'pending'";

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " AND (p.first_name LIKE @SearchTerm OR p.last_name LIKE @SearchTerm)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                   
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAssignedPatients.Refresh();

                    if (dt.Rows.Count > 0)
                    {
                        dgvAssignedPatients.DataSource = dt;

                       
                        dgvAssignedPatients.Columns["patient_id"].HeaderText = "Patient ID";
                        dgvAssignedPatients.Columns["first_name"].HeaderText = "First Name";
                        dgvAssignedPatients.Columns["last_name"].HeaderText = "Last Name";
                        dgvAssignedPatients.Columns["middle_name"].HeaderText = "Middle Name";
                        dgvAssignedPatients.Columns["birth_date"].HeaderText = "Birth Date";
                        dgvAssignedPatients.Columns["cellphone_number"].HeaderText = "Cellphone Number";
                        dgvAssignedPatients.Columns["gender"].HeaderText = "Gender";
                        dgvAssignedPatients.Columns["blood_pressure"].HeaderText = "Blood Pressure";
                        dgvAssignedPatients.Columns["height"].HeaderText = "Height";
                        dgvAssignedPatients.Columns["weight"].HeaderText = "Weight";
                        dgvAssignedPatients.Columns["temperature"].HeaderText = "Temperature";
                        dgvAssignedPatients.Columns["concern"].HeaderText = "Concern";
                    }
                    else
                    {
                       
                        MessageBox.Show("No patients found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (selectedPatientId > 0)
                {
                    ResetPatientStatus(selectedPatientId);
                    LoadAssignedPatients(); 
                    ClearPatientDetails();   
                }
                else
                {
                    MessageBox.Show("No patient selected. Please select a patient to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int selectedPatientId = -1;

        private void dgvAssignedPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssignedPatients.Rows[e.RowIndex];

                if (row.Cells["patient_id"].Value != DBNull.Value)
                {
                    selectedPatientId = Convert.ToInt32(row.Cells["patient_id"].Value);
                    Console.WriteLine("Clicked Patient ID: " + selectedPatientId);

                    DialogResult result = MessageBox.Show("Do you want to view this patient's details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        CheckPatientStatus(selectedPatientId);
                    }
                }
                else
                {
                    MessageBox.Show("No patient information available for this row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void ResetPatientStatus(int patientId)
        {
            try
            {
                using (var conn = new database().GetConnection())
                {
                    conn.Open();
                    string query = @"
                UPDATE assigned_patient 
                SET status = 'pending', handled_by = NULL 
                WHERE patient_id = @PatientId AND doctor_id = @DoctorId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId); 

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Error resetting patient status. Please check the patient and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting patient status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPatientDetails()
        {
           
            txtpname.Clear();
            dpbirthdate.Value = DateTime.Now;
            txtcpnum.Clear();
            txtgender.Clear();
            txtbp.Clear();
            txtheight.Clear();
            txtweight.Clear();
            txttemp.Clear();
            txtconcern.Clear();
            txtage.Clear();
        }



        private void CheckPatientStatus(int patientId)
        {
            using (var conn = new database().GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT status, 
                   (SELECT CONCAT(first_name, ' ', last_name) 
                    FROM doctor 
                    WHERE doctor_id = handled_by) AS doctor_name
            FROM assigned_patient
            WHERE patient_id = @PatientId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientId", patientId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string status = reader.GetString("status");
                        string doctorName = reader.IsDBNull(reader.GetOrdinal("doctor_name")) ? null : reader.GetString("doctor_name");

                        if (status == "inprogress")
                        {
                            MessageBox.Show($"This patient is already being handled by Dr. {doctorName}.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }


            if (UpdatePatientStatusToInProgress(patientId))
            {
                LoadPatientDetails(patientId);
                LoadAssignedPatients();
            }

        }
       private bool UpdatePatientStatusToInProgress(int patientId)
        {
            try
            {
                using (var conn = new database().GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE assigned_patient SET status = 'inprogress', handled_by = @DoctorId WHERE patient_id = @PatientId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);  
                    cmd.Parameters.AddWithValue("@PatientId", patientId);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        return true; 
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Please check the patient information and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void LoadPatientDetails(int patientId)
        {
            using (var conn = new database().GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT CONCAT(p.last_name, ' ', p.first_name) AS full_name, 
                   p.birth_date, p.cellphone_number, p.gender, 
                   ap.blood_pressure, ap.height, ap.weight, ap.temperature, ap.concern,
                   ap.assigned_time, ap.status
            FROM patient p
            JOIN assigned_patient ap ON p.patient_id = ap.patient_id
            WHERE ap.patient_id = @PatientId AND ap.doctor_id = @DoctorId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtpname.Text = reader.IsDBNull(reader.GetOrdinal("full_name")) ? "N/A" : reader.GetString("full_name");
                        dpbirthdate.Value = reader.GetDateTime("birth_date");
                        txtcpnum.Text = reader.GetString("cellphone_number");
                        txtgender.Text = reader.GetString("gender");
                        txtbp.Text = reader.GetString("blood_pressure");
                        txtheight.Text = reader.IsDBNull(reader.GetOrdinal("height")) ? "N/A" : reader.GetDecimal("height").ToString();
                        txtweight.Text = reader.IsDBNull(reader.GetOrdinal("weight")) ? "N/A" : reader.GetDecimal("weight").ToString();
                        txttemp.Text = reader.GetDecimal("temperature").ToString();
                        txtconcern.Text = reader.GetString("concern");
                        DateTime birthDate = reader.GetDateTime("birth_date");
                        txtage.Text = CalculateAge(birthDate).ToString();
                    }
                    else
                    {
                      
                    }
                }
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void dpbirthdate_ValueChanged(object sender, EventArgs e)
        {
            txtage.Text = CalculateAge(dpbirthdate.Value).ToString();
        }

        private void frmdoctor_Load(object sender, EventArgs e)
        {
            LoadAssignedPatients();  
        }


      

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtsearch.Text.Trim(); // Get the search term

            
            LoadAssignedPatients(searchTerm);
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

        //SAVE MEDICAL RECORD OF PATIENT
       
        private void clearform()
        {
            txtpname.Text = string.Empty;
            txtage.Text = string.Empty;
            dpbirthdate.Value = DateTime.Now;
            txtcpnum.Text = string.Empty;
            txtgender.Text = string.Empty;
            txtbp.Text = string.Empty;
            txttemp.Text = string.Empty;
            txtheight.Text = string.Empty;
            txtweight.Text = string.Empty;
            txtconcern.Text = string.Empty;
            txtmedicalhistory.Text = string.Empty;
            txtfamilyhistory.Text = string.Empty;
            txtallergies.Text = string.Empty;
            txtAfood.Text = string.Empty;
            txtAmedicine.Text = string.Empty;
            cbyes.Checked = false;
            cbno.Checked = false;
            txttypeofmedication.Text = string.Empty;
            txtsymptoms.Text = string.Empty;
            txtdiagnosis.Text = string.Empty;
            txtprescriptions.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (selectedPatientId == 0)
            {
                MessageBox.Show("Please select a patient first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

          
            if (string.IsNullOrWhiteSpace(txtsymptoms.Text) ||
                string.IsNullOrWhiteSpace(txtdiagnosis.Text) ||
                string.IsNullOrWhiteSpace(txtprescriptions.Text))
            {
                MessageBox.Show("Please fill in all required fields (Symptoms, Diagnosis, Prescription).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            bool takesMedication = cbyes.Checked;
            string symptoms = txtsymptoms.Text.Trim();
            string diagnosis = txtdiagnosis.Text.Trim();
            string prescription = txtprescriptions.Text.Trim();

            decimal? height = null;
            if (!string.IsNullOrWhiteSpace(txtheight.Text) && decimal.TryParse(txtheight.Text, out decimal parsedHeight))
            {
                height = parsedHeight;
            }

            decimal? weight = null;
            if (!string.IsNullOrWhiteSpace(txtweight.Text) && decimal.TryParse(txtweight.Text, out decimal parsedWeight))
            {
                weight = parsedWeight;
            }

            try
            {
                using (var conn = new database().GetConnection())
                {
                    conn.Open();
                    string query = @"
                INSERT INTO medical_record
                (patient_name, age, birth_date, cellphone_number, gender, bloodpressure, temperature, height, weight, concern, 
                 medical_history, family_history, type_of_allergies, food_allergies, medicine_allergies, medication_now, type_of_medicine, 
                 symptoms, diagnosis, prescription, date) 
                VALUES 
                (@PatientName, @Age, @BirthDate, @CellphoneNumber, @Gender, @BloodPressure, @Temperature, @Height, @Weight, @Concern, 
                 @MedicalHistory, @FamilyHistory, @TypeOfAllergies, @FoodAllergies, @MedicineAllergies, @MedicationNow, @TypeOfMedicine, 
                 @Symptoms, @Diagnosis, @Prescription, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", txtpname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Age", int.Parse(txtage.Text.Trim()));
                        cmd.Parameters.AddWithValue("@BirthDate", dpbirthdate.Value);
                        cmd.Parameters.AddWithValue("@CellphoneNumber", txtcpnum.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", txtgender.Text.Trim());
                        cmd.Parameters.AddWithValue("@BloodPressure", txtbp.Text.Trim());
                        cmd.Parameters.AddWithValue("@Temperature", decimal.Parse(txttemp.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Height", (object)height ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Weight", (object)weight ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Concern", txtconcern.Text.Trim());
                        cmd.Parameters.AddWithValue("@MedicalHistory", txtmedicalhistory.Text.Trim());
                        cmd.Parameters.AddWithValue("@FamilyHistory", txtmedicalhistory.Text.Trim());
                        cmd.Parameters.AddWithValue("@TypeOfAllergies", txtallergies.Text.Trim());
                        cmd.Parameters.AddWithValue("@FoodAllergies", txtAfood.Text.Trim());
                        cmd.Parameters.AddWithValue("@MedicineAllergies", txtAmedicine.Text.Trim());
                        cmd.Parameters.AddWithValue("@MedicationNow", cbyes.Checked);
                        cmd.Parameters.AddWithValue("@TypeOfMedicine", txttypeofmedication.Text.Trim());
                        cmd.Parameters.AddWithValue("@Symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@Prescription", prescription);

                        cmd.ExecuteNonQuery();
                    }
                    //saving the patient details for billing

                    string deleteQuery = "DELETE FROM assigned_patient WHERE patient_id = @PatientId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@PatientId", selectedPatientId);
                    deleteCmd.ExecuteNonQuery();

                    LoadAssignedPatients(); 
                    MessageBox.Show("Patient Medical Record Is Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearform();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbfollow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfollow.Checked)
            {
                dtpfollow.Enabled = true; 
            }
            else
            {
                dtpfollow.Enabled = false; 
            }
        }

        private void btnmedhistory_Click(object sender, EventArgs e)
        {
            frmdoctormedHistory mh = new frmdoctormedHistory(doctorId, lastName);
            mh.Show();
            this.Hide();
        }

        private void btnassigned_Click(object sender, EventArgs e)
        {
            
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

        private void btnreferral_Click(object sender, EventArgs e)
        {
            frmdoctorreferral df = new frmdoctorreferral(doctorId, lastName);
            df.Show();
            this.Hide();
        }
    }
}
