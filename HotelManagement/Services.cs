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

namespace HotelManagement
{
    public partial class Services : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );
        public Services()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        

        private void Services_Load_1(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 10, 10));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 30, 30));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 10, 10));
            button8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button8.Width, button8.Height, 10, 10));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 10, 10));
            button10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button10.Width, button10.Height, 10, 10));
            button11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button11.Width, button11.Height, 10, 10));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AboutUs1 aboutUs = new AboutUs1();
            this.Hide();
            aboutUs.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}