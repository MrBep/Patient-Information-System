namespace Patient_Information_System
{
    partial class userBilling
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbdiscount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconsultfee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtage = new System.Windows.Forms.TextBox();
            this.dtpvisitdate = new System.Windows.Forms.DateTimePicker();
            this.lblvisitdate = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvAssignedPatients = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbdiscount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblchange);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtconsultfee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 445);
            this.panel1.TabIndex = 105;
            // 
            // cbdiscount
            // 
            this.cbdiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbdiscount.FormattingEnabled = true;
            this.cbdiscount.Location = new System.Drawing.Point(190, 112);
            this.cbdiscount.Name = "cbdiscount";
            this.cbdiscount.Size = new System.Drawing.Size(213, 29);
            this.cbdiscount.TabIndex = 15;
            this.cbdiscount.SelectedIndexChanged += new System.EventHandler(this.cbdiscount_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(59, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Discount";
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblchange.Location = new System.Drawing.Point(672, 356);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(0, 32);
            this.lblchange.TabIndex = 13;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtamount.Location = new System.Drawing.Point(190, 253);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(213, 29);
            this.txtamount.TabIndex = 11;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(59, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txttotal.Location = new System.Drawing.Point(190, 179);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(213, 29);
            this.txttotal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(59, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Bill";
            // 
            // txtconsultfee
            // 
            this.txtconsultfee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtconsultfee.Location = new System.Drawing.Point(190, 46);
            this.txtconsultfee.Name = "txtconsultfee";
            this.txtconsultfee.Size = new System.Drawing.Size(213, 29);
            this.txtconsultfee.TabIndex = 7;
            this.txtconsultfee.TextChanged += new System.EventHandler(this.txtconsultfee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultation Fee:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtage);
            this.panel3.Controls.Add(this.dtpvisitdate);
            this.panel3.Controls.Add(this.lblvisitdate);
            this.panel3.Controls.Add(this.lblage);
            this.panel3.Controls.Add(this.txtgender);
            this.panel3.Controls.Add(this.lblgender);
            this.panel3.Controls.Add(this.txtpname);
            this.panel3.Controls.Add(this.lblpname);
            this.panel3.Location = new System.Drawing.Point(49, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 105);
            this.panel3.TabIndex = 103;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtage.Location = new System.Drawing.Point(398, 54);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(93, 29);
            this.txtage.TabIndex = 55;
            // 
            // dtpvisitdate
            // 
            this.dtpvisitdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpvisitdate.CustomFormat = " MMMM dd, yyyy";
            this.dtpvisitdate.Enabled = false;
            this.dtpvisitdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpvisitdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpvisitdate.Location = new System.Drawing.Point(663, 54);
            this.dtpvisitdate.Name = "dtpvisitdate";
            this.dtpvisitdate.Size = new System.Drawing.Size(210, 29);
            this.dtpvisitdate.TabIndex = 99;
            // 
            // lblvisitdate
            // 
            this.lblvisitdate.AutoSize = true;
            this.lblvisitdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblvisitdate.Location = new System.Drawing.Point(659, 31);
            this.lblvisitdate.Name = "lblvisitdate";
            this.lblvisitdate.Size = new System.Drawing.Size(46, 21);
            this.lblvisitdate.TabIndex = 100;
            this.lblvisitdate.Text = "DATE";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblage.Location = new System.Drawing.Point(394, 30);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 21);
            this.lblage.TabIndex = 54;
            this.lblage.Text = "Age";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtgender.Location = new System.Drawing.Point(525, 54);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(114, 29);
            this.txtgender.TabIndex = 28;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblgender.Location = new System.Drawing.Point(521, 30);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 27;
            this.lblgender.Text = "Gender";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpname.Location = new System.Drawing.Point(147, 54);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(213, 29);
            this.txtpname.TabIndex = 5;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblpname.Location = new System.Drawing.Point(147, 30);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(103, 21);
            this.lblpname.TabIndex = 4;
            this.lblpname.Text = "Patient Name";
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnprint.Location = new System.Drawing.Point(513, 741);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(110, 46);
            this.btnprint.TabIndex = 106;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(132, 52);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(103, 21);
            this.lbllist.TabIndex = 108;
            this.lbllist.Text = "List of Patient";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(443, 44);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 110;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(380, 52);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 109;
            this.lblsearch.Text = "Search";
            // 
            // dgvAssignedPatients
            // 
            this.dgvAssignedPatients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAssignedPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedPatients.Location = new System.Drawing.Point(147, 76);
            this.dgvAssignedPatients.Name = "dgvAssignedPatients";
            this.dgvAssignedPatients.Size = new System.Drawing.Size(841, 70);
            this.dgvAssignedPatients.TabIndex = 107;
            this.dgvAssignedPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedPatients_CellClick);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.Location = new System.Drawing.Point(993, 100);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 46);
            this.btnclear.TabIndex = 111;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // userBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvAssignedPatients);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "userBilling";
            this.Size = new System.Drawing.Size(1174, 868);
            this.Load += new System.EventHandler(this.Billinghistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtconsultfee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.DateTimePicker dtpvisitdate;
        private System.Windows.Forms.Label lblvisitdate;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvAssignedPatients;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cbdiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
