using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static Patient_Information_System.patientUser;

namespace Patient_Information_System
{
    public partial class assignedToDoctor : UserControl
    {
        
        public assignedToDoctor()
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

        public class assignTodoctor
        {
            public int patientID { get; set; }

            public string lastname { get; set; }
            public string firstname { get; set; }
            public string middlename { get; set; }
            public DateTime birthdate { get; set; }
            public string gender { get; set; }
            public string concern { get; set; }
            public string cellphonenumber { get; set; }
        }


        public class assignDoctor
        {
            private database data = new database();
            //cache para sa mga na-search na patient.
            private Dictionary<string, List<patient>> searchCache = new Dictionary<string, List<patient>>();
            //cache para sa mga patient na nakuha sa database, naka index sila by pateintID.
            private Dictionary<int, patient> patientCache = new Dictionary<int, patient>();



            public List<patient> getllallPatient()//Kumukuha ng lahat ng patient na galing sa database
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
                            patientList.Add(Patient);
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

            public List<patient> searchPatient(string searchTerm)///paraan upang maghanap ng mga patient gamit ang kanilang unang pangalan o apelyido.
            {
                if (searchCache.ContainsKey(searchTerm))// I - checheck kung ang search term ay nasa cache
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

                                cellphonenumber = reader.GetString("cellphone_number"),
                            };
                            patientList.Add(Patient);
                        }
                    }
                }
                searchCache[searchTerm] = patientList;// Icacahe ang mga resulta ng search para sa susunod na paggamit.

                return patientList;
            }// end of search




        }//end of assignDoctor

        private int currentPage = 1;//Kasalukuyang pahina sa listahan ng mga patient.
        private int itemsPerPage = 10;//Bilang ng mga patient na ipapakita sa bawat pahina.
        private List<patient> allPatient = new List<patient>();//Listahan ng lahat ng patient na galing sa database.
        patientData patientAccess = new patientData();
        private int selectedPatient = -1;
        private database data = new database();

        private void loadPatientData()
        {

            allPatient = patientAccess.getllallPatient();

            if (allPatient == null || allPatient.Count == 0)
            {
                dtgwlistpatient.DataSource = null;
                dtgwlistpatient.Rows.Clear();
                MessageBox.Show("No patient records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Pag-compute ng kabuuang bilang ng mga pahina base sa bilang ng mga patient sa database
            int totalPages = (int)Math.Ceiling(allPatient.Count / (double)itemsPerPage);


            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            //Paghahati sa listahan ng mga patient batay sa kasalukuyang pahina at ang bilang ng dapat na nakalagay sa bawat pahina
            List<patient> pagedPatient = allPatient
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();


            dtgwlistpatient.DataSource = null;
            dtgwlistpatient.Rows.Clear();
            
            dtgwlistpatient.Refresh();


            foreach (var patient in pagedPatient)
            {
                dtgwlistpatient.Rows.Add(
                    patient.patientID,
                    patient.lastname,
                    patient.firstname,
                    patient.middlename,
                    patient.birthdate.ToString("yyyy-MM-dd"),
                    patient.cellphonenumber,
                    patient.gender
                );
            }

        }//end of loadPatientData

        private void assignedToDoctor_Load(object sender, EventArgs e)
        {
            loadPatientData();
           
        }

        private void AssignPatientToDoctors(int patientId, DateTime assignedTime, string concern, decimal temp, decimal? height, decimal? weight, string bp)
        {
            string query = @"
        INSERT INTO assigned_patient (patient_id, doctor_id, concern, blood_pressure, temperature, height, weight, assigned_time, status)
        SELECT @PatientId, d.doctor_id, @Concern, @BloodPressure, @Temperature, @Height, @Weight, @AssignedTime, 'pending'
        FROM doctor d
        WHERE (
               
                (@AssignedTime >= d.available_from AND @AssignedTime < d.available_to)
                OR
               
                (d.available_from > d.available_to AND 
                    (
                        @AssignedTime >= d.available_from OR @AssignedTime < d.available_to
                    )
                )
                OR
              
                (d.available_from = d.available_to AND @AssignedTime >= d.available_from AND @AssignedTime < d.available_to)
            );
    ";

            try
            {
                using (var conn = new database().GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
                    cmd.Parameters.AddWithValue("@Concern", concern);
                    cmd.Parameters.AddWithValue("@BloodPressure", bp);
                    cmd.Parameters.AddWithValue("@Temperature", temp);
                    cmd.Parameters.AddWithValue("@Height", (object)height ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Weight", (object)weight ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@AssignedTime", assignedTime);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient successfully assigned to available doctors.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnassignTOdr_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txttemp.Text) || string.IsNullOrEmpty(txtbp.Text)|| string.IsNullOrEmpty(txtconcern.Text))
            {
                MessageBox.Show("Please fill out the temperature and blood pressure fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DialogResult confirmation = MessageBox.Show("Are you sure you want to assign this patient to the doctor(s)?", "Confirm Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                
                if (selectedPatient == -1)
                {
                    MessageBox.Show("Please select a patient first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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


                int patientId = selectedPatient;
                DateTime assignedTime = DateTime.Now; 
                string concern = txtconcern.Text;
                decimal temp = Convert.ToDecimal(txttemp.Text);
                string bloodPressure = txtbp.Text;

                

                AssignPatientToDoctors(patientId, assignedTime, concern, temp, height, weight, bloodPressure);

                
                clearform();
                loadPatientData(); 
            }
            else
            {
                
                MessageBox.Show("Patient assignment was cancelled.", "Assignment Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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


        private void clearform()
        {
            txtlastname.Text = string.Empty;
            txtfirstname.Text = string.Empty;
            txtmiddlename.Text = string.Empty;
            txtconcern.Text = string.Empty;
            txtcpnum.Text = string.Empty;
            txtgender.Text = string.Empty;
            txttemp.Text = string.Empty;
            txtbp.Text = string.Empty;
            txtheight.Text = string.Empty;
            txtweight.Text = string.Empty;
            dpbirthdate.Value = DateTime.Now;


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

                txtgender.Text = row.Cells[6]?.Value?.ToString() ?? "";




            }
        }

       

        


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchInfo = txtsearch.Text.Trim();

            List<patient> patientList = patientAccess.searchPatient(searchInfo);

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

                foreach (var patient in patientList)
                {
                    dtgwlistpatient.Rows.Add(
                        patient.patientID,
                        patient.lastname,
                        patient.firstname,
                        patient.middlename,
                        patient.birthdate.ToString("yyyy-MM-dd"),
                        patient.cellphonenumber,
                        patient.gender
                        );
                }
            }
        }

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
    }
}
