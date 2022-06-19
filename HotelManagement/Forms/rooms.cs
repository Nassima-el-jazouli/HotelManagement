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
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Chambre> Chambres = database.Chambres.Include(x=>x.Reservations).Include(x=>x.Hotel).Include(x=>x.Categorie).ToList();
            int y = 0;
            foreach (Chambre ch in Chambres)
            {
                Panel LpPanel = new Panel();
                Label lblHotel = new Label();
                Label lblPrice = new Label();
                Label lblCategorie = new Label();
                Label lblNumTel = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();
                RoundedButton btnReserved = new RoundedButton();

                //LpPanel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(45, 136 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(837, 56);
                LpPanel.TabIndex = 14;
                LpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LpPanel_Paint);

                //lblNumTel
                lblNumTel.AutoSize = true;
                lblNumTel.Location = new System.Drawing.Point(33, 17);
                lblNumTel.Name = "lblNumTel";
                lblNumTel.Size = new System.Drawing.Size(50, 20);
                lblNumTel.TabIndex = 6;
                lblNumTel.Text = ch.NumTel;

                //lblPrice
                lblPrice.AutoSize = true;
                lblPrice.Location = new System.Drawing.Point(205, 17);
                lblPrice.Name = "lblPrice";
                lblPrice.Size = new System.Drawing.Size(50, 20);
                lblPrice.TabIndex = 7;
                Hotel hotel = database.Hotels.Where(x=>x.Id == ch.HotelId).First();
                Classement classement = database.Classements.Where(x => x.Id == hotel.ClassementId).First();
                Categorie categorie = database.Categories.Where(x => x.Id == ch.CategorieId).First();
                lblPrice.Text = (categorie.Prix * classement.Note).ToString();

                //lblHotel
                lblHotel.AutoSize = true;
                lblHotel.Location = new System.Drawing.Point(325, 17);
                lblHotel.Name = "lblHotel";
                lblHotel.Size = new System.Drawing.Size(50, 20);
                lblHotel.TabIndex = 12;
                lblHotel.Text = ch.Hotel.Nom;
                lblHotel.Click += new System.EventHandler(this.lblDescription_Click);

                //lblCategorie
                lblCategorie.AutoSize = true;
                lblCategorie.Location = new System.Drawing.Point(430, 17);
                lblCategorie.Name = "lblCategorie";
                lblCategorie.Size = new System.Drawing.Size(50, 20);
                lblCategorie.TabIndex = 13;
                lblCategorie.Text = ch.Categorie.Name;

                // btnReserved
                // 
                btnReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
                btnReserved.BorderColor = System.Drawing.Color.PaleVioletRed;
                btnReserved.BorderRadius = 10;
                btnReserved.BorderSize = 0;
                btnReserved.FlatAppearance.BorderSize = 0;
                btnReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnReserved.ForeColor = System.Drawing.Color.White;
                btnReserved.Location = new System.Drawing.Point(613, 18);
                btnReserved.Name = "btnReserved";
                btnReserved.Size = new System.Drawing.Size(19, 19);
                btnReserved.TabIndex = 14;
                btnReserved.TextColor = System.Drawing.Color.White;
                btnReserved.UseVisualStyleBackColor = false;
                if (ch.Reserved = true)
                {
                    btnReserved.BackgroundColor = System.Drawing.Color.Red;
                }
                if (ch.Reserved = false)
                {
                    btnReserved.BackgroundColor = System.Drawing.Color.Green;
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
                Edit.Location = new System.Drawing.Point(673, 3);
                Edit.Name = ch.Id.ToString();
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
                Delete.Click += (s, e) => Delete_Click(s, e, ch);

                //Controls
                LpPanel.Controls.Add(lblCategorie);
                LpPanel.Controls.Add(lblHotel);
                LpPanel.Controls.Add(lblPrice);
                LpPanel.Controls.Add(lblNumTel);
                LpPanel.Controls.Add(btnReserved);
                LpPanel.Controls.Add(Edit);
                LpPanel.Controls.Add(Delete);
                this.Controls.Add(LpPanel);
                y = y + 50;

            }
            



        }

        private void LpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void Hotel_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Button bt = (Button)sender;
            int id = Int32.Parse(bt.Name.ToString());
            Chambre chambre = database.Chambres.Where(x => x.Id == id).First();
            int CategorieId = chambre.CategorieId;
            int HotelId = chambre.HotelId;
            UpdateRoom updateRoom = new UpdateRoom(chambre);
            updateRoom.Show();
        }

        private void Delete_Click(object sender, EventArgs e, Chambre ch)
        {
            Database database = new Database();
            database.Entry(ch).State = EntityState.Deleted;
            database.SaveChanges();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }
    }
}
