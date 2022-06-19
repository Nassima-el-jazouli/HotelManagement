using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
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

namespace HotelManagement.Forms
{
    public partial class UpdateReservation : Form
    {
        public Reservation reservation;

        public UpdateReservation()
        {
            InitializeComponent();
        }

        public UpdateReservation(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Chambre> Chambres = database.Chambres.ToList();
            List<Client> Clients = database.Clients.ToList();
            cmbClientCin.DataSource = Clients;
            cmbClientCin.ValueMember = "Id";
            cmbClientCin.DisplayMember = "Cin";
            cmbClientCin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbClientCin.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbChambreId.DataSource = Chambres;
            cmbChambreId.ValueMember = "Id";
            cmbChambreId.DisplayMember = "Id";
            cmbChambreId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbChambreId.AutoCompleteSource = AutoCompleteSource.ListItems;
            DateDebut.Value = reservation.DateDebut;
            DateFin.Value = reservation.DateFin;
            DatePayeArrhes.Value = reservation.DatePayeArrhes;
            txtArrhes.Text = reservation.Arrhes.ToString();
            cmbClientCin.SelectedValue = reservation.ClientId;
            cmbChambreId.SelectedValue = reservation.ChambreId;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            reservation.UserId = 1;
            reservation.ClientId = Int16.Parse(cmbClientCin.SelectedValue.ToString());
            reservation.ChambreId = Int16.Parse(cmbChambreId.SelectedValue.ToString());
            reservation.Arrhes = Int32.Parse(txtArrhes.Text.ToString());
            reservation.DateDebut = DateDebut.Value;
            reservation.DateFin = DateFin.Value;
            reservation.DatePayeArrhes = DatePayeArrhes.Value;
            database.Reservations.Attach(reservation);
            database.Entry(reservation).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }
    }
}
