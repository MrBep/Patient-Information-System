namespace Patient_Information_System
{
    partial class frmlogin
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(426, 128);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(81, 21);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(426, 191);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(76, 21);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(429, 154);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(215, 29);
            this.tbusername.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(429, 225);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(215, 29);
            this.tbpassword.TabIndex = 3;
            // 
            // cbshow
            // 
            this.cbshow.AutoSize = true;
            this.cbshow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshow.Location = new System.Drawing.Point(430, 266);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(138, 25);
            this.cbshow.TabIndex = 4;
            this.cbshow.Text = "Show Password";
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.cbshow_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(453, 321);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(172, 42);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Patient_Information_System.Properties.Resources.Kwin_Creation_2__1__removebg_preview1;
            this.label1.Location = new System.Drawing.Point(159, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 150);
            this.label1.TabIndex = 6;
            // 
            // lblmin
            // 
            this.lblmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmin.Location = new System.Drawing.Point(674, -1);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(60, 26);
            this.lblmin.TabIndex = 23;
            this.lblmin.Text = "---";
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            this.lblexit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblexit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblexit.Location = new System.Drawing.Point(740, -1);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(60, 26);
            this.lblexit.TabIndex = 77;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.CheckBox cbshow;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
    }
}

