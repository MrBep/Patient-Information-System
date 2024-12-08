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

namespace Patient_Information_System
{
    public partial class medicalhistoryUser : UserControl
    {
        public medicalhistoryUser()
        {
            InitializeComponent();
            
        }

        public class database
        {
            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
        public class PatientInfo
        {
            public int PatientID { get; set; }
            public string PatientName { get; set; }
            public int? Age { get; set; }
            public DateTime? BirthDate { get; set; }
            public string CellphoneNumber { get; set; }
            public string Gender { get; set; }
            public string BloodPressure { get; set; }
            public decimal? Temperature { get; set; }
            public decimal? Height { get; set; }
            public decimal? Weight { get; set; }
            public string Concern { get; set; }
            public string MedicalHistory { get; set; }
            public string FamilyHistory { get; set; }
            public string TypeOfAllergies { get; set; }
            public string FoodAllergies { get; set; }
            public string MedicineAllergies { get; set; }
            public bool MedicationNow { get; set; }
            public string TypeOfMedicine { get; set; }
            public string Symptoms { get; set; }
            public string Diagnosis { get; set; }
            public string Prescription { get; set; }
            public DateTime? DateofVisit { get; set; }
        }

        private int selectedPatientId = -1;
        private int patientId;
        private void medicalhistoryUser_Load(object sender, EventArgs e)
        {
            LoadAllPatientMedicalRecords();
        }
        

