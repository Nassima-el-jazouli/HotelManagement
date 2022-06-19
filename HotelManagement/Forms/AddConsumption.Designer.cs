namespace HotelManagement.Forms
{
    partial class AddConsumption
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
            this.txtDescription = new HotelManagement.Tools.PlaceHolder();
            this.txtPrice = new HotelManagement.Tools.PlaceHolder();
            this.txtCategorie = new HotelManagement.Tools.PlaceHolder();
            this.txtSousCategorie = new HotelManagement.Tools.PlaceHolder();
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
            this.panelTitleBar.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(112, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Consumption";
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
            this.btnCancel.Location = new System.Drawing.Point(96, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 50);
            this.btnCancel.TabIndex = 16;
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
            this.btnSave.Location = new System.Drawing.Point(279, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.Location = new System.Drawing.Point(94, 356);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceHolderText = "  Description";
            this.txtDescription.Size = new System.Drawing.Size(355, 39);
            this.txtDescription.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtPrice.Location = new System.Drawing.Point(96, 282);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceHolderText = "  Price";
            this.txtPrice.Size = new System.Drawing.Size(355, 32);
            this.txtPrice.TabIndex = 13;
            // 
            // txtCategorie
            // 
            this.txtCategorie.BackColor = System.Drawing.Color.White;
            this.txtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategorie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCategorie.ForeColor = System.Drawing.Color.Gray;
            this.txtCategorie.Location = new System.Drawing.Point(94, 128);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.PlaceHolderText = "  Categorie";
            this.txtCategorie.Size = new System.Drawing.Size(355, 32);
            this.txtCategorie.TabIndex = 18;
            this.txtCategorie.Text = "  ";
            // 
            // txtSousCategorie
            // 
            this.txtSousCategorie.BackColor = System.Drawing.Color.White;
            this.txtSousCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSousCategorie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSousCategorie.ForeColor = System.Drawing.Color.Gray;
            this.txtSousCategorie.Location = new System.Drawing.Point(94, 208);
            this.txtSousCategorie.Name = "txtSousCategorie";
            this.txtSousCategorie.PlaceHolderText = "  Sous Categorie";
            this.txtSousCategorie.Size = new System.Drawing.Size(355, 32);
            this.txtSousCategorie.TabIndex = 19;
            // 
            // AddConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(542, 600);
            this.Controls.Add(this.txtSousCategorie);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximumSize = new System.Drawing.Size(560, 647);
            this.MinimumSize = new System.Drawing.Size(560, 647);
            this.Name = "AddConsumption";
            this.Text = "AddConsumption";
            this.Load += new System.EventHandler(this.AddConsumption_Load);
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
        private Tools.PlaceHolder txtDescription;
        private Tools.PlaceHolder txtPrice;
        private Tools.PlaceHolder txtCategorie;
        private Tools.PlaceHolder txtSousCategorie;
    }
}