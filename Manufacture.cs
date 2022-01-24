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
    public partial class Manufacture : Form
    {
        public Manufacture()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");


        private void show()
        {
            con.Open();
            
            string Query="select * from Manufacture";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Manufacture_Load(object sender, EventArgs e)
        {
            show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Manufacture values('"+name.Text+"','"+address.Text+"','"+phone.Text+"');",con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            name.Text = "";
            address.Text = "";
            phone.Text = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            address.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            phone.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update  Manufacture set Name='" + name.Text + "',Address='" +address.Text + "',Phone='" + phone.Text + "' where ID=" + id.Text + ";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " updated suuccesfully");
                con.Close();
                show();

                name.Text = "";
                address.Text = "";
                phone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Manufacture where ID=" + id.Text + ";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " deleted suuccesfully");
                con.Close();
                show();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Customers cs = new Customers();
            cs.Show();
        }

    }
}
