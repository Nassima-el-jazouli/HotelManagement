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
    public partial class reservations : Form
    {
        public reservations()
        {
            InitializeComponent();
        }

        private void reservations_Load(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void lblHotel_Click(object sender, EventArgs e)
        {

        }

        private void lblCategorie_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Button bt = (Button)sender;
            int id = Int32.Parse(bt.Name.ToString());
            Reservation reservation = database.Reservations.Where(x => x.Id == id).First();
            int ChambreId = reservation.ChambreId;
            int ClientId = reservation.ClientId;
            int UserId = reservation.UserId;
            UpdateReservation updateReservation = new UpdateReservation(reservation);
            updateReservation.Show();
        }

        private void reservations_Load_1(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Reservation> Reservations = database.Reservations.Include(x => x.Chambre).Include(x => x.Client).Include(x => x.User).ToList();
            int y = 0;
            foreach (Reservation r in Reservations)
            {
                Panel LpPanel = new Panel();
                Label lblUserUsername = new Label();
                Label lblChambreId = new Label();
                Label lblClientCin = new Label();
                Label lblArrhes = new Label();
                Label lblDatePayeArrhes = new Label();
                Label lblDateFin = new Label();
                Label lblDateDebut = new Label();
                RoundedButton Edit = new RoundedButton();
                RoundedButton Delete = new RoundedButton();

                //LpPanel
                LpPanel.SuspendLayout();
                LpPanel.BackColor = System.Drawing.Color.White;
                LpPanel.Location = new System.Drawing.Point(43, 192 + y);
                LpPanel.Name = "LpPanel";
                LpPanel.Size = new System.Drawing.Size(909, 56);
                LpPanel.TabIndex = 17;

                //lblDateDebut
                lblDateDebut.AutoSize = true;
                lblDateDebut.Location = new System.Drawing.Point(20, 17);
                lblDateDebut.Name = "lblDateDebut";
                lblDateDebut.Size = new System.Drawing.Size(50, 20);
                lblDateDebut.TabIndex = 6;
                lblDateDebut.Text = r.DateDebut.ToString();

                //lblDateFin
                lblDateFin.AutoSize = true;
                lblDateFin.Location = new System.Drawing.Point(112, 17);
                lblDateFin.Name = "lblDateFin";
                lblDateFin.Size = new System.Drawing.Size(50, 20);
                lblDateFin.TabIndex = 7;
                lblDateFin.Text = r.DateFin.ToString();

                //lblDatePayeArrhes
                lblDatePayeArrhes.AutoSize = true;
                lblDatePayeArrhes.Location = new System.Drawing.Point(190, 17);
                lblDatePayeArrhes.Name = "lblDatePayeArrhes";
                lblDatePayeArrhes.Size = new System.Drawing.Size(50, 20);
                lblDatePayeArrhes.TabIndex = 12;
                lblDatePayeArrhes.Text = r.DatePayeArrhes.ToString();
                lblDatePayeArrhes.Click += new System.EventHandler(this.lblHotel_Click);

                //lblArrhes
                lblArrhes.AutoSize = true;
                lblArrhes.Location = new System.Drawing.Point(297, 17);
                lblArrhes.Name = "lblArrhes";
                lblArrhes.Size = new System.Drawing.Size(50, 20);
                lblArrhes.TabIndex = 13;
                lblArrhes.Text = r.Arrhes.ToString();
                lblArrhes.Click += new System.EventHandler(this.lblCategorie_Click);

                //lblUserUsername
                lblUserUsername.AutoSize = true;
                lblUserUsername.Location = new System.Drawing.Point(552, 17);
                lblUserUsername.Name = "lblUserUsername";
                lblUserUsername.Size = new System.Drawing.Size(50, 20);
                lblUserUsername.TabIndex = 16;
                lblUserUsername.Text = r.User.Username;

                //lblChambreId
                lblChambreId.AutoSize = true;
                lblChambreId.Location = new System.Drawing.Point(470, 17);
                lblChambreId.Name = "lblChambreId";
                lblChambreId.Size = new System.Drawing.Size(50, 20);
                lblChambreId.TabIndex = 15;
                lblChambreId.Text = r.ChambreId.ToString();

                //lblClientCin
                lblClientCin.AutoSize = true;
                lblClientCin.Location = new System.Drawing.Point(389, 17);
                lblClientCin.Name = "lblClientCin";
                lblClientCin.Size = new System.Drawing.Size(50, 20);
                lblClientCin.TabIndex = 14;
                lblClientCin.Text = r.Client.Cin;


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
                Edit.Location = new System.Drawing.Point(740, 3);
                Edit.Name = r.Id.ToString();
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
                Delete.Location = new System.Drawing.Point(830, 3);
                Delete.Name = "Delete";
                Delete.Size = new System.Drawing.Size(58, 48);
                Delete.TabIndex = 4;
                Delete.TextColor = System.Drawing.Color.White;
                Delete.UseVisualStyleBackColor = false;
                Delete.Click += (s, e) => Delete_Click(s, e, r);


                //Controls
                LpPanel.Controls.Add(lblUserUsername);
                LpPanel.Controls.Add(lblChambreId);
                LpPanel.Controls.Add(lblClientCin);
                LpPanel.Controls.Add(lblArrhes);
                LpPanel.Controls.Add(lblDatePayeArrhes);
                LpPanel.Controls.Add(lblDateFin);
                LpPanel.Controls.Add(lblDateDebut);
                LpPanel.Controls.Add(Edit);
                LpPanel.Controls.Add(Delete);
                this.Controls.Add(LpPanel);

                y = y + 50;
            }
        }

        private void Delete_Click(object sender, EventArgs e, Reservation r)
        {
            Database database = new Database();
            database.Entry(r).State = EntityState.Deleted;
            database.SaveChanges();
            r.Chambre.Reserved = true;
        }
    }
}
