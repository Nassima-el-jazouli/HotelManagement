namespace HotelManagement.Forms
{
    partial class UpdateEmployee
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new HotelManagement.Tools.RoundedButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.roundedButton2 = new HotelManagement.Tools.RoundedButton();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(257, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Employee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(423, 320);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(355, 28);
            this.cmbRole.TabIndex = 32;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPrenom.Location = new System.Drawing.Point(62, 134);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(355, 32);
            this.txtPrenom.TabIndex = 30;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(423, 134);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(355, 32);
            this.txtNom.TabIndex = 31;
            this.txtNom.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(423, 375);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(172, 50);
            this.roundedButton1.TabIndex = 28;
            this.roundedButton1.Text = "Save";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(822, 89);
            this.panelTitleBar.TabIndex = 27;
            // 
            // txtCin
            // 
            this.txtCin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCin.Location = new System.Drawing.Point(62, 190);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(355, 32);
            this.txtCin.TabIndex = 34;
            this.txtCin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAdresse.Location = new System.Drawing.Point(423, 190);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(355, 32);
            this.txtAdresse.TabIndex = 35;
            this.txtAdresse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNumTel
            // 
            this.txtNumTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumTel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNumTel.Location = new System.Drawing.Point(62, 259);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(355, 32);
            this.txtNumTel.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(423, 259);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(355, 32);
            this.txtUsername.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(62, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 32);
            this.txtEmail.TabIndex = 38;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.roundedButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.roundedButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton2.BorderRadius = 10;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(240, 375);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(177, 50);
            this.roundedButton2.TabIndex = 23;
            this.roundedButton2.Text = "Cancel";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(822, 437);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panelTitleBar);
            this.MaximumSize = new System.Drawing.Size(840, 484);
            this.MinimumSize = new System.Drawing.Size(840, 484);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbRole;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private Tools.RoundedButton roundedButton1;
        private Panel panelTitleBar;
        private TextBox txtCin;
        private TextBox txtAdresse;
        private TextBox txtNumTel;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Tools.RoundedButton roundedButton2;
    }
}