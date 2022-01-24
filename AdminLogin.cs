using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string password = "Admin";
            if (pass.Text==password)
            {
                this.Close();
                Sellers sell = new Sellers();
                sell.Show();
               
                
            }
            else
            {
                MessageBox.Show("Invalid Admin Password");
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
