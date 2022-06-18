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
using HotelManagement.Tools;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Forms
{
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
        }

        public void categories_Load(object sender, EventArgs e)
        {
            Database Database = new Database();
            List<Categorie> Categories = Database.Categories.ToList();
            int y = 0;
            foreach (Categorie c in Categories)
            {
                Panel LpPanel = new Panel();
                Label lblDescription = new Label();
                Label lblPrice = new Label();
                Label lblName = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();


                //LpPanel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(41, 133 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(837, 56);
                LpPanel.TabIndex = 17;

                //lblName
                lblName.AutoSize = true;
                lblName.Location = new System.Drawing.Point(48, 16);
                lblName.Name = "lblName";
                lblName.Size = new System.Drawing.Size(50, 20);
                lblName.TabIndex = 6;
                lblName.Text = c.Name;

                //lblPrice
                lblPrice.AutoSize = true;
                lblPrice.Location = new System.Drawing.Point(148, 17);
                lblPrice.Name = "lblPrice";
                lblPrice.Size = new System.Drawing.Size(50, 20);
                lblPrice.TabIndex = 7;
                lblPrice.Text = c.Prix.ToString();
                //lblDescription
                lblDescription.AutoSize = true;
                lblDescription.Location = new System.Drawing.Point(299, 17);
                lblDescription.Name = "lblDescription";
                lblDescription.Size = new System.Drawing.Size(50, 20);
                lblDescription.TabIndex = 12;
                lblDescription.Text = c.Description;

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
                Edit.Name = c.Id.ToString();
                Edit.Size = new System.Drawing.Size(58, 48);
                Edit.TabIndex = 5;
                Edit.TextColor = System.Drawing.Color.White;
                Edit.UseVisualStyleBackColor = false;
                Edit.Click += (s, e) => Edit_Click(s, e);

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
                Delete.Click += (s, e) => Delete_Click(s, e, c);


                //Controls
                LpPanel.Controls.Add(lblName);
                LpPanel.Controls.Add(lblPrice);
                LpPanel.Controls.Add(lblDescription);
                LpPanel.Controls.Add(Edit);
                LpPanel.Controls.Add(Delete);
                this.Controls.Add(LpPanel);
                y = y + 50;
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCategorie addCategorie = new AddCategorie();
            addCategorie.Show();
        }
        private void Delete_Click(object sender, EventArgs e, Categorie c)
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
            Categorie categorie = database.Categories.Where(x => x.Id == id).First();
            UpdateCategorie updateCategorie = new UpdateCategorie(categorie);
            updateCategorie.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
