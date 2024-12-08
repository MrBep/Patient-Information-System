namespace Patient_Information_System
{
    partial class referral
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtage = new System.Windows.Forms.TextBox();
            this.dtpvisitdate = new System.Windows.Forms.DateTimePicker();
            this.lblvisitdate = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.dpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.dgvAssignedPatients = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtspecialization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreffereddoctor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsymptoms = new System.Windows.Forms.TextBox();
            this.lblsymptoms = new System.Windows.Forms.Label();
            this.txtreffered = new System.Windows.Forms.TextBox();
            this.lblrefferef = new System.Windows.Forms.Label();
            this.txtpdiagnosis = new System.Windows.Forms.TextBox();
            this.lblprimarydiagnosis = new System.Windows.Forms.Label();
            this.btprint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(130, 59);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(103, 21);
            this.lbllist.TabIndex = 90;
            this.lbllist.Text = "List of Patient";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(441, 51);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 92;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(378, 59);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 91;
            this.lblsearch.Text = "Search";
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
            this.panel3.Controls.Add(this.dpbirthdate);
            this.panel3.Controls.Add(this.lblbirthdate);
            this.panel3.Controls.Add(this.txtpname);
            this.panel3.Controls.Add(this.lblpname);
            this.panel3.Location = new System.Drawing.Point(47, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 105);
            this.panel3.TabIndex = 93;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtage.Location = new System.Drawing.Point(286, 54);
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
            this.dtpvisitdate.Location = new System.Drawing.Point(774, 57);
            this.dtpvisitdate.Name = "dtpvisitdate";
            this.dtpvisitdate.Size = new System.Drawing.Size(210, 29);
            this.dtpvisitdate.TabIndex = 99;
            // 
            // lblvisitdate
            // 
            this.lblvisitdate.AutoSize = true;
            this.lblvisitdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblvisitdate.Location = new System.Drawing.Point(770, 34);
            this.lblvisitdate.Name = "lblvisitdate";
            this.lblvisitdate.Size = new System.Drawing.Size(98, 21);
            this.lblvisitdate.TabIndex = 100;
            this.lblvisitdate.Text = "DATE TODAY";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblage.Location = new System.Drawing.Point(282, 30);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 21);
            this.lblage.TabIndex = 54;
            this.lblage.Text = "Age";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtgender.Location = new System.Drawing.Point(636, 57);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(114, 29);
            this.txtgender.TabIndex = 28;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblgender.Location = new System.Drawing.Point(632, 33);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 27;
            this.lblgender.Text = "Gender";
            // 
            // dpbirthdate
            // 
            this.dpbirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.CustomFormat = " MMMM dd, yyyy";
            this.dpbirthdate.Enabled = false;
            this.dpbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpbirthdate.Location = new System.Drawing.Point(409, 54);
            this.dpbirthdate.Name = "dpbirthdate";
            this.dpbirthdate.Size = new System.Drawing.Size(210, 29);
            this.dpbirthdate.TabIndex = 11;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbirthdate.Location = new System.Drawing.Point(409, 30);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(79, 21);
            this.lblbirthdate.TabIndex = 10;
            this.lblbirthdate.Text = "Birth Date";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpname.Location = new System.Drawing.Point(58, 54);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(213, 29);
            this.txtpname.TabIndex = 5;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblpname.Location = new System.Drawing.Point(58, 30);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(103, 21);
            this.lblpname.TabIndex = 4;
            this.lblpname.Text = "Patient Name";
            // 
            // dgvAssignedPatients
            // 
            this.dgvAssignedPatients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAssignedPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedPatients.Location = new System.Drawing.Point(145, 83);
            this.dgvAssignedPatients.Name = "dgvAssignedPatients";
            this.dgvAssignedPatients.Size = new System.Drawing.Size(841, 70);
            this.dgvAssignedPatients.TabIndex = 89;
            this.dgvAssignedPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedPatients_CellClick);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.Location = new System.Drawing.Point(991, 107);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 46);
            this.btnclear.TabIndex = 97;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtspecialization);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtreffereddoctor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsymptoms);
            this.panel1.Controls.Add(this.lblsymptoms);
            this.panel1.Controls.Add(this.txtreffered);
            this.panel1.Controls.Add(this.lblrefferef);
            this.panel1.Controls.Add(this.txtpdiagnosis);
            this.panel1.Controls.Add(this.lblprimarydiagnosis);
            this.panel1.Location = new System.Drawing.Point(47, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 445);
            this.panel1.TabIndex = 98;
            // 
            // txtspecialization
            // 
            this.txtspecialization.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtspecialization.Location = new System.Drawing.Point(646, 45);
            this.txtspecialization.Name = "txtspecialization";
            this.txtspecialization.Size = new System.Drawing.Size(213, 29);
            this.txtspecialization.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(646, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "Specialization";
            // 
            // txtreffereddoctor
            // 
            this.txtreffereddoctor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtreffereddoctor.Location = new System.Drawing.Point(130, 45);
            this.txtreffereddoctor.Name = "txtreffereddoctor";
            this.txtreffereddoctor.Size = new System.Drawing.Size(213, 29);
            this.txtreffereddoctor.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "Reffered Doctor Name";
            // 
            // txtsymptoms
            // 
            this.txtsymptoms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsymptoms.Location = new System.Drawing.Point(27, 109);
            this.txtsymptoms.Multiline = true;
            this.txtsymptoms.Name = "txtsymptoms";
            this.txtsymptoms.Size = new System.Drawing.Size(994, 86);
            this.txtsymptoms.TabIndex = 72;
            // 
            // lblsymptoms
            // 
            this.lblsymptoms.AutoSize = true;
            this.lblsymptoms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsymptoms.Location = new System.Drawing.Point(31, 85);
            this.lblsymptoms.Name = "lblsymptoms";
            this.lblsymptoms.Size = new System.Drawing.Size(96, 21);
            this.lblsymptoms.TabIndex = 71;
            this.lblsymptoms.Text = "SYMPTOMS:";
            // 
            // txtreffered
            // 
            this.txtreffered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtreffered.Location = new System.Drawing.Point(27, 341);
            this.txtreffered.Multiline = true;
            this.txtreffered.Name = "txtreffered";
            this.txtreffered.Size = new System.Drawing.Size(994, 86);
            this.txtreffered.TabIndex = 70;
            // 
            // lblrefferef
            // 
            this.lblrefferef.AutoSize = true;
            this.lblrefferef.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblrefferef.Location = new System.Drawing.Point(31, 317);
            this.lblrefferef.Name = "lblrefferef";
            this.lblrefferef.Size = new System.Drawing.Size(181, 21);
            this.lblrefferef.TabIndex = 69;
            this.lblrefferef.Text = "REASON FOR REFERRAL";
            // 
            // txtpdiagnosis
            // 
            this.txtpdiagnosis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpdiagnosis.Location = new System.Drawing.Point(27, 222);
            this.txtpdiagnosis.Multiline = true;
            this.txtpdiagnosis.Name = "txtpdiagnosis";
            this.txtpdiagnosis.Size = new System.Drawing.Size(994, 86);
            this.txtpdiagnosis.TabIndex = 68;
            // 
            // lblprimarydiagnosis
            // 
            this.lblprimarydiagnosis.AutoSize = true;
            this.lblprimarydiagnosis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblprimarydiagnosis.Location = new System.Drawing.Point(31, 198);
            this.lblprimarydiagnosis.Name = "lblprimarydiagnosis";
            this.lblprimarydiagnosis.Size = new System.Drawing.Size(162, 21);
            this.lblprimarydiagnosis.TabIndex = 67;
            this.lblprimarydiagnosis.Text = "PRIMARY DIAGNOSIS";
            // 
            // btprint
            // 
            this.btprint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btprint.Location = new System.Drawing.Point(514, 752);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(110, 46);
            this.btprint.TabIndex = 101;
            this.btprint.Text = "Print";
            this.btprint.UseVisualStyleBackColor = true;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // referral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.btprint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvAssignedPatients);
            this.Controls.Add(this.btnclear);
            this.Name = "referral";
            this.Size = new System.Drawing.Size(1174, 868);
            this.Load += new System.EventHandler(this.referral_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.DateTimePicker dpbirthdate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.DataGridView dgvAssignedPatients;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtreffered;
        private System.Windows.Forms.Label lblrefferef;
        private System.Windows.Forms.TextBox txtpdiagnosis;
        private System.Windows.Forms.Label lblprimarydiagnosis;
        private System.Windows.Forms.DateTimePicker dtpvisitdate;
        private System.Windows.Forms.Label lblvisitdate;
        private System.Windows.Forms.TextBox txtsymptoms;
        private System.Windows.Forms.Label lblsymptoms;
        private System.Windows.Forms.TextBox txtreffereddoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtspecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
