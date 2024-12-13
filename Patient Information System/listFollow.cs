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
using static Patient_Information_System.patientUser;

namespace Patient_Information_System
{
    public partial class listFollow : UserControl
    {
        public listFollow()
        {
            InitializeComponent();
            dtgwlistfollowpatient.CellClick += dtgwlistfollowpatient_CellClick;
        }

        public class database
        {

            private string connectionString = "server=localhost;database=hospital_management;username= root;password=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        public class followUpList
        {
            public int followID { get; set; }
            public string PatientName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Prescription { get; set; }
            public DateTime DateofVisit { get; set; }
            public DateTime Followup { get; set; }

        }

        public class followupData
        {
            private database data = new database();
            private Dictionary<string, List<followUpList>> searchCache = new Dictionary<string, List<followUpList>>();
            private Dictionary<int, followUpList> followCache = new Dictionary<int, followUpList>();


            public List<followUpList> getAllfollow()
            {
                List<followUpList> followList = new List<followUpList>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM followup_list";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            followUpList follow = new followUpList
                            {
                                followID = reader.GetInt32("p_id"),
                                PatientName = reader.GetString("patient_name"),
                                Gender = reader.GetString("gender"),
                                Age = reader.GetInt32("age"),
                                DateofVisit = reader.GetDateTime("date_of_visit"),
                                Followup = reader.GetDateTime("follow_up_date"),
                                Prescription = reader.GetString("prescription"),
                            };
                            followList.Add(follow);
                            followCache[follow.followID] = follow;
                        }
                    }
                }
                return followList;
            }//end

            public List<followUpList> searchFollowupPatien(string searchTerm)
            {
                if (searchCache.ContainsKey(searchTerm))
                {
                    return searchCache[searchTerm];
                }

                List<followUpList> followList = new List<followUpList>();
                using (var conn = data.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM followup_list WHERE patient_name LIKE @search";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            followUpList follow = new followUpList
                            {
                                followID = reader.GetInt32("p_id"),
                                PatientName = reader.GetString("patient_name"),
                                Gender = reader.GetString("gender"),
                                Age = reader.GetInt32("age"),
                                DateofVisit = reader.GetDateTime("date_of_visit"),
                                Followup = reader.GetDateTime("follow_up_date"),
                                Prescription = reader.GetString("prescription"),
                            };
                            followList.Add(follow);

                        }
                    }
                }


                searchCache[searchTerm] = followList;

                return followList;
            }
        }//end
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private List<followUpList> allPatient = new List<followUpList>();
        followupData followupAccess = new followupData();
        private int selectedFollowup = -1;


        private void loadFollowupData()
        {
            List<followUpList> allFollowUp = followupAccess.getAllfollow();

            int totalPages = (int)Math.Ceiling(allPatient.Count / (double)itemsPerPage);


            List<followUpList> pagedFollowUp = allFollowUp.Skip((currentPage - 1) * itemsPerPage).Take(itemsPerPage).ToList();

            dtgwlistfollowpatient.DataSource = null;
            dtgwlistfollowpatient.Rows.Clear();

            foreach (var follow in pagedFollowUp)
            {
                dtgwlistfollowpatient.Rows.Add(
                    follow.followID,
                    follow.PatientName,
                    follow.Age,
                    follow.Gender,
                    follow.DateofVisit.ToString("yyyy-MM-dd"),
                    follow.Followup.ToString("yyyy-MM-dd"),
                    follow.Prescription
                    );
            }
        }//end

        private void listFollow_Load(object sender, EventArgs e)
        {
            loadFollowupData();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchInfo = txtsearch.Text.Trim();

            List<followUpList> followList = followupAccess.searchFollowupPatien(searchInfo);

            if (followList.Count == 0)
            {
                MessageBox.Show("Follow Up Information not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgwlistfollowpatient.DataSource = null;
                dtgwlistfollowpatient.Rows.Clear();
            }
            else
            {
                dtgwlistfollowpatient.DataSource = null;
                dtgwlistfollowpatient.Rows.Clear();

                foreach (var follow in followList)
                {
                    dtgwlistfollowpatient.Rows.Add(
                        follow.followID,
                        follow.PatientName,
                        follow.Age,
                        follow.Gender,
                        follow.DateofVisit.ToString("yyyy-MM-dd"),
                        follow.Followup.ToString("yyyy-MM-dd"),
                        follow.Prescription
                        );
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpname.Text = "";
            txtage.Text = "";
            txtgender.Text = "";
            dtpfollowdate.Value = DateTime.Now;
            dtpvisitdate.Value = DateTime.Now;
            txtprescription.Text = "";
        }

        private void dtgwlistfollowpatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgwlistfollowpatient.Rows[e.RowIndex];

                selectedFollowup = Convert.ToInt32(row.Cells[0]?.Value);

                txtpname.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtage.Text = row.Cells[2]?.Value?.ToString() ?? "";
                txtgender.Text = row.Cells[3]?.Value?.ToString() ?? "";
                if (row.Cells[4]?.Value != null)
                {
                    dtpvisitdate.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                if (row.Cells[5]?.Value != null)
                {
                    dtpfollowdate.Value = Convert.ToDateTime(row.Cells[5].Value);
                }

                txtprescription.Text = row.Cells[6]?.Value?.ToString() ?? "";
            }
        }
    }
}
