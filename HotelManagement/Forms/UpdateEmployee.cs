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
    public partial class UpdateEmployee : Form
    {
        private User user;
        private Client client;

        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public UpdateEmployee(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            user.NumTel = txtNumTel.Text;
            user.Prenom = txtPrenom.Text;
            user.Nom = txtNom.Text;
            user.Cin = txtCin.Text;
            user.Adresse = txtAdresse.Text;
            user.NumTel = txtNumTel.Text;
            user.Username = txtUsername.Text;
            user.Email = txtEmail.Text;
            user.Password = txtUsername.Text;
            user.Role = (Role)Enum.Parse(typeof(Role), (string)cmbRole.SelectedValue);
            database.Users.Attach(user);
            database.Entry(user).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtPrenom.Text = user.Prenom;
            txtNom.Text = user.Nom;
            txtCin.Text = user.Cin;
            txtAdresse.Text = user.Adresse;
            txtNumTel.Text = user.NumTel;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            Database database = new Database();
            List<User> Users = database.Users.ToList();
            cmbRole.DataSource = Enum.GetNames(typeof(Role));
        }
    }
}
