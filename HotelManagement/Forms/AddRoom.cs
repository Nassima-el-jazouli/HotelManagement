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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Chambre chambre = new Chambre();
            chambre.NumTel = txtNumTel.Text;
            int CatId = Int16.Parse(comboBox1.SelectedValue.ToString());
            chambre.CategorieId = CatId;
            int HotId = Int16.Parse(comboBox2.SelectedValue.ToString());
            chambre.HotelId = HotId;
            Hotel hotel = database.Hotels.Where(x => x.Id == chambre.HotelId).First();
            Classement classement = database.Classements.Where(x => x.Id == hotel.ClassementId).First();
            Categorie categorie = database.Categories.Where(x => x.Id == chambre.CategorieId).First();
            chambre.Prix = Int32.Parse((categorie.Prix * classement.Note).ToString());
            chambre.Reserved = false;
            database.Chambres.Add(chambre);
            database.SaveChanges();
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Categorie> Categories = database.Categories.ToList();
            List<Hotel> Hotels = database.Hotels.ToList();
            comboBox1.DataSource = Categories;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";

            comboBox2.DataSource = Hotels;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Nom";
        }
    }
}
