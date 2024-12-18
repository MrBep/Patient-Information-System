﻿namespace Patient_Information_System
{
    partial class frmadmin
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
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.staffUsercon1 = new Patient_Information_System.staffUsercon();
            this.doctorUser1 = new Patient_Information_System.doctorUser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btndoctor);
            this.panel1.Controls.Add(this.btnstaff);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lbladmin);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 921);
            this.panel1.TabIndex = 0;
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
            // btndoctor
            // 
            this.btndoctor.FlatAppearance.BorderSize = 0;
            this.btndoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoctor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndoctor.Location = new System.Drawing.Point(3, 473);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(223, 57);
            this.btndoctor.TabIndex = 20;
            this.btndoctor.Text = "DOCTOR";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.FlatAppearance.BorderSize = 0;
            this.btnstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnstaff.Location = new System.Drawing.Point(3, 370);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(223, 57);
            this.btnstaff.TabIndex = 19;
            this.btnstaff.Text = "STAFF";
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
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
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.Location = new System.Drawing.Point(45, 172);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(56, 21);
            this.lbladmin.TabIndex = 14;
            this.lbladmin.Text = "Admin";
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
            this.pictureBox1.BackgroundImage = global::Patient_Information_System.Properties.Resources.sunflower;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.lblexit.TabIndex = 23;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // staffUsercon1
            // 
            this.staffUsercon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.staffUsercon1.Location = new System.Drawing.Point(232, 0);
            this.staffUsercon1.Name = "staffUsercon1";
            this.staffUsercon1.Size = new System.Drawing.Size(1166, 921);
            this.staffUsercon1.TabIndex = 2;
            // 
            // doctorUser1
            // 
            this.doctorUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.doctorUser1.Location = new System.Drawing.Point(232, 0);
            this.doctorUser1.Name = "doctorUser1";
            this.doctorUser1.Size = new System.Drawing.Size(1166, 921);
            this.doctorUser1.TabIndex = 3;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1398, 921);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staffUsercon1);
            this.Controls.Add(this.doctorUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btndoctor;
        private staffUsercon staffUsercon1;
        private doctorUser doctorUser1;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
    }
}