        private void LoadAllPatientMedicalRecords()
        {
            using (var conn = new database().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    patient_id, 
                    patient_name, 
                    age, 
                    birth_date, 
                    cellphone_number, 
                    gender, 
                    bloodpressure, 
                    temperature, 
                    height, 
                    weight, 
                    concern, 
                    medical_history, 
                    family_history, 
                    type_of_allergies, 
                    food_allergies, 
                    medicine_allergies, 
                    medication_now, 
                    type_of_medicine, 
                    symptoms, 
                    diagnosis, 
                    prescription,
                    date
                FROM medical_record";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                  
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<PatientInfo> patientList = new List<PatientInfo>();

                        while (reader.Read())
                        {
                            PatientInfo patient = new PatientInfo
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.IsDBNull(reader.GetOrdinal("patient_name")) ? null : reader.GetString("patient_name"),
                                Age = reader.IsDBNull(reader.GetOrdinal("age")) ? (int?)null : reader.GetInt32("age"),
                                BirthDate = reader.IsDBNull(reader.GetOrdinal("birth_date")) ? (DateTime?)null : reader.GetDateTime("birth_date"),
                                CellphoneNumber = reader.IsDBNull(reader.GetOrdinal("cellphone_number")) ? null : reader.GetString("cellphone_number"),
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? null : reader.GetString("gender"),
                                DateofVisit = reader.IsDBNull(reader.GetOrdinal("date")) ? (DateTime?)null : reader.GetDateTime("date"),
                                BloodPressure = reader.IsDBNull(reader.GetOrdinal("bloodpressure")) ? null : reader.GetString("bloodpressure"),
                                Temperature = reader.IsDBNull(reader.GetOrdinal("temperature")) ? (decimal?)null : reader.GetDecimal("temperature"),
                                Height = reader.IsDBNull(reader.GetOrdinal("height")) ? (decimal?)null : reader.GetDecimal("height"),
                                Weight = reader.IsDBNull(reader.GetOrdinal("weight")) ? (decimal?)null : reader.GetDecimal("weight"),
                                Concern = reader.IsDBNull(reader.GetOrdinal("concern")) ? null : reader.GetString("concern"),
                                MedicalHistory = reader.IsDBNull(reader.GetOrdinal("medical_history")) ? null : reader.GetString("medical_history"),
                                FamilyHistory = reader.IsDBNull(reader.GetOrdinal("family_history")) ? null : reader.GetString("family_history"),
                                TypeOfAllergies = reader.IsDBNull(reader.GetOrdinal("type_of_allergies")) ? null : reader.GetString("type_of_allergies"),
                                FoodAllergies = reader.IsDBNull(reader.GetOrdinal("food_allergies")) ? null : reader.GetString("food_allergies"),
                                MedicineAllergies = reader.IsDBNull(reader.GetOrdinal("medicine_allergies")) ? null : reader.GetString("medicine_allergies"),
                                MedicationNow = reader.IsDBNull(reader.GetOrdinal("medication_now")) ? false : reader.GetBoolean("medication_now"),
                                TypeOfMedicine = reader.IsDBNull(reader.GetOrdinal("type_of_medicine")) ? null : reader.GetString("type_of_medicine"),
                                Symptoms = reader.IsDBNull(reader.GetOrdinal("symptoms")) ? null : reader.GetString("symptoms"),
                                Diagnosis = reader.IsDBNull(reader.GetOrdinal("diagnosis")) ? null : reader.GetString("diagnosis"),
                                Prescription = reader.IsDBNull(reader.GetOrdinal("prescription")) ? null : reader.GetString("prescription")
                            };

                            patientList.Add(patient);
                        }

                       
                        dgvAssignedPatients.DataSource = new BindingList<PatientInfo>(patientList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving patient medical records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvAssignedPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvAssignedPatients.Rows[e.RowIndex];

                int patientId = Convert.ToInt32(row.Cells["PatientID"].Value);
                txtpname.Text = row.Cells["PatientName"].Value?.ToString() ?? string.Empty;
                txtage.Text = row.Cells["Age"].Value?.ToString() ?? string.Empty;
                dpbirthdate.Value = row.Cells["BirthDate"].Value != null ? Convert.ToDateTime(row.Cells["BirthDate"].Value) : DateTime.Now;
                txtcpnum.Text = row.Cells["CellphoneNumber"].Value?.ToString() ?? string.Empty;
                txtgender.Text = row.Cells["Gender"].Value?.ToString() ?? string.Empty;
                dtpvisitdate.Value = row.Cells["DateofVisit"].Value != null ? Convert.ToDateTime(row.Cells["DateofVisit"].Value) : DateTime.Now;
                txtbp.Text = row.Cells["BloodPressure"].Value?.ToString() ?? string.Empty;
                txttemp.Text = row.Cells["Temperature"].Value?.ToString() ?? string.Empty;
                txtheight.Text = row.Cells["Height"].Value?.ToString() ?? string.Empty;
                txtweight.Text = row.Cells["Weight"].Value?.ToString() ?? string.Empty;
                txtconcern.Text = row.Cells["Concern"].Value?.ToString() ?? string.Empty;
                txtmedicalhistory.Text = row.Cells["MedicalHistory"].Value?.ToString() ?? string.Empty;
                txtfamilyhistory.Text = row.Cells["FamilyHistory"].Value?.ToString() ?? string.Empty;
                txtallergies.Text = row.Cells["TypeOfAllergies"].Value?.ToString() ?? string.Empty;
                txtAfood.Text = row.Cells["FoodAllergies"].Value?.ToString() ?? string.Empty;
                txtAmedicine.Text = row.Cells["MedicineAllergies"].Value?.ToString() ?? string.Empty;
                cbyes.Checked = row.Cells["MedicationNow"].Value != null && Convert.ToBoolean(row.Cells["MedicationNow"].Value);
                cbno.Checked = !cbyes.Checked;
                txttypeofmedication.Text = row.Cells["TypeOfMedicine"].Value?.ToString() ?? string.Empty;
                txtsymptoms.Text = row.Cells["Symptoms"].Value?.ToString() ?? string.Empty;
                txtdiagnosis.Text = row.Cells["Diagnosis"].Value?.ToString() ?? string.Empty;
                txtprescriptions.Text = row.Cells["Prescription"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
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
            dtpvisitdate  .Value = DateTime.Now;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text.Trim();

            using (var conn = new database().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    patient_id AS PatientID, 
                    patient_name AS PatientName, 
                    age AS Age, 
                    birth_date AS BirthDate, 
                    cellphone_number AS CellphoneNumber, 
                    gender AS GendeR, 
                    bloodpressure AS BloodPressure, 
                    temperature AS Temperature, 
                    height AS Height, 
                    weight AS Weight, 
                    concern AS Concern, 
                    medical_history AS MedicalHistory, 
                    family_history AS FamilyHistory, 
                    type_of_allergies AS TypeOfAllergies, 
                    food_allergies AS FoodAllergies, 
                    medicine_allergies AS MedicineAllergies, 
                    medication_now AS MedicationNow, 
                    type_of_medicine AS TypeOfMedicine, 
                    symptoms AS Symptoms, 
                    diagnosis AS Diagnosis, 
                    prescription AS Prescription,
                    date AS DateofVisit
                FROM medical_record
                WHERE 
                    patient_name LIKE @SearchTerm 
                    OR patient_id LIKE @SearchTerm";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchKeyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAssignedPatients.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching patient records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            LoadAllPatientMedicalRecords();
        }
    }
}
