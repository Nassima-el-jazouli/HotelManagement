using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Data;
using HotelManagement.Forms;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using HotelManagement.Tools;

namespace HotelManagement.Forms
{
    public partial class consumptions : Form
    {
        public consumptions()
        {
            InitializeComponent();
        }

        private void SousCategorie_Click(object sender, EventArgs e)
        {

        }

        private void consumptions_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Prestation> Prestations = database.Prestations.ToList();
            int y = 0;
            foreach (Prestation p in Prestations)
            {
                Panel LpPanel = new Panel();
                Label lblPrix = new Label();
                Label lblDescription = new Label();
                Label lblSousCategorie = new Label();
                Label lblCategorie = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();



                //Panel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(43, 137 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(837, 56);
                LpPanel.TabIndex = 17;

                //lblPrix
                lblPrix.AutoSize = true;
                lblPrix.Location = new System.Drawing.Point(529, 17);
                lblPrix.Name = "lblPrix";
                lblPrix.Size = new System.Drawing.Size(50, 20);
                lblPrix.TabIndex = 13;
                lblPrix.Text = p.Prix.ToString();

                //lblDescription
                lblDescription.AutoSize = true;
                lblDescription.Location = new System.Drawing.Point(325, 17);
                lblDescription.Name = "lblDescription";
                lblDescription.Size = new System.Drawing.Size(50, 20);
                lblDescription.TabIndex = 12;
                lblDescription.Text = p.Description;

                //lblSouCategorie
                lblSousCategorie.AutoSize = true;
                lblSousCategorie.Location = new System.Drawing.Point(139, 17);
                lblSousCategorie.Name = "lblSousCategorie";
                lblSousCategorie.Size = new System.Drawing.Size(50, 20);
                lblSousCategorie.TabIndex = 7;
                lblSousCategorie.Text = p.SousCategorie;


                //lblCategorie
                lblCategorie.AutoSize = true;
                lblCategorie.Location = new System.Drawing.Point(18, 17);
                lblCategorie.Name = "lblCategorie";
                lblCategorie.Size = new System.Drawing.Size(50, 20);
                lblCategorie.TabIndex = 6;
                lblCategorie.Text = p.Categorie;


                //Edit
                Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
                Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
                Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
                Edit.BorderRadius = 20;
                Edit.BorderSize = 0;
                Edit.FlatAppearance.BorderSize = 0;
                Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Edit.ForeColor = System.Drawing.Color.White;
                Edit.Image = global::HotelManagement.Properties.Resources.edit;
                Edit.Location = new System.Drawing.Point(673, 3);
                Edit.Name = p.Id.ToString();
                Edit.Size = new System.Drawing.Size(58, 48);
                Edit.TabIndex = 5;
                Edit.TextColor = System.Drawing.Color.White;
                Edit.UseVisualStyleBackColor = false;
                Edit.Click += new System.EventHandler(this.Edit_Click);

                //Delete
                Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
                Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
                Delete.BorderColor = System.Drawing.Color.PaleVioletRed;
                Delete.BorderRadius = 20;
                Delete.BorderSize = 0;
                Delete.FlatAppearance.BorderSize = 0;
                Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Delete.ForeColor = System.Drawing.Color.White;
                Delete.Image = global::HotelManagement.Properties.Resources.delete__1_;
                Delete.Location = new System.Drawing.Point(762, 3);
                Delete.Name = "Delete";
                Delete.Size = new System.Drawing.Size(58, 48);
                Delete.TabIndex = 4;
                Delete.TextColor = System.Drawing.Color.White;
                Delete.UseVisualStyleBackColor = false;
                Delete.Click += (s, e) => Delete_Click(s, e, p);


                //Controls
                LpPanel.Controls.Add(lblPrix);
                LpPanel.Controls.Add(lblDescription);
                LpPanel.Controls.Add(lblSousCategorie);
                LpPanel.Controls.Add(lblCategorie);
                LpPanel.Controls.Add(Edit);
                LpPanel.Controls.Add(Delete);
                this.Controls.Add(LpPanel);
                y = y + 50;
            }
        }

        private void Delete_Click(object s, EventArgs e, Prestation p)
        {
            Database database = new Database();
            database.Entry(p).State = EntityState.Deleted;
            database.SaveChanges();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddConsumption addConsumption = new AddConsumption();
            addConsumption.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Button bt = (Button)sender;
            int id = Int32.Parse(bt.Name.ToString());
            Prestation prestation = database.Prestations.Where(x => x.Id == id).First();
            UpdateConsumption updateConsumption = new UpdateConsumption(prestation);
            updateConsumption.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
