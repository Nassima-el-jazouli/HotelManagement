using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Tools;
using HotelManagement.Data;

namespace HotelManagement.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Client client = new Client();
            client.Id = database.Clients.Max(x => x.Id) + 1;
            client.Prenom = txtPrenom.Text;
            client.Nom = txtNom.Text;
            client.Cin = txtCin.Text;
            client.Adresse = txtAdresse.Text;
            client.NumTel = txtNumTel.Text;
            client.Pays = txtCountry.Text;
            client.Email = txtEmail.Text;
            client.Ville = txtCity.Text;
            client.CodePostal = txtCodePostal.Text;
            AddReservation addReservation = new AddReservation();
            addReservation.Show();
            database.Clients.Add(client);
            database.SaveChanges();
            this.Close();
        }
    }
}
