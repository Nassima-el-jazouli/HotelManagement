namespace HotelManagement.Forms
{
    partial class AddReservation
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
            this.roundedButton2 = new HotelManagement.Tools.RoundedButton();
            this.txtArrhes = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new HotelManagement.Tools.RoundedButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.DatePayeArrhes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChambreId = new System.Windows.Forms.ComboBox();
            this.cmbClientCin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(372, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.roundedButton2.Location = new System.Drawing.Point(637, 375);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(177, 50);
            this.roundedButton2.TabIndex = 39;
            this.roundedButton2.Text = "Cancel";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // txtArrhes
            // 
            this.txtArrhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArrhes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtArrhes.Location = new System.Drawing.Point(637, 257);
            this.txtArrhes.Name = "txtArrhes";
            this.txtArrhes.PlaceholderText = "  Arrhes";
            this.txtArrhes.Size = new System.Drawing.Size(355, 32);
            this.txtArrhes.TabIndex = 46;
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
            this.roundedButton1.Location = new System.Drawing.Point(820, 375);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(172, 50);
            this.roundedButton1.TabIndex = 41;
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
            this.panelTitleBar.Size = new System.Drawing.Size(1032, 89);
            this.panelTitleBar.TabIndex = 40;
            // 
            // DateDebut
            // 
            this.DateDebut.Location = new System.Drawing.Point(162, 123);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(299, 27);
            this.DateDebut.TabIndex = 47;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(162, 193);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(299, 27);
            this.DateFin.TabIndex = 48;
            // 
            // DatePayeArrhes
            // 
            this.DatePayeArrhes.Location = new System.Drawing.Point(162, 263);
            this.DatePayeArrhes.Name = "DatePayeArrhes";
            this.DatePayeArrhes.Size = new System.Drawing.Size(299, 27);
            this.DatePayeArrhes.TabIndex = 49;
            this.DatePayeArrhes.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Begin Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "End Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Date Arrhes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbChambreId
            // 
            this.cmbChambreId.FormattingEnabled = true;
            this.cmbChambreId.Location = new System.Drawing.Point(637, 122);
            this.cmbChambreId.Name = "cmbChambreId";
            this.cmbChambreId.Size = new System.Drawing.Size(355, 28);
            this.cmbChambreId.TabIndex = 53;
            this.cmbChambreId.SelectedIndexChanged += new System.EventHandler(this.cmbChambreId_SelectedIndexChanged);
            // 
            // cmbClientCin
            // 
            this.cmbClientCin.FormattingEnabled = true;
            this.cmbClientCin.Location = new System.Drawing.Point(637, 192);
            this.cmbClientCin.Name = "cmbClientCin";
            this.cmbClientCin.Size = new System.Drawing.Size(355, 28);
            this.cmbClientCin.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(489, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 56;
            this.label4.Text = "N° Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(489, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 57;
            this.label5.Text = "Client\'s CIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(489, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 59;
            this.label7.Text = "Begin Date";
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1032, 437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClientCin);
            this.Controls.Add(this.cmbChambreId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePayeArrhes);
            this.Controls.Add(this.DateFin);
            this.Controls.Add(this.DateDebut);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.txtArrhes);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panelTitleBar);
            this.MaximumSize = new System.Drawing.Size(1050, 484);
            this.MinimumSize = new System.Drawing.Size(1050, 484);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.Load += new System.EventHandler(this.AddReservation_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Tools.RoundedButton roundedButton2;
        private TextBox txtArrhes;
        private Tools.RoundedButton roundedButton1;
        private Panel panelTitleBar;
        private DateTimePicker DateDebut;
        private DateTimePicker DateFin;
        private DateTimePicker DatePayeArrhes;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbChambreId;
        private ComboBox cmbClientCin;
        private Label label4;
        private Label label5;
        private Label label7;
    }
}