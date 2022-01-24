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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91997\Documents\Visual Studio 2012\Pharmacy Management System\Pharmacy Management System\Pharm.mdf;Integrated Security=True");

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Manufacture man = new Manufacture();
            man.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        public void sellers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Sellers ", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Load(dr);
            sellercb.ValueMember = "Name";
            sellercb.DataSource = dt;
            con.Close();
          //  string sellerscb = sellercb.SelectedValue.ToString();
        }

        public void totals()
        {
            con.Open();
            string query = "select sum(Total) from Selling where SellerName = '" + sellercb.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            sells.Text = dt.Rows[0][0].ToString();
            

            con.Close();
     
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sellers();
           // totals();

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select count(*)  from Selling ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Customer.Text = dt.Rows[0][0].ToString();
           

            SqlDataAdapter da1 = new SqlDataAdapter("select count(*)  from Medicine ", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Medicine.Text = dt1.Rows[0][0].ToString();


            SqlDataAdapter da2 = new SqlDataAdapter("select count(*)  from Manufacture ", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Manu.Text = dt2.Rows[0][0].ToString();


            SqlDataAdapter da3 = new SqlDataAdapter("select count(*)  from Sellers ", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            Sell.Text = dt3.Rows[0][0].ToString();
            /*----------------------------------------------------*/


            SqlDataAdapter da4 = new SqlDataAdapter("select max(SellerName)  from Selling  ", con);
            // select SellerName from Selling where SellerName in(select max(SellerName) from Selling where Total in ( select sum(Total) from Selling) group by SellerName )
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            sellerB.Text = dt4.Rows[0][0].ToString();

            SqlDataAdapter da5 = new SqlDataAdapter("select sum(Total)  from Selling  ", con);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            sales.Text = dt5.Rows[0][0].ToString();


            con.Close();

        }

        private void Medicine_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void sellercb_SelectedIndexChanged(object sender, EventArgs e)
        {
           // totals();

        }

        private void sellercb_SelectedValueChanged(object sender, EventArgs e)
        {
           // sellers();
           // totals();
        }

        private void sellercb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            totals();
        }

        private void sales_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
