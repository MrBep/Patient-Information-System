namespace Patient_Information_System
{
    partial class frmdoctormedHistory
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
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnreferral = new System.Windows.Forms.Button();
            this.btnmedhistory = new System.Windows.Forms.Button();
            this.btnassigned = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicalhistoryUser1 = new Patient_Information_System.medicalhistoryUser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmin
            // 
            this.lblmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmin.Location = new System.Drawing.Point(1272, -2);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(60, 26);
            this.lblmin.TabIndex = 6;
            this.lblmin.Text = "---";
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            this.lblexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblexit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblexit.Location = new System.Drawing.Point(1338, -2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(60, 26);
            this.lblexit.TabIndex = 7;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
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
            this.panel1.TabIndex = 8;
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
            // medicalhistoryUser1
            // 
            this.medicalhistoryUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.medicalhistoryUser1.Location = new System.Drawing.Point(232, 0);
            this.medicalhistoryUser1.Name = "medicalhistoryUser1";
            this.medicalhistoryUser1.Size = new System.Drawing.Size(1166, 957);
            this.medicalhistoryUser1.TabIndex = 9;
            // 
            // frmdoctormedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1398, 921);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.medicalhistoryUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdoctormedHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctormedHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreferral;
        private System.Windows.Forms.Button btnmedhistory;
        private System.Windows.Forms.Button btnassigned;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private medicalhistoryUser medicalhistoryUser1;
    }
}