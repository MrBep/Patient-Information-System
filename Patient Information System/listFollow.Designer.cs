namespace Patient_Information_System
{
    partial class listFollow
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
            this.lbllist = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtprescription = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.dtgwlistfollowpatient = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.dtpvisitdate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.dtpfollowdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistfollowpatient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(34, 74);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(103, 21);
            this.lbllist.TabIndex = 33;
            this.lbllist.Text = "List of Patient";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.Location = new System.Drawing.Point(944, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 46);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtprescription
            // 
            this.txtprescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtprescription.Location = new System.Drawing.Point(143, 266);
            this.txtprescription.Multiline = true;
            this.txtprescription.Name = "txtprescription";
            this.txtprescription.Size = new System.Drawing.Size(733, 88);
            this.txtprescription.TabIndex = 18;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbladdress.Location = new System.Drawing.Point(143, 242);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(118, 21);
            this.lbladdress.TabIndex = 17;
            this.lbladdress.Text = "PRESCRIPTION:";
            // 
            // dtgwlistfollowpatient
            // 
            this.dtgwlistfollowpatient.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgwlistfollowpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwlistfollowpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4});
            this.dtgwlistfollowpatient.Location = new System.Drawing.Point(38, 98);
            this.dtgwlistfollowpatient.Name = "dtgwlistfollowpatient";
            this.dtgwlistfollowpatient.Size = new System.Drawing.Size(1054, 137);
            this.dtgwlistfollowpatient.TabIndex = 32;
            this.dtgwlistfollowpatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwlistfollowpatient_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(584, 63);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpfollowdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtage);
            this.panel1.Controls.Add(this.lblage);
            this.panel1.Controls.Add(this.txtgender);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.dtpvisitdate);
            this.panel1.Controls.Add(this.lblbirthdate);
            this.panel1.Controls.Add(this.txtpname);
            this.panel1.Controls.Add(this.lblpname);
            this.panel1.Controls.Add(this.txtprescription);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Location = new System.Drawing.Point(38, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 526);
            this.panel1.TabIndex = 36;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(521, 71);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 34;
            this.lblsearch.Text = "Search";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtage.Location = new System.Drawing.Point(373, 163);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(93, 29);
            this.txtage.TabIndex = 65;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblage.Location = new System.Drawing.Point(369, 139);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 21);
            this.lblage.TabIndex = 64;
            this.lblage.Text = "Age";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtgender.Location = new System.Drawing.Point(496, 163);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(114, 29);
            this.txtgender.TabIndex = 63;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblgender.Location = new System.Drawing.Point(492, 139);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 62;
            this.lblgender.Text = "Gender";
            // 
            // dtpvisitdate
            // 
            this.dtpvisitdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpvisitdate.CustomFormat = " MMMM dd, yyyy";
            this.dtpvisitdate.Enabled = false;
            this.dtpvisitdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpvisitdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpvisitdate.Location = new System.Drawing.Point(637, 163);
            this.dtpvisitdate.Name = "dtpvisitdate";
            this.dtpvisitdate.Size = new System.Drawing.Size(210, 29);
            this.dtpvisitdate.TabIndex = 59;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbirthdate.Location = new System.Drawing.Point(637, 139);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(97, 21);
            this.lblbirthdate.TabIndex = 58;
            this.lblbirthdate.Text = "Date Of Visit";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpname.Location = new System.Drawing.Point(145, 163);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(213, 29);
            this.txtpname.TabIndex = 57;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblpname.Location = new System.Drawing.Point(145, 139);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(103, 21);
            this.lblpname.TabIndex = 56;
            this.lblpname.Text = "Patient Name";
            // 
            // dtpfollowdate
            // 
            this.dtpfollowdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpfollowdate.CustomFormat = " MMMM dd, yyyy";
            this.dtpfollowdate.Enabled = false;
            this.dtpfollowdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpfollowdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfollowdate.Location = new System.Drawing.Point(735, 441);
            this.dtpfollowdate.Name = "dtpfollowdate";
            this.dtpfollowdate.Size = new System.Drawing.Size(210, 29);
            this.dtpfollowdate.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(735, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Follow Up Date";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Follow Up_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 154;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.Name = "Column5";
            this.Column5.Width = 154;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            this.Column6.Width = 154;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date Of Visit";
            this.Column7.Name = "Column7";
            this.Column7.Width = 154;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Follow Up Date";
            this.Column3.Name = "Column3";
            this.Column3.Width = 154;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prescription";
            this.Column4.Name = "Column4";
            this.Column4.Width = 154;
            // 
            // listFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.dtgwlistfollowpatient);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsearch);
            this.Name = "listFollow";
            this.Size = new System.Drawing.Size(1174, 873);
            this.Load += new System.EventHandler(this.listFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistfollowpatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtprescription;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.DataGridView dtgwlistfollowpatient;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DateTimePicker dtpfollowdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.DateTimePicker dtpvisitdate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
