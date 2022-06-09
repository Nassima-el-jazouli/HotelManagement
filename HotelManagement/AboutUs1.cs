using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AboutUs1 : Form
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
        public AboutUs1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            this.Hide();
            services.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IExplore", "https://www.youtube.com/watch?v=XgtmiWBZk2c");
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 10, 10));
            button8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button8.Width, button8.Height, 10, 10));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 10, 10));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
