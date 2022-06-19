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
using HotelManagement.Tools;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Forms
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void lblCategorie_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Button bt = (Button)sender;
            int id = Int32.Parse(bt.Name.ToString());
            User user = database.Users.Where(x => x.Id == id).First();
            UpdateEmployee updateEmployee = new UpdateEmployee(user);
            updateEmployee.Show();
        }

        private void lblHotel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<User> Users = database.Users.ToList();
            int y = 0;
            foreach (User u in Users)
            {
                Panel LpPanel = new Panel();
                Label lblEmail = new Label();
                Label lblUsername = new Label();
                Label lblNumTel = new Label();
                Label lblAdresse = new Label();
                Label lblCin = new Label();
                Label lblNom = new Label();
                Label lblPrenom = new Label();
                Label lblRole = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();

                //LpPannel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(37, 145 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(847, 56);
                LpPanel.TabIndex = 17;

                //lblPrenom
                lblPrenom.AutoSize = true;
                lblPrenom.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblPrenom.Location = new System.Drawing.Point(10, 21);
                lblPrenom.Name = "lblPrenom";
                lblPrenom.Size = new System.Drawing.Size(38, 15);
                lblPrenom.TabIndex = 6;
                lblPrenom.Text = u.Prenom;

                //lblNom
                lblNom.AutoSize = true;
                lblNom.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblNom.Location = new System.Drawing.Point(98, 21);
                lblNom.Name = "lblNom";
                lblNom.Size = new System.Drawing.Size(38, 15);
                lblNom.TabIndex = 7;
                lblNom.Text = u.Nom;

                //lblCin
                lblCin.AutoSize = true;
                lblCin.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblCin.Location = new System.Drawing.Point(184, 21);
                lblCin.Name = "lblCin";
                lblCin.Size = new System.Drawing.Size(38, 15);
                lblCin.TabIndex = 12;
                lblCin.Text = u.Cin;
                lblCin.Click += new System.EventHandler(this.lblHotel_Click);

                //lblAdresse
                lblAdresse.AutoSize = true;
                lblAdresse.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblAdresse.Location = new System.Drawing.Point(237, 21);
                lblAdresse.Name = "lblAdresse";
                lblAdresse.Size = new System.Drawing.Size(38, 15);
                lblAdresse.TabIndex = 13;
                lblAdresse.Text = u.Adresse;
                lblAdresse.Click += new System.EventHandler(this.lblCategorie_Click);

                //lblNumTel
                lblNumTel.AutoSize = true;
                lblNumTel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblNumTel.Location = new System.Drawing.Point(339, 21);
                lblNumTel.Name = "lblNumTel";
                lblNumTel.Size = new System.Drawing.Size(38, 15);
                lblNumTel.TabIndex = 14;
                lblNumTel.Text = u.NumTel;


                //lblUsername
                lblUsername.AutoSize = true;
                lblUsername.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblUsername.Location = new System.Drawing.Point(425, 21);
                lblUsername.Name = "lblUsername";
                lblUsername.Size = new System.Drawing.Size(38, 15);
                lblUsername.TabIndex = 15;
                lblUsername.Text = u.Username;
                lblUsername.Click += new System.EventHandler(this.label7_Click);

                //lblEmail
                lblEmail.AutoSize = true;
                lblEmail.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblEmail.Location = new System.Drawing.Point(522, 21);
                lblEmail.Name = "lblEmail";
                lblEmail.Size = new System.Drawing.Size(38, 15);
                lblEmail.TabIndex = 17;
                lblEmail.Text = u.Email;

                //lblRole
                lblRole.AutoSize = true;
                lblRole.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblRole.Location = new System.Drawing.Point(613, 21);
                lblRole.Name = "lblRole";
                lblRole.Size = new System.Drawing.Size(38, 15);
                lblRole.TabIndex = 18;
                if (u.Role == 0)
                {
                    lblRole.Text = "admin";
                }
                else
                {
                    lblRole.Text = "employee";
                }


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
                Edit.Location = new System.Drawing.Point(700, 3);
                Edit.Name = u.Id.ToString();
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
                Delete.Location = new System.Drawing.Point(780, 3);
                Delete.Name = "Delete";
                Delete.Size = new System.Drawing.Size(58, 48);
                Delete.TabIndex = 4;
                Delete.TextColor = System.Drawing.Color.White;
                Delete.UseVisualStyleBackColor = false;
                Delete.Click += (s,e) => Delete_Click(s, e, u);


                //Controls
                LpPanel.Controls.Add(lblRole);
                LpPanel.Controls.Add(lblEmail);
                LpPanel.Controls.Add(lblUsername);
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
        private void Delete_Click(object sender, EventArgs e, User u)
        {
            Database database = new Database();
            database.Entry(u).State = EntityState.Deleted;
            database.SaveChanges();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }
    }
}
