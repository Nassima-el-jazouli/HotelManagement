using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Forms
{

    public partial class UpdateCategorie : Form
    {
        public Categorie categorie;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );

        public UpdateCategorie()
        {
            InitializeComponent();
        }

        public UpdateCategorie(Categorie categorie)
        {
            InitializeComponent();
            this.categorie = categorie;
        }

        private void UpdateCategrie_Load(object sender, EventArgs e)
        {
            txtName.Text = categorie.Name;
            txtPrice.Text = categorie.Prix.ToString();
            txtDescription.Text = categorie.Description;
            txtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtName.Width, txtName.Height, 10, 10));
            txtPrice.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPrice.Width, txtPrice.Height, 10, 10));
            txtDescription.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtDescription.Width, txtDescription.Height, 10, 10));
        }

        private void placeHolder1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void placeHolder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolder3_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            categorie.Name = txtName.Text;
            categorie.Prix = Int32.Parse(txtPrice.Text);
            categorie.Description = txtDescription.Text;
            database.Categories.Attach(categorie);
            database.Entry(categorie).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }
    }
}
