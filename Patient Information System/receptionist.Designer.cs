﻿namespace Patient_Information_System
{
    partial class frmreceptionist
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
            this.btnassign = new System.Windows.Forms.Button();
            this.btnpatient = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblreceptionist = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.btnlistofpatienttobefollowup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientUser1 = new Patient_Information_System.patientUser();
            this.assignedToDoctor1 = new Patient_Information_System.assignedToDoctor();
            this.listFollow1 = new Patient_Information_System.listFollow();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlistofpatienttobefollowup);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnassign);
            this.panel1.Controls.Add(this.btnpatient);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblreceptionist);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 882);
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
            // btnassign
            // 
            this.btnassign.FlatAppearance.BorderSize = 0;
            this.btnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassign.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnassign.Location = new System.Drawing.Point(3, 437);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(223, 57);
            this.btnassign.TabIndex = 19;
            this.btnassign.Text = "ASSIGN TO DOCTOR";
            this.btnassign.UseVisualStyleBackColor = true;
            this.btnassign.Click += new System.EventHandler(this.btnassign_Click);
            // 
            // btnpatient
            // 
            this.btnpatient.FlatAppearance.BorderSize = 0;
            this.btnpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnpatient.Location = new System.Drawing.Point(3, 346);
            this.btnpatient.Name = "btnpatient";
            this.btnpatient.Size = new System.Drawing.Size(223, 57);
            this.btnpatient.TabIndex = 18;
            this.btnpatient.Text = "PATIENT";
            this.btnpatient.UseVisualStyleBackColor = true;
            this.btnpatient.Click += new System.EventHandler(this.btnpatient_Click);
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
            // lblreceptionist
            // 
            this.lblreceptionist.AutoSize = true;
            this.lblreceptionist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceptionist.Location = new System.Drawing.Point(12, 172);
            this.lblreceptionist.Name = "lblreceptionist";
            this.lblreceptionist.Size = new System.Drawing.Size(95, 21);
            this.lblreceptionist.TabIndex = 14;
            this.lblreceptionist.Text = "Receptionist";
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
            // lblexit
            // 
            this.lblexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblexit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblexit.Location = new System.Drawing.Point(1323, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(60, 26);
            this.lblexit.TabIndex = 4;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // lblmin
            // 
            this.lblmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmin.Location = new System.Drawing.Point(1257, 0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(60, 26);
            this.lblmin.TabIndex = 5;
            this.lblmin.Text = "---";
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // btnlistofpatienttobefollowup
            // 
            this.btnlistofpatienttobefollowup.FlatAppearance.BorderSize = 0;
            this.btnlistofpatienttobefollowup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistofpatienttobefollowup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnlistofpatienttobefollowup.Location = new System.Drawing.Point(3, 528);
            this.btnlistofpatienttobefollowup.Name = "btnlistofpatienttobefollowup";
            this.btnlistofpatienttobefollowup.Size = new System.Drawing.Size(223, 57);
            this.btnlistofpatienttobefollowup.TabIndex = 22;
            this.btnlistofpatienttobefollowup.Text = "FOLLOW-UP PATIENT LIST";
            this.btnlistofpatienttobefollowup.UseVisualStyleBackColor = true;
            this.btnlistofpatienttobefollowup.Click += new System.EventHandler(this.btnlistofpatienttobefollowup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Patient_Information_System.Properties.Resources.cherryblossom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // patientUser1
            // 
            this.patientUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.patientUser1.Location = new System.Drawing.Point(232, 3);
            this.patientUser1.Name = "patientUser1";
            this.patientUser1.Size = new System.Drawing.Size(1151, 882);
            this.patientUser1.TabIndex = 2;
            // 
            // assignedToDoctor1
            // 
            this.assignedToDoctor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.assignedToDoctor1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignedToDoctor1.Location = new System.Drawing.Point(232, 0);
            this.assignedToDoctor1.Name = "assignedToDoctor1";
            this.assignedToDoctor1.Size = new System.Drawing.Size(1151, 882);
            this.assignedToDoctor1.TabIndex = 6;
            // 
            // listFollow1
            // 
            this.listFollow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.listFollow1.Location = new System.Drawing.Point(232, 0);
            this.listFollow1.Name = "listFollow1";
            this.listFollow1.Size = new System.Drawing.Size(1151, 882);
            this.listFollow1.TabIndex = 7;
            // 
            // frmreceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1382, 882);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientUser1);
            this.Controls.Add(this.assignedToDoctor1);
            this.Controls.Add(this.listFollow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receptionist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnassign;
        private System.Windows.Forms.Button btnpatient;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblreceptionist;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private patientUser patientUser1;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblmin;
        private assignedToDoctor assignedToDoctor1;
        private System.Windows.Forms.Button btnlistofpatienttobefollowup;
        private listFollow listFollow1;
    }
}