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

namespace HotelManagement.Forms
{
    public partial class UpdateCustomer : Form
    {
        private Client client;

        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public UpdateCustomer(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            txtPrenom.Text = client.Prenom;
            txtNom.Text = client.Nom;
            txtCin.Text = client.Cin;
            txtAdresse.Text = client.Adresse;
            txtNumTel.Text = client.NumTel;
            txtCountry.Text = client.Pays;
            txtEmail.Text = client.Email;
            txtCity.Text = client.Ville;
            txtCodePostal.Text = client.CodePostal;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            client.Prenom = txtPrenom.Text;
            client.Nom = txtNom.Text;
            client.Cin = txtCin.Text;
            client.Adresse = txtAdresse.Text;
            client.NumTel = txtNumTel.Text;
            client.Pays = txtCountry.Text;
            client.Email = txtEmail.Text;
            client.Ville = txtCity.Text;
            client.CodePostal = txtCodePostal.Text;
            database.Clients.Attach(client);
            database.Entry(client).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }
    }
}
