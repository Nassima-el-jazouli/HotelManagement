namespace HotelManagement.Forms
{
    partial class consumptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consumptions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prix = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Categorie = new System.Windows.Forms.Label();
            this.SousCategorie = new System.Windows.Forms.Label();
            this.Add = new HotelManagement.Tools.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.Prix);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Categorie);
            this.panel1.Controls.Add(this.SousCategorie);
            this.panel1.Location = new System.Drawing.Point(43, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 71);
            this.panel1.TabIndex = 16;
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prix.ForeColor = System.Drawing.Color.Black;
            this.Prix.Location = new System.Drawing.Point(529, 19);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(65, 31);
            this.Prix.TabIndex = 7;
            this.Prix.Text = "Price";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description.ForeColor = System.Drawing.Color.Black;
            this.Description.Location = new System.Drawing.Point(325, 19);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(134, 31);
            this.Description.TabIndex = 6;
            this.Description.Text = "Description";
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Categorie.ForeColor = System.Drawing.Color.Black;
            this.Categorie.Location = new System.Drawing.Point(18, 19);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(115, 31);
            this.Categorie.TabIndex = 4;
            this.Categorie.Text = "Categorie";
            // 
            // SousCategorie
            // 
            this.SousCategorie.AutoSize = true;
            this.SousCategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SousCategorie.ForeColor = System.Drawing.Color.Black;
            this.SousCategorie.Location = new System.Drawing.Point(139, 19);
            this.SousCategorie.Name = "SousCategorie";
            this.SousCategorie.Size = new System.Drawing.Size(165, 31);
            this.SousCategorie.TabIndex = 5;
            this.SousCategorie.Text = "SousCategorie";
            this.SousCategorie.Click += new System.EventHandler(this.SousCategorie_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add.BorderRadius = 20;
            this.Add.BorderSize = 0;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(895, 60);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 198);
            this.Add.TabIndex = 15;
            this.Add.TextColor = System.Drawing.Color.White;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // consumptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.MaximumSize = new System.Drawing.Size(1008, 685);
            this.MinimumSize = new System.Drawing.Size(1008, 685);
            this.Name = "consumptions";
            this.Text = "Consumptions";
            this.Load += new System.EventHandler(this.consumptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label Prix;
        private Label Description;
        private Label Categorie;
        private Label SousCategorie;
        private Tools.RoundedButton Add;
    }
}