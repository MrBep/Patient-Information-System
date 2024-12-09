using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Patient_Information_System.medicalhistoryUser;

namespace Patient_Information_System
{
    public partial class referral : UserControl
    {
        public referral()
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
            public string Gender { get; set; }
            public string Symptoms { get; set; }
            public string Diagnosis { get; set; }
            public DateTime? DateofVisit { get; set; }
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
                    gender, 
                    symptoms, 
                    diagnosis, 
                    date
                FROM medical_record
                WHERE DATE(date) = CURDATE()"; 

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
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? null : reader.GetString("gender"),
                                DateofVisit = reader.IsDBNull(reader.GetOrdinal("date")) ? (DateTime?)null : reader.GetDateTime("date"),
                                Symptoms = reader.IsDBNull(reader.GetOrdinal("symptoms")) ? null : reader.GetString("symptoms"),
                                Diagnosis = reader.IsDBNull(reader.GetOrdinal("diagnosis")) ? null : reader.GetString("diagnosis"),
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


        
        private void referral_Load(object sender, EventArgs e)
        {
            LoadAllPatientMedicalRecords();
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
                    gender AS Gender,       
                    symptoms AS Symptoms, 
                    diagnosis AS Diagnosis, 
                    date AS DateofVisit
                FROM medical_record
                WHERE DATE(date) = CURDATE()
                  AND (patient_name LIKE @SearchTerm 
                  OR patient_id LIKE @SearchTerm)";

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

        private void dgvAssignedPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssignedPatients.Rows[e.RowIndex];

                int patientId = Convert.ToInt32(row.Cells["PatientID"].Value);
                txtpname.Text = row.Cells["PatientName"].Value?.ToString() ?? string.Empty;
                txtage.Text = row.Cells["Age"].Value?.ToString() ?? string.Empty;
                dpbirthdate.Value = row.Cells["BirthDate"].Value != null ? Convert.ToDateTime(row.Cells["BirthDate"].Value) : DateTime.Now;
                txtgender.Text = row.Cells["Gender"].Value?.ToString() ?? string.Empty;
                dtpvisitdate.Value = row.Cells["DateofVisit"].Value != null ? Convert.ToDateTime(row.Cells["DateofVisit"].Value) : DateTime.Now;
                txtsymptoms.Text = row.Cells["Symptoms"].Value?.ToString() ?? string.Empty;
                txtpdiagnosis.Text = row.Cells["Diagnosis"].Value?.ToString() ?? string.Empty;

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpname.Text = string.Empty;
            txtage.Text = string.Empty;
            dpbirthdate.Value = DateTime.Now;
            txtgender.Text = string.Empty;
            txtsymptoms.Text = string.Empty;
            txtpdiagnosis.Text = string.Empty;
            dtpvisitdate.Value = DateTime.Now;
        }


        private void btprint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font labelFont = new Font("Arial", 12, FontStyle.Bold);
            Font textFont = new Font("Arial", 12);

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float pageWidth = e.MarginBounds.Width;
            float yPosition = topMargin;

            Image logo = Image.FromFile("C:\\Users\\carlo\\Downloads\\Kwin_Creation_2__1_-removebg-preview.png");

            float logoWidth = 30;
            float logoHeight = 30;

            float totalWidth = logoWidth + 10 + e.Graphics.MeasureString("Serene Sky Horizon", titleFont).Width;
            float logoX = (pageWidth - totalWidth) / 2;

            e.Graphics.DrawImage(logo, logoX, yPosition, logoWidth, logoHeight);
            e.Graphics.DrawString("SERENE SKY HORIZON", titleFont, Brushes.Black, logoX + logoWidth + 10, yPosition);

            yPosition += logoHeight + 10;

            string referralFormText = "Doctor Referral Form";
            float referralFormWidth = e.Graphics.MeasureString(referralFormText, titleFont).Width;
            float referralFormX = (pageWidth - referralFormWidth) / 2;
            e.Graphics.DrawString(referralFormText, titleFont, Brushes.Black, referralFormX, yPosition);

            yPosition += titleFont.GetHeight(e.Graphics) + 40;

            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", textFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 30;


            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, pageWidth - leftMargin, yPosition);
            yPosition += 10;

            e.Graphics.DrawString("Patient Information", subHeaderFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 40;

            e.Graphics.DrawString("Patient Name:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtpname.Text, textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Gender:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtgender.Text, textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Age:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtage.Text, textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Date of Birth:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(dpbirthdate.Value.ToShortDateString(), textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Date Today:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(dtpvisitdate.Value.ToShortDateString(), textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 50;

  
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, pageWidth - leftMargin, yPosition);
            yPosition += 10;

            e.Graphics.DrawString("Referral Details", subHeaderFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 40;

            e.Graphics.DrawString("Referred Doctor:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtreffereddoctor.Text, textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Specialization:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtspecialization.Text, textFont, Brushes.Black, leftMargin + 150, yPosition);
            yPosition += 50;

  
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, pageWidth - leftMargin, yPosition);
            yPosition += 10;

            e.Graphics.DrawString("Diagnosis Information", subHeaderFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 40;

            e.Graphics.DrawString("Symptoms:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtsymptoms.Text, textFont, Brushes.Black, leftMargin + 110, yPosition);
            yPosition += 35;

            e.Graphics.DrawString("Primary Diagnosis:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtpdiagnosis.Text, textFont, Brushes.Black, leftMargin + 170, yPosition);
            yPosition += 35;

            e.Graphics.DrawString("Reason for Referral:", labelFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(txtreffered.Text, textFont, Brushes.Black, leftMargin + 170, yPosition);
            yPosition += 35;

            
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, pageWidth - leftMargin, yPosition);
            yPosition += 20;

            e.Graphics.DrawString("Note: This referral is strictly confidential and intended only for the use of the referred specialist.", textFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Thank you for your trust in our services.", textFont, Brushes.Black, leftMargin, yPosition);

        }
    }
}
