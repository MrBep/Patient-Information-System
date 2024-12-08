namespace Patient_Information_System
{
    partial class frmdoctor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnreferral = new System.Windows.Forms.Button();
            this.btnmedhistory = new System.Windows.Forms.Button();
            this.btnassigned = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfollow = new System.Windows.Forms.DateTimePicker();
            this.cbfollow = new System.Windows.Forms.CheckBox();
            this.txtprescriptions = new System.Windows.Forms.TextBox();
            this.lblprescription = new System.Windows.Forms.Label();
            this.txtdiagnosis = new System.Windows.Forms.TextBox();
            this.lbldiagnosis = new System.Windows.Forms.Label();
            this.txtsymptoms = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbno = new System.Windows.Forms.CheckBox();
            this.cbyes = new System.Windows.Forms.CheckBox();
            this.txttypeofmedication = new System.Windows.Forms.TextBox();
            this.lblquestion1 = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.lblsymptoms = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmedicine = new System.Windows.Forms.TextBox();
            this.lblmedicine = new System.Windows.Forms.Label();
            this.txtAfood = new System.Windows.Forms.TextBox();
            this.lblfood = new System.Windows.Forms.Label();
            this.txtallergies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbfamilyhistory = new System.Windows.Forms.GroupBox();
            this.txtfamilyhistory = new System.Windows.Forms.TextBox();
            this.gbmedicalhistory = new System.Windows.Forms.GroupBox();
            this.txtmedicalhistory = new System.Windows.Forms.TextBox();
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
            this.txtconcern = new System.Windows.Forms.TextBox();
            this.lblconcern = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.dgvAssignedPatients = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtcpnum = new System.Windows.Forms.TextBox();
            this.lblcellphone = new System.Windows.Forms.Label();
            this.dpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbfamilyhistory.SuspendLayout();
            this.gbmedicalhistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnreferral);
            this.panel1.Controls.Add(this.btnmedhistory);
            this.panel1.Controls.Add(this.btnassigned);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lbldoctor);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 921);
            this.panel1.TabIndex = 1;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnlogout.Location = new System.Drawing.Point(3, 662);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(223, 57);
            this.btnlogout.TabIndex = 21;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnreferral
            // 
            this.btnreferral.FlatAppearance.BorderSize = 0;
            this.btnreferral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreferral.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnreferral.Location = new System.Drawing.Point(3, 516);
            this.btnreferral.Name = "btnreferral";
            this.btnreferral.Size = new System.Drawing.Size(223, 57);
            this.btnreferral.TabIndex = 20;
            this.btnreferral.Text = "REFERRAL";
            this.btnreferral.UseVisualStyleBackColor = true;
            this.btnreferral.Click += new System.EventHandler(this.btnreferral_Click);
            // 
            // btnmedhistory
            // 
            this.btnmedhistory.FlatAppearance.BorderSize = 0;
            this.btnmedhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedhistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmedhistory.Location = new System.Drawing.Point(3, 413);
            this.btnmedhistory.Name = "btnmedhistory";
            this.btnmedhistory.Size = new System.Drawing.Size(223, 57);
            this.btnmedhistory.TabIndex = 19;
            this.btnmedhistory.Text = "MEDICAL HISTORY";
            this.btnmedhistory.UseVisualStyleBackColor = true;
            this.btnmedhistory.Click += new System.EventHandler(this.btnmedhistory_Click);
            // 
            // btnassigned
            // 
            this.btnassigned.FlatAppearance.BorderSize = 0;
            this.btnassigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassigned.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnassigned.Location = new System.Drawing.Point(3, 322);
            this.btnassigned.Name = "btnassigned";
            this.btnassigned.Size = new System.Drawing.Size(223, 57);
            this.btnassigned.TabIndex = 18;
            this.btnassigned.Text = "ASSIGNED PATIENT";
            this.btnassigned.UseVisualStyleBackColor = true;
            this.btnassigned.Click += new System.EventHandler(this.btnassigned_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(120, 172);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 21);
            this.lblname.TabIndex = 15;
            this.lblname.Text = "Name";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.Location = new System.Drawing.Point(45, 172);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(57, 21);
            this.lbldoctor.TabIndex = 14;
            this.lbldoctor.Text = "Doctor";
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.Location = new System.Drawing.Point(90, 117);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(77, 32);
            this.lblhello.TabIndex = 1;
            this.lblhello.Text = "Hello!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Patient_Information_System.Properties.Resources.Spider_lily_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpfollow);
            this.panel2.Controls.Add(this.cbfollow);
            this.panel2.Controls.Add(this.txtprescriptions);
            this.panel2.Controls.Add(this.lblprescription);
            this.panel2.Controls.Add(this.txtdiagnosis);
            this.panel2.Controls.Add(this.lbldiagnosis);
            this.panel2.Controls.Add(this.txtsymptoms);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.lblsymptoms);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gbfamilyhistory);
            this.panel2.Controls.Add(this.gbmedicalhistory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblcel);
            this.panel2.Controls.Add(this.txttemp);
            this.panel2.Controls.Add(this.txtweight);
            this.panel2.Controls.Add(this.lblweight);
            this.panel2.Controls.Add(this.lbltemperature);
            this.panel2.Controls.Add(this.txtheight);
            this.panel2.Controls.Add(this.lblheight);
            this.panel2.Controls.Add(this.txtbp);
            this.panel2.Controls.Add(this.lblbloodpressure);
            this.panel2.Controls.Add(this.txtconcern);
            this.panel2.Controls.Add(this.lblconcern);
            this.panel2.Location = new System.Drawing.Point(281, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 598);
            this.panel2.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(511, 994);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 77;
            // 
            // dtpfollow
            // 
            this.dtpfollow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpfollow.Location = new System.Drawing.Point(228, 962);
            this.dtpfollow.Name = "dtpfollow";
            this.dtpfollow.Size = new System.Drawing.Size(277, 29);
            this.dtpfollow.TabIndex = 76;
            // 
            // cbfollow
            // 
            this.cbfollow.AutoSize = true;
            this.cbfollow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbfollow.Location = new System.Drawing.Point(33, 962);
            this.cbfollow.Name = "cbfollow";
            this.cbfollow.Size = new System.Drawing.Size(193, 25);
            this.cbfollow.TabIndex = 75;
            this.cbfollow.Text = "FOLLOW-UP CHECK UP";
            this.cbfollow.UseVisualStyleBackColor = true;
            this.cbfollow.CheckedChanged += new System.EventHandler(this.cbfollow_CheckedChanged);
            // 
            // txtprescriptions
            // 
            this.txtprescriptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtprescriptions.Location = new System.Drawing.Point(37, 827);
            this.txtprescriptions.Multiline = true;
            this.txtprescriptions.Name = "txtprescriptions";
            this.txtprescriptions.Size = new System.Drawing.Size(994, 128);
            this.txtprescriptions.TabIndex = 68;
            // 
            // lblprescription
            // 
            this.lblprescription.AutoSize = true;
            this.lblprescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblprescription.Location = new System.Drawing.Point(41, 803);
            this.lblprescription.Name = "lblprescription";
            this.lblprescription.Size = new System.Drawing.Size(118, 21);
            this.lblprescription.TabIndex = 67;
            this.lblprescription.Text = "PRESCRIPTION:";
            // 
            // txtdiagnosis
            // 
            this.txtdiagnosis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtdiagnosis.Location = new System.Drawing.Point(37, 657);
            this.txtdiagnosis.Multiline = true;
            this.txtdiagnosis.Name = "txtdiagnosis";
            this.txtdiagnosis.Size = new System.Drawing.Size(994, 128);
            this.txtdiagnosis.TabIndex = 66;
            // 
            // lbldiagnosis
            // 
            this.lbldiagnosis.AutoSize = true;
            this.lbldiagnosis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbldiagnosis.Location = new System.Drawing.Point(41, 633);
            this.lbldiagnosis.Name = "lbldiagnosis";
            this.lbldiagnosis.Size = new System.Drawing.Size(95, 21);
            this.lbldiagnosis.TabIndex = 65;
            this.lbldiagnosis.Text = "DIAGNOSIS:";
            // 
            // txtsymptoms
            // 
            this.txtsymptoms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsymptoms.Location = new System.Drawing.Point(37, 484);
            this.txtsymptoms.Multiline = true;
            this.txtsymptoms.Name = "txtsymptoms";
            this.txtsymptoms.Size = new System.Drawing.Size(994, 128);
            this.txtsymptoms.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbno);
            this.groupBox2.Controls.Add(this.cbyes);
            this.groupBox2.Controls.Add(this.txttypeofmedication);
            this.groupBox2.Controls.Add(this.lblquestion1);
            this.groupBox2.Controls.Add(this.lblquestion);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(542, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 219);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medication";
            // 
            // cbno
            // 
            this.cbno.AutoSize = true;
            this.cbno.Location = new System.Drawing.Point(378, 52);
            this.cbno.Name = "cbno";
            this.cbno.Size = new System.Drawing.Size(50, 25);
            this.cbno.TabIndex = 62;
            this.cbno.Text = "No";
            this.cbno.UseVisualStyleBackColor = true;
            // 
            // cbyes
            // 
            this.cbyes.AutoSize = true;
            this.cbyes.Location = new System.Drawing.Point(309, 52);
            this.cbyes.Name = "cbyes";
            this.cbyes.Size = new System.Drawing.Size(52, 25);
            this.cbyes.TabIndex = 61;
            this.cbyes.Text = "Yes";
            this.cbyes.UseVisualStyleBackColor = true;
            // 
            // txttypeofmedication
            // 
            this.txttypeofmedication.Location = new System.Drawing.Point(48, 117);
            this.txttypeofmedication.Multiline = true;
            this.txttypeofmedication.Name = "txttypeofmedication";
            this.txttypeofmedication.Size = new System.Drawing.Size(380, 90);
            this.txttypeofmedication.TabIndex = 60;
            // 
            // lblquestion1
            // 
            this.lblquestion1.AutoSize = true;
            this.lblquestion1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblquestion1.Location = new System.Drawing.Point(44, 93);
            this.lblquestion1.Name = "lblquestion1";
            this.lblquestion1.Size = new System.Drawing.Size(166, 21);
            this.lblquestion1.TabIndex = 59;
            this.lblquestion1.Text = "What type of medicine";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblquestion.Location = new System.Drawing.Point(23, 52);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(281, 21);
            this.lblquestion.TabIndex = 56;
            this.lblquestion.Text = "Do you take any medication right now?";
            // 
            // lblsymptoms
            // 
            this.lblsymptoms.AutoSize = true;
            this.lblsymptoms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsymptoms.Location = new System.Drawing.Point(38, 460);
            this.lblsymptoms.Name = "lblsymptoms";
            this.lblsymptoms.Size = new System.Drawing.Size(96, 21);
            this.lblsymptoms.TabIndex = 63;
            this.lblsymptoms.Text = "SYMPTOMS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmedicine);
            this.groupBox1.Controls.Add(this.lblmedicine);
            this.groupBox1.Controls.Add(this.txtAfood);
            this.groupBox1.Controls.Add(this.lblfood);
            this.groupBox1.Controls.Add(this.txtallergies);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(34, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 219);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do you have any Allergies";
            // 
            // txtAmedicine
            // 
            this.txtAmedicine.Location = new System.Drawing.Point(148, 162);
            this.txtAmedicine.Multiline = true;
            this.txtAmedicine.Name = "txtAmedicine";
            this.txtAmedicine.Size = new System.Drawing.Size(290, 45);
            this.txtAmedicine.TabIndex = 60;
            // 
            // lblmedicine
            // 
            this.lblmedicine.AutoSize = true;
            this.lblmedicine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmedicine.Location = new System.Drawing.Point(23, 186);
            this.lblmedicine.Name = "lblmedicine";
            this.lblmedicine.Size = new System.Drawing.Size(73, 21);
            this.lblmedicine.TabIndex = 59;
            this.lblmedicine.Text = "Medicine";
            // 
            // txtAfood
            // 
            this.txtAfood.Location = new System.Drawing.Point(148, 93);
            this.txtAfood.Multiline = true;
            this.txtAfood.Name = "txtAfood";
            this.txtAfood.Size = new System.Drawing.Size(290, 45);
            this.txtAfood.TabIndex = 57;
            // 
            // lblfood
            // 
            this.lblfood.AutoSize = true;
            this.lblfood.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblfood.Location = new System.Drawing.Point(23, 117);
            this.lblfood.Name = "lblfood";
            this.lblfood.Size = new System.Drawing.Size(45, 21);
            this.lblfood.TabIndex = 58;
            this.lblfood.Text = "Food";
            // 
            // txtallergies
            // 
            this.txtallergies.Location = new System.Drawing.Point(148, 28);
            this.txtallergies.Multiline = true;
            this.txtallergies.Name = "txtallergies";
            this.txtallergies.Size = new System.Drawing.Size(290, 45);
            this.txtallergies.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Type of Allergies";
            // 
            // gbfamilyhistory
            // 
            this.gbfamilyhistory.Controls.Add(this.txtfamilyhistory);
            this.gbfamilyhistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbfamilyhistory.Location = new System.Drawing.Point(542, 114);
            this.gbfamilyhistory.Name = "gbfamilyhistory";
            this.gbfamilyhistory.Size = new System.Drawing.Size(484, 107);
            this.gbfamilyhistory.TabIndex = 55;
            this.gbfamilyhistory.TabStop = false;
            this.gbfamilyhistory.Text = "Family History";
            // 
            // txtfamilyhistory
            // 
            this.txtfamilyhistory.Location = new System.Drawing.Point(21, 41);
            this.txtfamilyhistory.Multiline = true;
            this.txtfamilyhistory.Name = "txtfamilyhistory";
            this.txtfamilyhistory.Size = new System.Drawing.Size(441, 45);
            this.txtfamilyhistory.TabIndex = 9;
            // 
            // gbmedicalhistory
            // 
            this.gbmedicalhistory.Controls.Add(this.txtmedicalhistory);
            this.gbmedicalhistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbmedicalhistory.Location = new System.Drawing.Point(36, 114);
            this.gbmedicalhistory.Name = "gbmedicalhistory";
            this.gbmedicalhistory.Size = new System.Drawing.Size(484, 107);
            this.gbmedicalhistory.TabIndex = 54;
            this.gbmedicalhistory.TabStop = false;
            this.gbmedicalhistory.Text = "Medical History";
            // 
            // txtmedicalhistory
            // 
            this.txtmedicalhistory.Location = new System.Drawing.Point(25, 41);
            this.txtmedicalhistory.Multiline = true;
            this.txtmedicalhistory.Name = "txtmedicalhistory";
            this.txtmedicalhistory.Size = new System.Drawing.Size(444, 45);
            this.txtmedicalhistory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(478, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(478, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "cm";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcel.Location = new System.Drawing.Point(256, 73);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(26, 21);
            this.lblcel.TabIndex = 51;
            this.lblcel.Text = "°C";
            // 
            // txttemp
            // 
            this.txttemp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txttemp.Location = new System.Drawing.Point(146, 67);
            this.txttemp.Name = "txttemp";
            this.txttemp.ReadOnly = true;
            this.txttemp.Size = new System.Drawing.Size(104, 29);
            this.txttemp.TabIndex = 50;
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtweight.Location = new System.Drawing.Point(368, 73);
            this.txtweight.Name = "txtweight";
            this.txtweight.ReadOnly = true;
            this.txtweight.Size = new System.Drawing.Size(104, 29);
            this.txtweight.TabIndex = 49;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweight.Location = new System.Drawing.Point(303, 73);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(59, 21);
            this.lblweight.TabIndex = 48;
            this.lblweight.Text = "Weight";
            // 
            // lbltemperature
            // 
            this.lbltemperature.AutoSize = true;
            this.lbltemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltemperature.Location = new System.Drawing.Point(32, 67);
            this.lbltemperature.Name = "lbltemperature";
            this.lbltemperature.Size = new System.Drawing.Size(97, 21);
            this.lbltemperature.TabIndex = 47;
            this.lbltemperature.Text = "Temperature";
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtheight.Location = new System.Drawing.Point(368, 10);
            this.txtheight.Name = "txtheight";
            this.txtheight.ReadOnly = true;
            this.txtheight.Size = new System.Drawing.Size(104, 29);
            this.txtheight.TabIndex = 46;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblheight.Location = new System.Drawing.Point(303, 13);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(56, 21);
            this.lblheight.TabIndex = 45;
            this.lblheight.Text = "Height";
            // 
            // txtbp
            // 
            this.txtbp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbp.Location = new System.Drawing.Point(146, 10);
            this.txtbp.Name = "txtbp";
            this.txtbp.ReadOnly = true;
            this.txtbp.Size = new System.Drawing.Size(104, 29);
            this.txtbp.TabIndex = 44;
            // 
            // lblbloodpressure
            // 
            this.lblbloodpressure.AutoSize = true;
            this.lblbloodpressure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbloodpressure.Location = new System.Drawing.Point(30, 13);
            this.lblbloodpressure.Name = "lblbloodpressure";
            this.lblbloodpressure.Size = new System.Drawing.Size(110, 21);
            this.lblbloodpressure.TabIndex = 43;
            this.lblbloodpressure.Text = "BloodPressure";
            // 
            // txtconcern
            // 
            this.txtconcern.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtconcern.Location = new System.Drawing.Point(557, 26);
            this.txtconcern.Multiline = true;
            this.txtconcern.Name = "txtconcern";
            this.txtconcern.ReadOnly = true;
            this.txtconcern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtconcern.Size = new System.Drawing.Size(474, 76);
            this.txtconcern.TabIndex = 42;
            // 
            // lblconcern
            // 
            this.lblconcern.AutoSize = true;
            this.lblconcern.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblconcern.Location = new System.Drawing.Point(559, 2);
            this.lblconcern.Name = "lblconcern";
            this.lblconcern.Size = new System.Drawing.Size(68, 21);
            this.lblconcern.TabIndex = 41;
            this.lblconcern.Text = "Concern";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsave.Location = new System.Drawing.Point(1077, 147);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 46);
            this.btnsave.TabIndex = 74;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.Location = new System.Drawing.Point(1202, 147);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 46);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllist.Location = new System.Drawing.Point(277, 34);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(170, 21);
            this.lbllist.TabIndex = 69;
            this.lbllist.Text = "List of Assigned Patient";
            // 
            // dgvAssignedPatients
            // 
            this.dgvAssignedPatients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAssignedPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedPatients.Location = new System.Drawing.Point(281, 58);
            this.dgvAssignedPatients.Name = "dgvAssignedPatients";
            this.dgvAssignedPatients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAssignedPatients.Size = new System.Drawing.Size(1054, 57);
            this.dgvAssignedPatients.TabIndex = 68;
            this.dgvAssignedPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedPatients_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtage);
            this.panel3.Controls.Add(this.lblage);
            this.panel3.Controls.Add(this.txtgender);
            this.panel3.Controls.Add(this.lblgender);
            this.panel3.Controls.Add(this.txtcpnum);
            this.panel3.Controls.Add(this.lblcellphone);
            this.panel3.Controls.Add(this.dpbirthdate);
            this.panel3.Controls.Add(this.lblbirthdate);
            this.panel3.Controls.Add(this.txtpname);
            this.panel3.Controls.Add(this.lblpname);
            this.panel3.Location = new System.Drawing.Point(281, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 105);
            this.panel3.TabIndex = 72;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtage.Location = new System.Drawing.Point(276, 41);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(93, 29);
            this.txtage.TabIndex = 55;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblage.Location = new System.Drawing.Point(272, 17);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 21);
            this.lblage.TabIndex = 54;
            this.lblage.Text = "Age";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtgender.Location = new System.Drawing.Point(882, 44);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(114, 29);
            this.txtgender.TabIndex = 28;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblgender.Location = new System.Drawing.Point(878, 20);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 27;
            this.lblgender.Text = "Gender";
            // 
            // txtcpnum
            // 
            this.txtcpnum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcpnum.Location = new System.Drawing.Point(635, 44);
            this.txtcpnum.Name = "txtcpnum";
            this.txtcpnum.ReadOnly = true;
            this.txtcpnum.Size = new System.Drawing.Size(213, 29);
            this.txtcpnum.TabIndex = 15;
            // 
            // lblcellphone
            // 
            this.lblcellphone.AutoSize = true;
            this.lblcellphone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcellphone.Location = new System.Drawing.Point(635, 20);
            this.lblcellphone.Name = "lblcellphone";
            this.lblcellphone.Size = new System.Drawing.Size(142, 21);
            this.lblcellphone.TabIndex = 14;
            this.lblcellphone.Text = "Cellphone Number";
            // 
            // dpbirthdate
            // 
            this.dpbirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.CustomFormat = " MMMM dd, yyyy";
            this.dpbirthdate.Enabled = false;
            this.dpbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpbirthdate.Location = new System.Drawing.Point(399, 41);
            this.dpbirthdate.Name = "dpbirthdate";
            this.dpbirthdate.Size = new System.Drawing.Size(210, 29);
            this.dpbirthdate.TabIndex = 11;
            this.dpbirthdate.ValueChanged += new System.EventHandler(this.dpbirthdate_ValueChanged);
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblbirthdate.Location = new System.Drawing.Point(399, 17);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(79, 21);
            this.lblbirthdate.TabIndex = 10;
            this.lblbirthdate.Text = "Birth Date";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpname.Location = new System.Drawing.Point(48, 41);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(213, 29);
            this.txtpname.TabIndex = 5;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblpname.Location = new System.Drawing.Point(48, 17);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(103, 21);
            this.lblpname.TabIndex = 4;
            this.lblpname.Text = "Patient Name";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearch.Location = new System.Drawing.Point(663, 26);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 29);
            this.txtsearch.TabIndex = 71;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.Location = new System.Drawing.Point(600, 34);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(57, 21);
            this.lblsearch.TabIndex = 70;
            this.lblsearch.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(277, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "Patient";
            // 
            // lblmin
            // 
            this.lblmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmin.Location = new System.Drawing.Point(1272, 0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(60, 26);
            this.lblmin.TabIndex = 22;
            this.lblmin.Text = "---";
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            this.lblexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblexit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblexit.Location = new System.Drawing.Point(1338, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(60, 26);
            this.lblexit.TabIndex = 76;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmdoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1398, 921);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvAssignedPatients);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOCTOR";
            this.Load += new System.EventHandler(this.frmdoctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbfamilyhistory.ResumeLayout(false);
            this.gbfamilyhistory.PerformLayout();
            this.gbmedicalhistory.ResumeLayout(false);
            this.gbmedicalhistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPatients)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreferral;
        private System.Windows.Forms.Button btnmedhistory;
        private System.Windows.Forms.Button btnassigned;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lbltemperature;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox txtbp;
        private System.Windows.Forms.Label lblbloodpressure;
        private System.Windows.Forms.TextBox txtconcern;
        private System.Windows.Forms.Label lblconcern;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.DataGridView dgvAssignedPatients;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtcpnum;
        private System.Windows.Forms.Label lblcellphone;
        private System.Windows.Forms.DateTimePicker dpbirthdate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.GroupBox gbfamilyhistory;
        private System.Windows.Forms.GroupBox gbmedicalhistory;
        private System.Windows.Forms.TextBox txtfamilyhistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmedicalhistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmedicine;
        private System.Windows.Forms.Label lblmedicine;
        private System.Windows.Forms.TextBox txtAfood;
        private System.Windows.Forms.Label lblfood;
        private System.Windows.Forms.TextBox txtallergies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbno;
        private System.Windows.Forms.CheckBox cbyes;
        private System.Windows.Forms.TextBox txttypeofmedication;
        private System.Windows.Forms.Label lblquestion1;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.TextBox txtprescriptions;
        private System.Windows.Forms.Label lblprescription;
        private System.Windows.Forms.TextBox txtdiagnosis;
        private System.Windows.Forms.Label lbldiagnosis;
        private System.Windows.Forms.TextBox txtsymptoms;
        private System.Windows.Forms.Label lblsymptoms;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox cbfollow;
        private System.Windows.Forms.DateTimePicker dtpfollow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
    }
}