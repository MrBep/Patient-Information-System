namespace Patient_Information_System
{
    partial class assignedToDoctor
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
            this.columnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.dtgwlistpatient = new System.Windows.Forms.DataGridView();
            this.columnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnmiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnbirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columncpnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columngender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnassignTOdr = new System.Windows.Forms.Button();
            this.txtconcern = new System.Windows.Forms.TextBox();
            this.txtcpnum = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblconcern = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblcellphone = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lbltemperature = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.lblheight = new System.Windows.Forms.Label();
            this.txtbp = new System.Windows.Forms.TextBox();
            this.lblbloodpressure = new System.Windows.Forms.Label();
            this.dpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lbllist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistpatient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnlastname
            // 
            this.columnlastname.HeaderText = "Last Name";
            this.columnlastname.Name = "columnlastname";
            this.columnlastname.Width = 145;
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtgender.Location = new System.Drawing.Point(673, 138);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(213, 29);
            this.txtgender.TabIndex = 28;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblgender.Location = new System.Drawing.Point(669, 114);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 27;
            this.lblgender.Text = "Gender";
            // 
            // dtgwlistpatient
            // 
            this.dtgwlistpatient.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgwlistpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwlistpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnpatientid,
            this.columnlastname,
            this.columnfirstname,
            this.columnmiddlename,
            this.columnbirthdate,
            this.columncpnum,
            this.columngender});
            this.dtgwlistpatient.Location = new System.Drawing.Point(37, 97);
            this.dtgwlistpatient.Name = "dtgwlistpatient";
            this.dtgwlistpatient.Size = new System.Drawing.Size(1054, 220);
            this.dtgwlistpatient.TabIndex = 55;
            this.dtgwlistpatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwlistpatient_CellClick);
            // 
            // columnpatientid
            // 
            this.columnpatientid.HeaderText = "Patient ID";
            this.columnpatientid.Name = "columnpatientid";
            this.columnpatientid.Width = 145;
            // 
            // columnfirstname
            // 
            this.columnfirstname.HeaderText = "First Name";
            this.columnfirstname.Name = "columnfirstname";
            this.columnfirstname.Width = 145;
            // 
            // columnmiddlename
            // 
            this.columnmiddlename.HeaderText = "Middle Name";
            this.columnmiddlename.Name = "columnmiddlename";
            this.columnmiddlename.Width = 145;
            // 
            // columnbirthdate
            // 
            this.columnbirthdate.HeaderText = "Birth Date";
            this.columnbirthdate.Name = "columnbirthdate";
            this.columnbirthdate.Width = 145;
            // 
            // columncpnum
            // 
            this.columncpnum.HeaderText = "Cellphone Number";
            this.columncpnum.Name = "columncpnum";
            this.columncpnum.Width = 145;
            // 
            // columngender
            // 
            this.columngender.HeaderText = "Gender";
            this.columngender.Name = "columngender";
            this.columngender.Width = 145;
            // 
            // btnassignTOdr
            // 
            this.btnassignTOdr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnassignTOdr.Location = new System.Drawing.Point(466, 459);
            this.btnassignTOdr.Name = "btnassignTOdr";
            this.btnassignTOdr.Size = new System.Drawing.Size(110, 46);
            this.btnassignTOdr.TabIndex = 23;
            this.btnassignTOdr.Text = "Assign";
            this.btnassignTOdr.UseVisualStyleBackColor = true;
            this.btnassignTOdr.Click += new System.EventHandler(this.btnassignTOdr_Click);
            // 
            // txtconcern
            // 
            this.txtconcern.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtconcern.Location = new System.Drawing.Point(153, 337);
            this.txtconcern.Multiline = true;
            this.txtconcern.Name = "txtconcern";
            this.txtconcern.Size = new System.Drawing.Size(733, 88);
            this.txtconcern.TabIndex = 18;
            // 
            // txtcpnum
            // 
            this.txtcpnum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcpnum.Location = new System.Drawing.Point(416, 138);
            this.txtcpnum.Name = "txtcpnum";
            this.txtcpnum.ReadOnly = true;
            this.txtcpnum.Size = new System.Drawing.Size(213, 29);
            this.txtcpnum.TabIndex = 15;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(419, 65);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 58;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblconcern
            // 
            this.lblconcern.AutoSize = true;
            this.lblconcern.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblconcern.Location = new System.Drawing.Point(153, 313);
            this.lblconcern.Name = "lblconcern";
            this.lblconcern.Size = new System.Drawing.Size(68, 21);
            this.lblconcern.TabIndex = 17;
            this.lblconcern.Text = "Concern";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(356, 73);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 57;
            this.lblsearch.Text = "Search";
            // 
            // lblcellphone
            // 
            this.lblcellphone.AutoSize = true;
            this.lblcellphone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcellphone.Location = new System.Drawing.Point(416, 114);
            this.lblcellphone.Name = "lblcellphone";
            this.lblcellphone.Size = new System.Drawing.Size(142, 21);
            this.lblcellphone.TabIndex = 14;
            this.lblcellphone.Text = "Cellphone Number";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbirthdate.Location = new System.Drawing.Point(153, 114);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(79, 21);
            this.lblbirthdate.TabIndex = 10;
            this.lblbirthdate.Text = "Birth Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblcel);
            this.panel1.Controls.Add(this.txttemp);
            this.panel1.Controls.Add(this.txtweight);
            this.panel1.Controls.Add(this.lblweight);
            this.panel1.Controls.Add(this.lbltemperature);
            this.panel1.Controls.Add(this.txtheight);
            this.panel1.Controls.Add(this.lblheight);
            this.panel1.Controls.Add(this.txtbp);
            this.panel1.Controls.Add(this.lblbloodpressure);
            this.panel1.Controls.Add(this.txtgender);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.btnassignTOdr);
            this.panel1.Controls.Add(this.txtconcern);
            this.panel1.Controls.Add(this.lblconcern);
            this.panel1.Controls.Add(this.txtcpnum);
            this.panel1.Controls.Add(this.lblcellphone);
            this.panel1.Controls.Add(this.dpbirthdate);
            this.panel1.Controls.Add(this.lblbirthdate);
            this.panel1.Controls.Add(this.txtmiddlename);
            this.panel1.Controls.Add(this.lblmiddlename);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Location = new System.Drawing.Point(38, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 526);
            this.panel1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(736, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(736, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "cm";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcel.Location = new System.Drawing.Point(430, 262);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(26, 21);
            this.lblcel.TabIndex = 38;
            this.lblcel.Text = "°C";
            // 
            // txttemp
            // 
            this.txttemp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txttemp.Location = new System.Drawing.Point(320, 256);
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(104, 29);
            this.txttemp.TabIndex = 37;
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtweight.Location = new System.Drawing.Point(626, 259);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(104, 29);
            this.txtweight.TabIndex = 36;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweight.Location = new System.Drawing.Point(561, 259);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(59, 21);
            this.lblweight.TabIndex = 35;
            this.lblweight.Text = "Weight";
            // 
            // lbltemperature
            // 
            this.lbltemperature.AutoSize = true;
            this.lbltemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltemperature.Location = new System.Drawing.Point(206, 256);
            this.lbltemperature.Name = "lbltemperature";
            this.lbltemperature.Size = new System.Drawing.Size(97, 21);
            this.lbltemperature.TabIndex = 33;
            this.lbltemperature.Text = "Temperature";
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtheight.Location = new System.Drawing.Point(626, 196);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(104, 29);
            this.txtheight.TabIndex = 32;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblheight.Location = new System.Drawing.Point(561, 199);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(56, 21);
            this.lblheight.TabIndex = 31;
            this.lblheight.Text = "Height";
            // 
            // txtbp
            // 
            this.txtbp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbp.Location = new System.Drawing.Point(320, 199);
            this.txtbp.Name = "txtbp";
            this.txtbp.Size = new System.Drawing.Size(104, 29);
            this.txtbp.TabIndex = 30;
            // 
            // lblbloodpressure
            // 
            this.lblbloodpressure.AutoSize = true;
            this.lblbloodpressure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbloodpressure.Location = new System.Drawing.Point(204, 202);
            this.lblbloodpressure.Name = "lblbloodpressure";
            this.lblbloodpressure.Size = new System.Drawing.Size(110, 21);
            this.lblbloodpressure.TabIndex = 29;
            this.lblbloodpressure.Text = "BloodPressure";
            // 
            // dpbirthdate
            // 
            this.dpbirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.CustomFormat = " MMMM dd, yyyy";
            this.dpbirthdate.Enabled = false;
            this.dpbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpbirthdate.Location = new System.Drawing.Point(153, 138);
            this.dpbirthdate.Name = "dpbirthdate";
            this.dpbirthdate.Size = new System.Drawing.Size(210, 29);
            this.dpbirthdate.TabIndex = 11;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmiddlename.Location = new System.Drawing.Point(673, 76);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.ReadOnly = true;
            this.txtmiddlename.Size = new System.Drawing.Size(213, 29);
            this.txtmiddlename.TabIndex = 9;
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmiddlename.Location = new System.Drawing.Point(669, 52);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(104, 21);
            this.lblmiddlename.TabIndex = 8;
            this.lblmiddlename.Text = "Middle Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtfirstname.Location = new System.Drawing.Point(416, 76);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.Size = new System.Drawing.Size(213, 29);
            this.txtfirstname.TabIndex = 7;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblfirstname.Location = new System.Drawing.Point(416, 52);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 21);
            this.lblfirstname.TabIndex = 6;
            this.lblfirstname.Text = "First Name";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtlastname.Location = new System.Drawing.Point(153, 76);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(213, 29);
            this.txtlastname.TabIndex = 5;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllastname.Location = new System.Drawing.Point(153, 52);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 21);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name";
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(33, 73);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(103, 21);
            this.lbllist.TabIndex = 56;
            this.lbllist.Text = "List of Patient";
            // 
            // assignedToDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.dtgwlistpatient);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbllist);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "assignedToDoctor";
            this.Size = new System.Drawing.Size(1174, 873);
            this.Load += new System.EventHandler(this.assignedToDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistpatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn columnlastname;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.DataGridView dtgwlistpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnmiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnbirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columncpnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columngender;
        private System.Windows.Forms.Button btnassignTOdr;
        private System.Windows.Forms.TextBox txtconcern;
        private System.Windows.Forms.TextBox txtcpnum;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblconcern;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblcellphone;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dpbirthdate;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lbltemperature;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox txtbp;
        private System.Windows.Forms.Label lblbloodpressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcel;
    }
}
