namespace Patient_Information_System
{
    partial class frmbillingTransHistory
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
            this.btnmedhistory = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.transacHistory1 = new Patient_Information_System.TransacHistory();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnmedhistory);
            this.panel1.Controls.Add(this.btnbill);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lbldoctor);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 921);
            this.panel1.TabIndex = 3;
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
            // btnmedhistory
            // 
            this.btnmedhistory.FlatAppearance.BorderSize = 0;
            this.btnmedhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedhistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmedhistory.Location = new System.Drawing.Point(3, 413);
            this.btnmedhistory.Name = "btnmedhistory";
            this.btnmedhistory.Size = new System.Drawing.Size(223, 57);
            this.btnmedhistory.TabIndex = 19;
            this.btnmedhistory.Text = "TRANSACTION HISTORY";
            this.btnmedhistory.UseVisualStyleBackColor = true;
            this.btnmedhistory.Click += new System.EventHandler(this.btnmedhistory_Click);
            // 
            // btnbill
            // 
            this.btnbill.FlatAppearance.BorderSize = 0;
            this.btnbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnbill.Location = new System.Drawing.Point(3, 322);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(223, 57);
            this.btnbill.TabIndex = 18;
            this.btnbill.Text = "Billing";
            this.btnbill.UseVisualStyleBackColor = true;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
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
            this.lbldoctor.Size = new System.Drawing.Size(53, 21);
            this.lbldoctor.TabIndex = 14;
            this.lbldoctor.Text = "Billing";
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
            this.pictureBox1.BackgroundImage = global::Patient_Information_System.Properties.Resources.roseeee;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblexit
            // 
            this.lblexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblexit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblexit.Location = new System.Drawing.Point(1339, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(60, 26);
            this.lblexit.TabIndex = 22;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // lblmin
            // 
            this.lblmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmin.Location = new System.Drawing.Point(1273, 0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(60, 26);
            this.lblmin.TabIndex = 23;
            this.lblmin.Text = "---";
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // transacHistory1
            // 
            this.transacHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.transacHistory1.Location = new System.Drawing.Point(232, 0);
            this.transacHistory1.Name = "transacHistory1";
            this.transacHistory1.Size = new System.Drawing.Size(1167, 921);
            this.transacHistory1.TabIndex = 24;
            // 
            // frmbillingTransHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1398, 921);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transacHistory1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbillingTransHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billingTransHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmedhistory;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblmin;
        private TransacHistory transacHistory1;
    }
}