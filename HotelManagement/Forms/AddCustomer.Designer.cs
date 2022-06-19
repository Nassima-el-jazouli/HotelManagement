namespace HotelManagement.Forms
{
    partial class AddCustomer
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.roundedButton2 = new HotelManagement.Tools.RoundedButton();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new HotelManagement.Tools.RoundedButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
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
            this.lblTitle.Size = new System.Drawing.Size(250, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Customer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(240, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "  Email";
            this.txtEmail.Size = new System.Drawing.Size(355, 32);
            this.txtEmail.TabIndex = 63;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodePostal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCodePostal.Location = new System.Drawing.Point(423, 287);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.PlaceholderText = "  CodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(355, 32);
            this.txtCodePostal.TabIndex = 62;
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
            this.roundedButton2.TabIndex = 52;
            this.roundedButton2.Text = "Cancel";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(62, 287);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "  City";
            this.txtCity.Size = new System.Drawing.Size(355, 32);
            this.txtCity.TabIndex = 61;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(423, 230);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "  Country";
            this.txtCountry.Size = new System.Drawing.Size(355, 32);
            this.txtCountry.TabIndex = 60;
            // 
            // txtNumTel
            // 
            this.txtNumTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumTel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNumTel.Location = new System.Drawing.Point(62, 230);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.PlaceholderText = "  Number Phone";
            this.txtNumTel.Size = new System.Drawing.Size(355, 32);
            this.txtNumTel.TabIndex = 59;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAdresse.Location = new System.Drawing.Point(423, 161);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PlaceholderText = "  Address";
            this.txtAdresse.Size = new System.Drawing.Size(355, 32);
            this.txtAdresse.TabIndex = 58;
            // 
            // txtCin
            // 
            this.txtCin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCin.Location = new System.Drawing.Point(62, 161);
            this.txtCin.Name = "txtCin";
            this.txtCin.PlaceholderText = "  CIN";
            this.txtCin.Size = new System.Drawing.Size(355, 32);
            this.txtCin.TabIndex = 57;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPrenom.Location = new System.Drawing.Point(62, 105);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PlaceholderText = "  First Name";
            this.txtPrenom.Size = new System.Drawing.Size(355, 32);
            this.txtPrenom.TabIndex = 55;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(423, 105);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "  Last Name";
            this.txtNom.Size = new System.Drawing.Size(355, 32);
            this.txtNom.TabIndex = 56;
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
            this.roundedButton1.TabIndex = 54;
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
            this.panelTitleBar.TabIndex = 53;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(822, 437);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panelTitleBar);
            this.MaximumSize = new System.Drawing.Size(840, 484);
            this.MinimumSize = new System.Drawing.Size(840, 484);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtEmail;
        private TextBox txtCodePostal;
        private Tools.RoundedButton roundedButton2;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtNumTel;
        private TextBox txtAdresse;
        private TextBox txtCin;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private Tools.RoundedButton roundedButton1;
        private Panel panelTitleBar;
    }
}