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
    public partial class bills : Form
    {
        public bills()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblReservationId.Text = "";
            lblChambreId.Text = "";
            lblClientName.Text = "";
            Total.Text = "";
            lblDate.Text = "";

            txtReservationId.Clear();
            txtChambreId.Clear();
            txtClientName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            lblChambreId.Text = txtChambreId.Text;
            lblClientName.Text = txtClientName.Text;
            lblReservationId.Text = txtReservationId.Text;
            Total.Text = "6500 Dhs";



            lblDate.Text = Date.Value.ToString();

        }
    }
}
