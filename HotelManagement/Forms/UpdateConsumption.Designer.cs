namespace HotelManagement.Forms
{
    partial class UpdateConsumption
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new HotelManagement.Tools.RoundedButton();
            this.btnSave = new HotelManagement.Tools.RoundedButton();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtSousCategorie = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(542, 89);
            this.panelTitleBar.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(91, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Consumption";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCancel.Location = new System.Drawing.Point(91, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 50);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(279, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 50);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategorie
            // 
            this.txtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategorie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCategorie.Location = new System.Drawing.Point(94, 125);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(355, 32);
            this.txtCategorie.TabIndex = 27;
            // 
            // txtSousCategorie
            // 
            this.txtSousCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSousCategorie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSousCategorie.Location = new System.Drawing.Point(94, 209);
            this.txtSousCategorie.Name = "txtSousCategorie";
            this.txtSousCategorie.Size = new System.Drawing.Size(355, 32);
            this.txtSousCategorie.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(94, 284);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(355, 32);
            this.txtPrice.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(91, 364);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(360, 32);
            this.txtDescription.TabIndex = 30;
            // 
            // UpdateConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(542, 600);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSousCategorie);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(560, 647);
            this.MinimumSize = new System.Drawing.Size(560, 647);
            this.Name = "UpdateConsumption";
            this.Text = "UpdateConsumption";
            this.Load += new System.EventHandler(this.UpdateConsumption_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTitleBar;
        private Label lblTitle;
        private Tools.RoundedButton btnCancel;
        private Tools.RoundedButton btnSave;
        private TextBox txtCategorie;
        private TextBox txtSousCategorie;
        private TextBox txtPrice;
        private TextBox txtDescription;
    }
}