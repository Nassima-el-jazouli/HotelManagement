namespace HotelManagement.Forms
{
    partial class rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rooms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Categorie = new System.Windows.Forms.Label();
            this.Hotel = new System.Windows.Forms.Label();
            this.NumTel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Add = new HotelManagement.Tools.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.Categorie);
            this.panel1.Controls.Add(this.Hotel);
            this.panel1.Controls.Add(this.NumTel);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Location = new System.Drawing.Point(45, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 71);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Categorie.ForeColor = System.Drawing.Color.Black;
            this.Categorie.Location = new System.Drawing.Point(489, 19);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(110, 31);
            this.Categorie.TabIndex = 7;
            this.Categorie.Text = "Category";
            // 
            // Hotel
            // 
            this.Hotel.AutoSize = true;
            this.Hotel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hotel.ForeColor = System.Drawing.Color.Black;
            this.Hotel.Location = new System.Drawing.Point(325, 19);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(71, 31);
            this.Hotel.TabIndex = 6;
            this.Hotel.Text = "Hotel";
            this.Hotel.Click += new System.EventHandler(this.Hotel_Click);
            // 
            // NumTel
            // 
            this.NumTel.AutoSize = true;
            this.NumTel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTel.ForeColor = System.Drawing.Color.Black;
            this.NumTel.Location = new System.Drawing.Point(33, 19);
            this.NumTel.Name = "NumTel";
            this.NumTel.Size = new System.Drawing.Size(79, 31);
            this.NumTel.TabIndex = 4;
            this.NumTel.Text = "Phone";
            this.NumTel.Click += new System.EventHandler(this.Name_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(205, 19);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(65, 31);
            this.Price.TabIndex = 5;
            this.Price.Text = "Price";
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
            this.Add.Location = new System.Drawing.Point(897, 59);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 198);
            this.Add.TabIndex = 12;
            this.Add.TextColor = System.Drawing.Color.White;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.MaximumSize = new System.Drawing.Size(1008, 685);
            this.MinimumSize = new System.Drawing.Size(1008, 685);
            this.Name = "rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.rooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label Hotel;
        private Label NumTel;
        private Label Price;
        private Tools.RoundedButton Add;
        private Label Categorie;
    }
}