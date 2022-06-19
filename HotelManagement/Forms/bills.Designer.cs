namespace HotelManagement.Forms
{
    partial class bills
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
            this.btnSave = new HotelManagement.Tools.RoundedButton();
            this.btnCancel = new HotelManagement.Tools.RoundedButton();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReservationId = new HotelManagement.Tools.PlaceHolder();
            this.txtClientName = new HotelManagement.Tools.PlaceHolder();
            this.txtChambreId = new HotelManagement.Tools.PlaceHolder();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblChambreId = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblReservationId);
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Controls.Add(this.lblChambreId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(473, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 635);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(186, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(281, 50);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Generate Bill";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(3, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 50);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Reset";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoom.Location = new System.Drawing.Point(37, 61);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(108, 31);
            this.lblRoom.TabIndex = 18;
            this.lblRoom.Text = "N° Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Client\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "N° Reservation";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(186, 348);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(263, 27);
            this.Date.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date";
            // 
            // txtReservationId
            // 
            this.txtReservationId.BackColor = System.Drawing.Color.White;
            this.txtReservationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservationId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtReservationId.ForeColor = System.Drawing.Color.Gray;
            this.txtReservationId.Location = new System.Drawing.Point(212, 253);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.PlaceHolderText = "";
            this.txtReservationId.Size = new System.Drawing.Size(237, 32);
            this.txtReservationId.TabIndex = 23;
            this.txtReservationId.Text = "  850";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.White;
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtClientName.ForeColor = System.Drawing.Color.Gray;
            this.txtClientName.Location = new System.Drawing.Point(212, 151);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PlaceHolderText = "  Sous Categorie";
            this.txtClientName.Size = new System.Drawing.Size(237, 32);
            this.txtClientName.TabIndex = 24;
            this.txtClientName.Text = "  Hassan ZILI";
            // 
            // txtChambreId
            // 
            this.txtChambreId.BackColor = System.Drawing.Color.White;
            this.txtChambreId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChambreId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtChambreId.ForeColor = System.Drawing.Color.Gray;
            this.txtChambreId.Location = new System.Drawing.Point(212, 60);
            this.txtChambreId.Name = "txtChambreId";
            this.txtChambreId.PlaceHolderText = "  132";
            this.txtChambreId.Size = new System.Drawing.Size(237, 32);
            this.txtChambreId.TabIndex = 25;
            this.txtChambreId.Text = "  157";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(92, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(167, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hotello Bill N° 16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "N° Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Client\'s Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "N° Reservation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date";
            // 
            // lblChambreId
            // 
            this.lblChambreId.AutoSize = true;
            this.lblChambreId.Location = new System.Drawing.Point(284, 135);
            this.lblChambreId.Name = "lblChambreId";
            this.lblChambreId.Size = new System.Drawing.Size(0, 20);
            this.lblChambreId.TabIndex = 27;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(284, 177);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 20);
            this.lblClientName.TabIndex = 28;
            // 
            // lblReservationId
            // 
            this.lblReservationId.AutoSize = true;
            this.lblReservationId.Location = new System.Drawing.Point(284, 275);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(0, 20);
            this.lblReservationId.TabIndex = 29;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(284, 326);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 30;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(229, 507);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 23);
            this.Total.TabIndex = 31;
            // 
            // bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.txtChambreId);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtReservationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1008, 685);
            this.MinimumSize = new System.Drawing.Size(1008, 685);
            this.Name = "bills";
            this.Text = "Bills";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Tools.RoundedButton btnSave;
        private Tools.RoundedButton btnCancel;
        private Label lblRoom;
        private Label label1;
        private Label label2;
        private DateTimePicker Date;
        private Label label3;
        private Tools.PlaceHolder txtReservationId;
        private Tools.PlaceHolder txtClientName;
        private Tools.PlaceHolder txtChambreId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblChambreId;
        private Label label9;
        private Label Total;
        private Label lblDate;
        private Label lblReservationId;
        private Label lblClientName;
    }
}