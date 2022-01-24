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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public int startpoint = 0;
       

        private void myprogressbar_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            myprogressbar.Value = startpoint;
            percentage.Text = +startpoint+ "";
            if (myprogressbar.Value == 100)
            {
                myprogressbar.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();

                this.Hide();
                log.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
  }


        