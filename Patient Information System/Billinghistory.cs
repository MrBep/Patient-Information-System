using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Information_System
{
    public partial class userBilling : UserControl
    {
        public userBilling()
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
            public string Gender { get; set; }
            public DateTime? Date { get; set; }
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
                    gender, 
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
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? null : reader.GetString("gender"),
                                Date = reader.IsDBNull(reader.GetOrdinal("date")) ? (DateTime?)null : reader.GetDateTime("date"),
                            };

                            patientList.Add(patient);
                        }


                        dgvAssignedPatients.DataSource = new BindingList<PatientInfo>(patientList);
                        dgvAssignedPatients.Columns["PatientID"].Width = 160;
                        dgvAssignedPatients.Columns["PatientName"].Width = 160;
                        dgvAssignedPatients.Columns["Age"].Width = 160;
                        dgvAssignedPatients.Columns["Gender"].Width = 160;
                        dgvAssignedPatients.Columns["Date"].Width = 160;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error retrieving patient records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtgender.Text = row.Cells["Gender"].Value?.ToString() ?? string.Empty;
                dtpvisitdate.Value = row.Cells["Date"].Value != null ? Convert.ToDateTime(row.Cells["Date"].Value) : DateTime.Now;

            }
        }


        private void Billinghistory_Load(object sender, EventArgs e)
        {
            cbdiscount.Items.Add("None");
            cbdiscount.Items.Add("Senior Citizen - 20%");
            cbdiscount.Items.Add("PWD - 20%");
            cbdiscount.SelectedIndex = 0;

           
            lblchange.Text = "CHANGE: P 0.0";

            LoadAllPatientMedicalRecords();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpname.Clear();
            txtage.Clear();
            txtgender.Clear();
           txtconsultfee.Clear();
            cbdiscount.SelectedIndex = 0;
            txttotal.Clear();
            txtamount.Clear();
            lblchange.Text = "CHANGE: P 0.0";

        }

        private void clearform()
        {
            txtpname.Text = string.Empty;
            txtage.Text = string.Empty;
            txtgender.Text = string.Empty;
            txtconsultfee.Text = string.Empty;
            cbdiscount.SelectedIndex = 0;
            txttotal.Text = string.Empty;
            txtamount.Text = string.Empty;
            lblchange.Text = "CHANGE: P 0.0";
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
                    gender AS Gender,       
                    date AS `Date`
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

        //CALCULATION

        private void CalculateTotalBill()
        {
            //numerical
            if (decimal.TryParse(txtconsultfee.Text, out decimal consultationFee))
            {
                decimal discount = 0;

                //branching
                switch (cbdiscount.SelectedItem?.ToString())
                {
                    case "Senior Citizen - 20%":
                    case "PWD - 20%":
                        discount = 0.20m;
                        break;
                }

                
                decimal totalBill = consultationFee - (consultationFee * discount);
                txttotal.Text = totalBill.ToString("F2");

                
                CalculateChange();
            }
            else
            {
                txttotal.Text = "0.00";
            }
        }

        private void CalculateChange()
        {
             
            if (decimal.TryParse(txttotal.Text, out decimal totalBill) &&
                decimal.TryParse(txtamount.Text, out decimal amountPaid))
            {
                
                if (amountPaid >= totalBill)
                {
                    decimal change = amountPaid - totalBill;
                    lblchange.Text = $"CHANGE: P {change:F2}";
                }
                else
                {
                    lblchange.Text = "CHANGE: P 0.0";
                }
            }
            else
            {
                lblchange.Text = "CHANGE: P 0.0";
            }
        }

        private void txtconsultfee_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalBill();
        }

        private void cbdiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalBill();
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void SaveBillingDetails()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtpname.Text) ||
                    string.IsNullOrWhiteSpace(txtage.Text) ||
                    string.IsNullOrWhiteSpace(txtgender.Text) ||
                    string.IsNullOrWhiteSpace(txtconsultfee.Text) ||
                    string.IsNullOrWhiteSpace(txttotal.Text) ||
                    string.IsNullOrWhiteSpace(txtamount.Text) ||
                    string.IsNullOrWhiteSpace(lblchange.Text) ||
                    cbdiscount.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }


                if (!int.TryParse(txtage.Text, out int age))
                {
                    MessageBox.Show("Invalid age format.");
                    return;
                }


                if (!decimal.TryParse(txtconsultfee.Text, out decimal consultationFee))
                {
                    MessageBox.Show("Invalid consultation fee format.");
                    return;
                }


                if (!decimal.TryParse(txttotal.Text, out decimal totalBill))
                {
                    MessageBox.Show("Invalid total bill format.");
                    return;
                }


                if (!decimal.TryParse(txtamount.Text, out decimal amountPaid))
                {
                    MessageBox.Show("Invalid amount paid format.");
                    return;
                }


                string changeAmountText = lblchange.Text.Replace("CHANGE", "") 
                                             .Replace("P", "")
                                             .Replace(":","")
                                             .Trim();
               


                if (!decimal.TryParse(changeAmountText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal changeAmount))
                {
                    MessageBox.Show("Invalid change amount format.");
                    return;
                }



                using (var conn = new database().GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO billing_details (patient_name, age, gender, consultation_fee, discount, total_bill, amount_paid, change_amount, date_created) " +
                                   "VALUES (@PatientName, @Age, @Gender, @ConsultationFee, @Discount, @TotalBill, @AmountPaid, @ChangeAmount, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", txtpname.Text);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Gender", txtgender.Text);
                        cmd.Parameters.AddWithValue("@ConsultationFee", consultationFee);
                        cmd.Parameters.AddWithValue("@Discount", cbdiscount.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@TotalBill", totalBill);
                        cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                        cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Details saved successfully.");
                        clearform();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = 50;
            float lineSpacing = 30;

           
            float contentHeight = 0;
            contentHeight += lineSpacing * 2; 
            contentHeight += lineSpacing + 20; 
            contentHeight += lineSpacing * 5; 
            contentHeight += lineSpacing + 20; 
            contentHeight += lineSpacing * 6; 
            contentHeight += lineSpacing + 20; 
            contentHeight += lineSpacing * 3; 
            contentHeight += lineSpacing * 3; 

            float pageHeight = e.PageBounds.Height;
            float y = (pageHeight - contentHeight) / 2;


            float pageWidth = e.PageBounds.Width;

            
            string hospitalName = "SERENE SKY HORIZON";
            string billingTitle = "Medical Billing Invoice";
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font subtitleFont = new Font("Arial", 14, FontStyle.Regular);

            
            SizeF hospitalNameSize = e.Graphics.MeasureString(hospitalName, titleFont);
            SizeF billingTitleSize = e.Graphics.MeasureString(billingTitle, subtitleFont);

            
            float centeredHospitalNameX = (pageWidth - hospitalNameSize.Width) / 2;
            float centeredBillingTitleX = (pageWidth - billingTitleSize.Width) / 2;

          
            e.Graphics.DrawString(hospitalName, titleFont, Brushes.Black, new PointF(centeredHospitalNameX, y));
            y += lineSpacing;
            e.Graphics.DrawString(billingTitle, subtitleFont, Brushes.Black, new PointF(centeredBillingTitleX, y));
            y += lineSpacing;

           
            e.Graphics.DrawLine(Pens.Black, new PointF(x, y), new PointF(pageWidth - x, y));
            y += 20;


            e.Graphics.DrawString("PATIENT INFORMATION", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Patient Name: {txtpname.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Age: {txtage.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Gender: {txtgender.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Date of Visit: {dtpvisitdate.Value.ToShortDateString()}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawLine(Pens.Black, new PointF(x, y), new PointF(750, y)); 
            y += 20;

            
            e.Graphics.DrawString("BILLING DETAILS", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Consultation Fee: P {txtconsultfee.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Discount: {cbdiscount.SelectedItem}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Total Bill: P {txttotal.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"Amount Paid: P {txtamount.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString($"CHANGE: {lblchange.Text}", new Font("Arial", 12), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawLine(Pens.Black, new PointF(x, y), new PointF(750, y));
            y += 20;

            
            e.Graphics.DrawString("Thank you for trusting Serene Sky Horizon Hospital!", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString("We wish you good health!", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, new PointF(x + 120, y));
            y += lineSpacing;
            e.Graphics.DrawLine(Pens.Black, new PointF(x, y), new PointF(750, y));
            y += 20;

            
            e.Graphics.DrawString("For inquiries, contact us:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString("Phone: (02) 1234-5678", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(x, y));
            y += lineSpacing;
            e.Graphics.DrawString("Email: info@sereneskyskyhorizon.com", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(x, y));
        }


    

    private void btnprint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();


            SaveBillingDetails();

           
        }
    }
}
