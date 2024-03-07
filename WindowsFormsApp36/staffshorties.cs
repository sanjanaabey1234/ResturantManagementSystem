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
using Mainform;

namespace WindowsFormsApp36
{
    public partial class staffshorties : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public staffshorties()
        {
            InitializeComponent();
        }

        private void staffshorties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet26.staffsorties' table. You can move, or remove it, as needed.
            this.staffsortiesTableAdapter.Fill(this.rESTURANTDATABASE2DataSet26.staffsorties);
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet25.adminshortieses' table. You can move, or remove it, as needed.
            this.adminshortiesesTableAdapter.Fill(this.rESTURANTDATABASE2DataSet25.adminshortieses);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            a = Convert.ToInt32(this.txtsid.Text);


            b = a;

            this.txtprosid.Text = b.ToString();

            con.Open();

            if (txtsid.Text!="")
            {
                SqlCommand com = new SqlCommand("SELECT productname,productprice FROM adminshortieses where productid=@productid", con);
                com.Parameters.AddWithValue("@productid", int.Parse(txtsid.Text));
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtpn.Text = dr.GetValue(0).ToString();
                    txtpp.Text = dr.GetValue(1).ToString();
                }

                con.Close();

            }
           
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int price;
            int quantity;
            int total;

            price = Convert.ToInt32(this.txtpp.Text);
            quantity = Convert.ToInt32(this.txtpq.Text);

            total = price * quantity;



            this.txtt.Text = total.ToString();
        }

        private void btndataaddview_Click(object sender, EventArgs e)
        {
            con.Open();

            string sqlinsert = "INSERT INTO staffsorties(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@productid", this.txtsid.Text);
            com.Parameters.AddWithValue("@productname", this.txtpn.Text);
            com.Parameters.AddWithValue("@productprice", this.txtpp.Text);
            com.Parameters.AddWithValue("@quantity", this.txtpq.Text);
            com.Parameters.AddWithValue("@total", this.txtt.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("no of records inserted" + ret, "information");

            string sqlinsert3 = "INSERT INTO finalreport(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com3 = new SqlCommand(sqlinsert3, con);
            com3.Parameters.AddWithValue("@productid", this.txtprosid.Text);
            com3.Parameters.AddWithValue("@productname", this.txtpn.Text);
            com3.Parameters.AddWithValue("@productprice", this.txtpp.Text);
            com3.Parameters.AddWithValue("@quantity", this.txtpq.Text);
            com3.Parameters.AddWithValue("@total", this.txtt.Text);

            int ret3 = com3.ExecuteNonQuery();
            MessageBox.Show("product inserted" + ret3, "information");


            string sqlview = "SELECT * FROM staffsorties";
            SqlCommand com2 = new SqlCommand(sqlview, con);

            SqlDataAdapter sda = new SqlDataAdapter(com2);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            this.txtsid.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtpn.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtpp.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtpq.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtt.Text = ds.Tables[0].Rows[0][4].ToString();

            this.dataGridView26.DataSource = ds.Tables[0];

            txtsid.Clear();
            txtpn.Clear();
            txtpp.Clear();
            txtpq.Clear();
            txtt.Clear();
            txtprosid.Clear();

            con.Close();
        }

        private void dataGridView27_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            SqlCommand com2 = new SqlCommand("SELECT * FROM adminshortieses", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView27.DataSource = dt;

            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataGridView26.DataSource = null;

            con.Open();

            string sqldeleteall = "TRUNCATE TABLE staffsorties";
            SqlCommand com2 = new SqlCommand(sqldeleteall, con);

            com2.ExecuteNonQuery();

            con.Close();
        }

        private void btnaddfb_Click(object sender, EventArgs e)
        {
            con.Open();

            string sqlinsert = "INSERT INTO finalreport(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@productid", this.txtprosid.Text);
            com.Parameters.AddWithValue("@productname", this.txtpn.Text);
            com.Parameters.AddWithValue("@productprice", this.txtpp.Text);
            com.Parameters.AddWithValue("@quantity", this.txtpq.Text);
            com.Parameters.AddWithValue("@total", this.txtt.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("product inserted" + ret, "information");

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void datadeleteview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("DELETE staffsorties WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", this.txtpid11.Text);


            com.ExecuteNonQuery();


            SqlCommand com2 = new SqlCommand("SELECT * FROM staffsorties", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView26.DataSource = dt;

            SqlCommand com3 = new SqlCommand("DELETE finalreport WHERE productid=@productid", con);
            com3.Parameters.AddWithValue("@productid", this.txtpid11.Text);

            com3.ExecuteNonQuery();
            MessageBox.Show("product deleted");

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("staff");
            this.Hide();
            ds.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
