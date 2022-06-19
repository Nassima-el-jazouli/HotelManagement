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
    public partial class AddConsumption : Form
    {
        public AddConsumption()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Prestation prestation = new Prestation();
            prestation.Id = database.Prestations.Max(x => x.Id) + 1;
            prestation.Prix = Int32.Parse(txtPrice.Text.ToString());
            prestation.Description = txtDescription.Text;
            prestation.Categorie = txtCategorie.Text;
            prestation.SousCategorie = txtSousCategorie.Text;
            database.Prestations.Add(prestation);
            database.SaveChanges();
            this.Close();
        }

        private void AddConsumption_Load(object sender, EventArgs e)
        {
           
        }
    }
}
