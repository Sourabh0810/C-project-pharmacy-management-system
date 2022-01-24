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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void show()
        {
            con.Open();
            string names = Class1.name;
            String Query = "select * from Selling where SellerName='"+names+"';";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             dataGridView2.DataSource = ds.Tables[0];


            con.Close();

        }

        private void medicine()
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

        private void Selling_Load(object sender, EventArgs e)
        {
            seller.Text = "Welcome " + Class1.name;
            show();
            medicine();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
              // string quantity=qty.Text;
             //  string prices=price.Text;
              // int total =Int32.Parse(quantity) * Int32.Parse(prices);
              // string Totals = total.ToString();
                
             Int32 quantity=   Convert.ToInt32(qty.Text) ;
             Int32 Prices=  Convert.ToInt32(price.Text);
             Int32 totals=quantity * Prices;
            Total.Text = totals.ToString();
             string names = Class1.name;

                SqlCommand cmd = new SqlCommand("insert into Selling (Customer_Name,Medicine_Name, Quentity, Price, Total, SellerName ) values('"+textBox1.Text+"','"+name.Text+"', '"+qty.Text+"', '"+price.Text+"', "+totals+", '"+names+"');", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
                con.Close();
                show();
                name.Text = "";
                qty.Text = "";
                price.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Sellers sell = new Sellers();
            sell.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
           
            qty.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            price.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Selling where Id=" + id.Text + ";", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(name.Text+"deleted successfull");
                con.Close();
                Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();

            Int32 quantity = Convert.ToInt32(qty.Text);
            Int32 Prices = Convert.ToInt32(price.Text);
            Int32 totals = quantity * Prices;
            Total.Text = totals.ToString();

            SqlCommand cmd = new SqlCommand("update Selling set Quentity='"+qty.Text+"' , Total="+totals+" where  Id="+id.Text+" ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert successful");
            con.Close();
            show();
            name.Text = "";
            qty.Text = "";
            price.Text = "";
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }*/

    }
}
