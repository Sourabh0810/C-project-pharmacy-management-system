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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void show()
        {
            con.Open();
            string Query = "select * from Medicine";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        private void Medicine_Load(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            type.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            qty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            manu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


          

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manufacture man = new Manufacture();
            man.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine values('" + name.Text + "','" + type.Text + "'," + qty.Text + "," + price.Text + ",'" + manu.Text + "');", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data inserted successful");
                con.Close();
                show();
                name.Text = "";
                type.Text = "";
                qty.Text = "";
                price.Text = "";
                manu.Text = "";
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update  Medicine set Medicine_Name='" + name.Text + "',Medicine_Type='" + type.Text + "',Quentity='" + qty.Text + "',Price=" + price.Text + ",Manufacturer='" + manu.Text + "'where Id=" + id.Text + ";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " updated suuccesfully");
                con.Close();
                show();
                name.Text = "";
                type.Text = "";
                qty.Text = "";
                price.Text = "";
                manu.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Medicine where Id=" + id.Text + ";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " deleted suuccesfully");
                con.Close();
                show();
                name.Text = "";
                type.Text = "";
                qty.Text = "";
                price.Text = "";
                manu.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Manufacture manu = new Manufacture();
            manu.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
