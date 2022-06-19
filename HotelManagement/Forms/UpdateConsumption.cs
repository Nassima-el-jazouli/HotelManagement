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
    public partial class UpdateConsumption : Form
    {
        private Prestation prestation;

        public UpdateConsumption()
        {
            InitializeComponent();
        }

        public UpdateConsumption(Prestation prestation)
        {
            InitializeComponent();
            this.prestation = prestation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            prestation.Categorie = txtCategorie.Text;
            prestation.SousCategorie = txtSousCategorie.Text;
            prestation.Prix = Int32.Parse(txtPrice.Text);
            prestation.Description = txtDescription.Text;
            database.Prestations.Attach(prestation);
            database.Entry(prestation).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }

        private void UpdateConsumption_Load(object sender, EventArgs e)
        {
            txtCategorie.Text = prestation.Categorie;
            txtSousCategorie.Text = prestation.SousCategorie;
            txtPrice.Text = prestation.Prix.ToString();
            txtDescription.Text = prestation.Description;
        }
    }
}
