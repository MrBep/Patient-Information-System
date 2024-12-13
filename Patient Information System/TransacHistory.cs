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
    public partial class TransacHistory : UserControl
    {
        public TransacHistory()
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

        public class billingInfo
        {
            public int BillingID { get; set; }  
            public string PatientName { get; set; }
            public int? Age { get; set; }
            public string Gender { get; set; }
            public decimal? Consultation { get; set; }
            public decimal? Total { get; set; }
            public decimal? Amount { get; set; }
            public decimal? Change { get; set; }
            public string Discount { get; set; }
            public DateTime? Date { get; set; }

        }

        private void LoadAllBillingRecords()
        {
            if (dgvAssignedPatients == null)
            {
                MessageBox.Show("DataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new database().GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    billing_id, 
                    patient_name, 
                    age, 
                    gender,
                    consultation_fee,
                    discount,
                    total_bill,
                    amount_paid,
                    change_amount,
                    date_created
                FROM billing_details";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<billingInfo> billingList = new List<billingInfo>();

                        while (reader.Read())
                        {
                            billingInfo billing = new billingInfo
                            {
                                BillingID = reader.GetInt32("billing_id"),
                                PatientName = reader.IsDBNull(reader.GetOrdinal("patient_name")) ? null : reader.GetString("patient_name"),
                                Age = reader.IsDBNull(reader.GetOrdinal("age")) ? (int?)null : reader.GetInt32("age"),
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? null : reader.GetString("gender"),
                                Consultation = reader.IsDBNull(reader.GetOrdinal("consultation_fee")) ? (decimal?)null : reader.GetDecimal("consultation_fee"),
                                Discount = reader.IsDBNull(reader.GetOrdinal("discount")) ? null : reader.GetString("discount"),
                                Total = reader.IsDBNull(reader.GetOrdinal("total_bill")) ? (decimal?)null : reader.GetDecimal("total_bill"),
                                Amount = reader.IsDBNull(reader.GetOrdinal("amount_paid")) ? (decimal?)null : reader.GetDecimal("amount_paid"),
                                Change = reader.IsDBNull(reader.GetOrdinal("change_amount")) ? (decimal?)null : reader.GetDecimal("change_amount"),
                                Date = reader.IsDBNull(reader.GetOrdinal("date_created")) ? (DateTime?)null : reader.GetDateTime("date_created"),
                            };

                            billingList.Add(billing);
                        }

                        if (billingList == null || billingList.Count == 0)
                        {
                            MessageBox.Show("No billing records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvAssignedPatients.DataSource = null;
                            return;
                        }

                        dgvAssignedPatients.DataSource = new BindingList<billingInfo>(billingList);
                    }
                }
                catch (Exception ex)
                {
                    dgvAssignedPatients.DataSource = null;
                    MessageBox.Show("Error retrieving patient transaction history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void dgvAssignedPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssignedPatients.Rows[e.RowIndex];
                int billingId = Convert.ToInt32(row.Cells["BillingID"].Value);
                txtpname.Text = row.Cells["PatientName"].Value?.ToString() ?? string.Empty;
                txtage.Text = row.Cells["Age"].Value?.ToString() ?? string.Empty;
                txtgender.Text = row.Cells["Gender"].Value?.ToString() ?? string.Empty;
                txtconsultfee.Text = row.Cells["Consultation"].Value?.ToString() ?? string.Empty;
                txtdiscount.Text = row.Cells["Discount"].Value?.ToString() ?? string.Empty;
                txttotal.Text = row.Cells["Total"].Value?.ToString() ?? string.Empty;
                txtamount.Text = row.Cells["Amount"].Value?.ToString() ?? string.Empty;
                lblchange.Text = row.Cells["Change"].Value?.ToString() ?? string.Empty;
                dtpvisitdate.Value = row.Cells["Date"].Value != null ? Convert.ToDateTime(row.Cells["Date"].Value) : DateTime.Now;


            }
        }

        private void TransacHistory_Load(object sender, EventArgs e)
        {
            LoadAllBillingRecords();
        
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            LoadAllBillingRecords();
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
                billing_id AS BillingID, 
                patient_name AS PatientName, 
                age AS Age, 
                gender AS Gender,
                consultation_fee AS Consultation,
                discount AS Discount,
                total_bill AS Total,
                amount_paid AS Amount,
                change_amount AS `Change`,
                date_created AS `Date`
            FROM billing_details
            WHERE patient_name LIKE @SearchTerm OR billing_id LIKE @SearchTerm";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchKeyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAssignedPatients.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching patient transaction record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpname.Text = string.Empty;
            txtage.Text = string.Empty;
            txtgender.Text = string.Empty;
            txtconsultfee.Text = string.Empty;
            txtdiscount.Text=string.Empty;
            txttotal.Text = string.Empty;
            txtamount.Text = string.Empty;
            lblchange.Text = "0.0";
        }
    }
}
