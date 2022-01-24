using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");

        private void Customers_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            con.Open();
            string Query = "select * from Selling";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manufacture man = new Manufacture();
            man.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            add.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
