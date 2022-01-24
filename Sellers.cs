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
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void show()
        {
            con.Open();
            string Query = "select * from Sellers";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }


        private void add_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Manufacture man = new Manufacture();
            man.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Sellers values('" + name.Text + "','" + add.Text + "','" + phone.Text + "','" + pass.Text + "');", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " insert suuccesfully");
                con.Close();
                show();

                name.Text = "";
                add.Text = "";
                pass.Text = "";


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
                con.Open();
                SqlCommand cmd = new SqlCommand("update  Sellers set Name='" + name.Text + "',Address='"+add.Text+"',Phone='"+phone.Text+"',Password='"+pass.Text+"' where ID="+id.Text+";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " updated suuccesfully");
                con.Close();
                show();

                name.Text = "";
                add.Text = "";
                phone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Sellers where ID=" + id.Text + ";", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text + " deleted suuccesfully");
                con.Close();
                show();

                name.Text = "";
                add.Text = "";
                phone.Text = "";

                pass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            add.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            pass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Close();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Manufacture man = new Manufacture();
            man.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
            this.Hide();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void add_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}

