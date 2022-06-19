using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Forms;
using HotelManagement.Data;
using HotelManagement.Tools;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Forms
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Client> Clients = database.Clients.ToList();
            int y = 0;
            foreach (Client c in Clients)
            {
                Panel LpPanel = new Panel();
                Label lblCodePostal = new Label();
                Label lblCountry = new Label();
                Label lblCity = new Label();
                Label lblNumTel = new Label();
                Label lblAdresse = new Label();
                Label lblCin = new Label();
                Label lblNom = new Label();
                Label lblPrenom = new Label();
                Label lblEmail = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();




                //LpPanel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(35, 136 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(852, 56);
                LpPanel.TabIndex = 20;


                //lblPrenom
                lblPrenom.AutoSize = true;
                lblPrenom.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblPrenom.Location = new System.Drawing.Point(10, 21);
                lblPrenom.Name = "lblPrenom";
                lblPrenom.Size = new System.Drawing.Size(30, 12);
                lblPrenom.TabIndex = 6;
                lblPrenom.Text = c.Prenom;

                //lblNom
                lblNom.AutoSize = true;
                lblNom.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblNom.Location = new System.Drawing.Point(98, 21);
                lblNom.Name = "lblNom";
                lblNom.Size = new System.Drawing.Size(30, 12);
                lblNom.TabIndex = 7;
                lblNom.Text = c.Nom;

                //lblCin
                lblCin.AutoSize = true;
                lblCin.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblCin.Location = new System.Drawing.Point(184, 21);
                lblCin.Name = "lblCin";
                lblCin.Size = new System.Drawing.Size(30, 12);
                lblCin.TabIndex = 12;
                lblCin.Text = c.Cin;

                //lblAdresse
                lblAdresse.AutoSize = true;
                lblAdresse.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblAdresse.Location = new System.Drawing.Point(237, 21);
                lblAdresse.Name = "lblAdresse";
                lblAdresse.Size = new System.Drawing.Size(30, 12);
                lblAdresse.TabIndex = 13;
                lblAdresse.Text = c.Adresse;

                //lblCity
                lblCity.AutoSize = true;
                lblCity.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblCity.Location = new System.Drawing.Point(416, 21);
                lblCity.Name = "lblCity";
                lblCity.Size = new System.Drawing.Size(30, 12);
                lblCity.TabIndex = 15;
                lblCity.Text = c.Ville;
                lblCity.Click += new System.EventHandler(this.lblUsername_Click);

                //lblCountry
                lblCountry.AutoSize = true;
                lblCountry.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblCountry.Location = new System.Drawing.Point(475, 21);
                lblCountry.Name = "lblCountry";
                lblCountry.Size = new System.Drawing.Size(30, 12);
                lblCountry.TabIndex = 17;
                lblCountry.Text = c.Pays;

                //lblCodePostal
                lblCodePostal.AutoSize = true;
                lblCodePostal.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblCodePostal.Location = new System.Drawing.Point(546, 18);
                lblCodePostal.Name = "lblCodePostal";
                lblCodePostal.Size = new System.Drawing.Size(30, 12);
                lblCodePostal.TabIndex = 18;
                lblCodePostal.Text = c.CodePostal;
                lblCodePostal.Click += new System.EventHandler(this.lblRole_Click);

                //lblNumTel
                lblNumTel.AutoSize = true;
                lblNumTel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblNumTel.Location = new System.Drawing.Point(330, 21);
                lblNumTel.Name = "lblNumTel";
                lblNumTel.Size = new System.Drawing.Size(30, 12);
                lblNumTel.TabIndex = 14;
                lblNumTel.Text = c.NumTel;

                //lblEmail
                lblEmail.AutoSize = true;
                lblEmail.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblEmail.Location = new System.Drawing.Point(600, 21);
                lblEmail.Name = "lblEmail";
                lblEmail.Size = new System.Drawing.Size(30, 12);
                lblEmail.TabIndex = 19;
                lblEmail.Text = c.Email;


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
                Edit.Location = new System.Drawing.Point(727, 3);
                Edit.Name = c.Id.ToString();
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
                Delete.Location = new System.Drawing.Point(791, 3);
                Delete.Name = "Delete";
                Delete.Size = new System.Drawing.Size(58, 48);
                Delete.TabIndex = 4;
                Delete.TextColor = System.Drawing.Color.White;
                Delete.UseVisualStyleBackColor = false;
                Delete.Click += (e, s) => Delete_Click(e, s, c);


                //Controls
                LpPanel.Controls.Add(lblEmail);
                LpPanel.Controls.Add(lblCodePostal);
                LpPanel.Controls.Add(lblCountry);
                LpPanel.Controls.Add(lblCity);
                LpPanel.Controls.Add(lblNumTel);
                LpPanel.Controls.Add(lblAdresse);
                LpPanel.Controls.Add(lblCin);
                LpPanel.Controls.Add(lblNom);
                LpPanel.Controls.Add(lblPrenom);
                LpPanel.Controls.Add(Edit);
                LpPanel.Controls.Add(Delete);
                this.Controls.Add(LpPanel);

                y = y + 50;
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e, Client c)
        {
            Database database = new Database();
            database.Entry(c).State = EntityState.Deleted;
            database.SaveChanges();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Button bt = (Button)sender;
            int id = Int32.Parse(bt.Name.ToString());
            Client client = database.Clients.Where(x => x.Id == id).First();
            UpdateCustomer updateCustomer = new UpdateCustomer(client);
            updateCustomer.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }
    }
}