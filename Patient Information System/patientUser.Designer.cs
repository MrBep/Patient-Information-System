namespace Patient_Information_System
{
    partial class patientUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.gbgender = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtcpnum = new System.Windows.Forms.TextBox();
            this.lblcellphone = new System.Windows.Forms.Label();
            this.dpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lbllist = new System.Windows.Forms.Label();
            this.dtgwlistpatient = new System.Windows.Forms.DataGridView();
            this.columnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnmiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnbirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columncpnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columngender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistpatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.gbgender);
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
            this.panel1.Location = new System.Drawing.Point(39, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 526);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "ADD PATIENT";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndelete.Location = new System.Drawing.Point(549, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 46);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.Location = new System.Drawing.Point(711, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 46);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnedit.Location = new System.Drawing.Point(382, 414);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(110, 46);
            this.btnedit.TabIndex = 24;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsave.Location = new System.Drawing.Point(212, 414);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 46);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtaddress.Location = new System.Drawing.Point(143, 266);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(733, 88);
            this.txtaddress.TabIndex = 18;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbladdress.Location = new System.Drawing.Point(143, 242);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 21);
            this.lbladdress.TabIndex = 17;
            this.lbladdress.Text = "Address";
            // 
            // gbgender
            // 
            this.gbgender.Controls.Add(this.rbfemale);
            this.gbgender.Controls.Add(this.rbmale);
            this.gbgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbgender.Location = new System.Drawing.Point(650, 163);
            this.gbgender.Name = "gbgender";
            this.gbgender.Size = new System.Drawing.Size(226, 68);
            this.gbgender.TabIndex = 16;
            this.gbgender.TabStop = false;
            this.gbgender.Text = "Gender";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(95, 39);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(78, 25);
            this.rbfemale.TabIndex = 18;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rbmale.Location = new System.Drawing.Point(13, 39);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(62, 25);
            this.rbmale.TabIndex = 17;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtcpnum
            // 
            this.txtcpnum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcpnum.Location = new System.Drawing.Point(406, 182);
            this.txtcpnum.Name = "txtcpnum";
            this.txtcpnum.Size = new System.Drawing.Size(213, 29);
            this.txtcpnum.TabIndex = 15;
            // 
            // lblcellphone
            // 
            this.lblcellphone.AutoSize = true;
            this.lblcellphone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcellphone.Location = new System.Drawing.Point(406, 158);
            this.lblcellphone.Name = "lblcellphone";
            this.lblcellphone.Size = new System.Drawing.Size(142, 21);
            this.lblcellphone.TabIndex = 14;
            this.lblcellphone.Text = "Cellphone Number";
            // 
            // dpbirthdate
            // 
            this.dpbirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.CustomFormat = " MMMM dd, yyyy";
            this.dpbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpbirthdate.Location = new System.Drawing.Point(143, 182);
            this.dpbirthdate.Name = "dpbirthdate";
            this.dpbirthdate.Size = new System.Drawing.Size(210, 29);
            this.dpbirthdate.TabIndex = 11;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbirthdate.Location = new System.Drawing.Point(143, 158);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(79, 21);
            this.lblbirthdate.TabIndex = 10;
            this.lblbirthdate.Text = "Birth Date";
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmiddlename.Location = new System.Drawing.Point(663, 120);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(213, 29);
            this.txtmiddlename.TabIndex = 9;
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmiddlename.Location = new System.Drawing.Point(659, 96);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(104, 21);
            this.lblmiddlename.TabIndex = 8;
            this.lblmiddlename.Text = "Middle Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtfirstname.Location = new System.Drawing.Point(406, 120);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(213, 29);
            this.txtfirstname.TabIndex = 7;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblfirstname.Location = new System.Drawing.Point(406, 96);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 21);
            this.lblfirstname.TabIndex = 6;
            this.lblfirstname.Text = "First Name";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtlastname.Location = new System.Drawing.Point(143, 120);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(213, 29);
            this.txtlastname.TabIndex = 5;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllastname.Location = new System.Drawing.Point(143, 96);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 21);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(420, 66);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 30;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(357, 74);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 29;
            this.lblsearch.Text = "Search";
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(34, 74);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(103, 21);
            this.lbllist.TabIndex = 28;
            this.lbllist.Text = "List of Patient";
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
            this.columngender,
            this.columnaddress});
            this.dtgwlistpatient.Location = new System.Drawing.Point(38, 98);
            this.dtgwlistpatient.Name = "dtgwlistpatient";
            this.dtgwlistpatient.Size = new System.Drawing.Size(1054, 220);
            this.dtgwlistpatient.TabIndex = 27;
            // 
            // columnpatientid
            // 
            this.columnpatientid.HeaderText = "Patient ID";
            this.columnpatientid.Name = "columnpatientid";
            this.columnpatientid.Width = 134;
            // 
            // columnlastname
            // 
            this.columnlastname.HeaderText = "Last Name";
            this.columnlastname.Name = "columnlastname";
            this.columnlastname.Width = 134;
            // 
            // columnfirstname
            // 
            this.columnfirstname.HeaderText = "First Name";
            this.columnfirstname.Name = "columnfirstname";
            this.columnfirstname.Width = 134;
            // 
            // columnmiddlename
            // 
            this.columnmiddlename.HeaderText = "Middle Name";
            this.columnmiddlename.Name = "columnmiddlename";
            this.columnmiddlename.Width = 134;
            // 
            // columnbirthdate
            // 
            this.columnbirthdate.HeaderText = "Birth Date";
            this.columnbirthdate.Name = "columnbirthdate";
            this.columnbirthdate.Width = 134;
            // 
            // columncpnum
            // 
            this.columncpnum.HeaderText = "Cellphone Number";
            this.columncpnum.Name = "columncpnum";
            this.columncpnum.Width = 134;
            // 
            // columngender
            // 
            this.columngender.HeaderText = "Gender";
            this.columngender.Name = "columngender";
            this.columngender.Width = 134;
            // 
            // columnaddress
            // 
            this.columnaddress.HeaderText = "Address";
            this.columnaddress.Name = "columnaddress";
            this.columnaddress.Width = 134;
            // 
            // patientUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.dtgwlistpatient);
            this.Name = "patientUser";
            this.Size = new System.Drawing.Size(1174, 873);
            this.Load += new System.EventHandler(this.patientUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbgender.ResumeLayout(false);
            this.gbgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwlistpatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.GroupBox gbgender;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.TextBox txtcpnum;
        private System.Windows.Forms.Label lblcellphone;
        private System.Windows.Forms.DateTimePicker dpbirthdate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.DataGridView dtgwlistpatient;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnmiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnbirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columncpnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columngender;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaddress;
        private System.Windows.Forms.Label label1;
    }
}
