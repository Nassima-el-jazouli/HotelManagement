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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            User user = new User();
            user.Id = database.Users.Max(x => x.Id) + 1;
            user.Prenom = txtPrenom.Text;
            user.Nom = txtNom.Text;
            user.Cin = txtCin.Text;
            user.Adresse = txtAdresse.Text;
            user.NumTel = txtNumTel.Text;
            user.Username = txtUsername.Text;
            user.Email = txtEmail.Text;
            user.Password = txtUsername.Text;
            user.Role = (Role)Enum.Parse(typeof(Role), (string)cmbRole.SelectedValue);
            database.Users.Add(user);
            database.SaveChanges();
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<User> Users = database.Users.ToList();
            cmbRole.DataSource = Enum.GetNames(typeof(Role));
        }
    }
}
