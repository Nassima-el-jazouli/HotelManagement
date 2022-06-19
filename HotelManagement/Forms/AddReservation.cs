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

namespace HotelManagement.Forms
{
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Reservation reservation = new Reservation();
            //reservation.Id = database.Users.Max(x => x.Id) + 1;
            reservation.UserId = 1;
            reservation.ClientId = Int16.Parse(cmbClientCin.SelectedValue.ToString());
            reservation.ChambreId = Int16.Parse(cmbChambreId.SelectedValue.ToString());
            reservation.Arrhes = Int32.Parse(txtArrhes.Text.ToString());
            reservation.DateDebut = DateDebut.Value;
            reservation.DateFin = DateFin.Value;
            reservation.DatePayeArrhes = DatePayeArrhes.Value;
            database.Reservations.Add(reservation);
            database.SaveChanges();
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbChambreId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddReservation_Load(object sender, EventArgs e)
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
        }
    }
}
