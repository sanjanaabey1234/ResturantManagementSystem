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
    public partial class staffdrinks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public staffdrinks()
        {
            InitializeComponent();
        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView20_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void staffdrinks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet23.admindrink' table. You can move, or remove it, as needed.
            this.admindrinkTableAdapter.Fill(this.rESTURANTDATABASE2DataSet23.admindrink);
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet12.drinks' table. You can move, or remove it, as needed.
            

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            int a;
            int b;

            a = Convert.ToInt32(this.txtdid11.Text);


            b = a;

            this.txtproid11.Text = b.ToString();

            con.Open();
            SqlCommand com= new SqlCommand("Select productid,productname,productprice from admindrink where productid=@productid",con);
            com.Parameters.AddWithValue("productid", txtdid11.Text);
            SqlDataReader reader1;
            reader1= com.ExecuteReader();
            if(reader1.Read())
            {
                txtpn11.Text= reader1["productname"].ToString();
                txtpp11.Text = reader1["productprice"].ToString() ;

            }
            else
            {
                MessageBox.Show("no data found");
            }

            con.Close();
             
            
        }

        private void dataGridView20_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            SqlCommand com2 = new SqlCommand("SELECT * FROM admindrink", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView20.DataSource = dt;
            
            con.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int price;
            int quantity;
            int total;

            price = Convert.ToInt32(this.txtpp11.Text);
            quantity = Convert.ToInt32(this.txtpq11.Text);

            total = price * quantity;



            this.txtt11.Text = total.ToString();
        }

        private void btndataaddview_Click(object sender, EventArgs e)
        {
            

            con.Open();

            string sqlinsert = "INSERT INTO staffdrink(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@productid", this.txtdid11.Text);
            com.Parameters.AddWithValue("@productname", this.txtpn11.Text);
            com.Parameters.AddWithValue("@productprice", this.txtpp11.Text);
            com.Parameters.AddWithValue("@quantity", this.txtpq11.Text);
            com.Parameters.AddWithValue("@total", this.txtt11.Text);

            com.ExecuteNonQuery();



            string sqlinsert3 = "INSERT INTO finalreport(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com3 = new SqlCommand(sqlinsert3, con);
            com3.Parameters.AddWithValue("@productid", this.txtproid11.Text);
            com3.Parameters.AddWithValue("@productname", this.txtpn11.Text);
            com3.Parameters.AddWithValue("@productprice", this.txtpp11.Text);
            com3.Parameters.AddWithValue("@quantity", this.txtpq11.Text);
            com3.Parameters.AddWithValue("@total", this.txtt11.Text);

            int ret3 = com3.ExecuteNonQuery();
            MessageBox.Show("product inserted" + ret3, "information");

            string sqlview = "SELECT * FROM staffdrink";
            SqlCommand com2 = new SqlCommand(sqlview, con);

            SqlDataAdapter sda = new SqlDataAdapter(com2);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            this.txtdid11.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtpn11.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtpp11.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtpq11.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtt11.Text = ds.Tables[0].Rows[0][4].ToString();

            this.dataGridView25.DataSource = ds.Tables[0];

            txtdid11.Clear();
            txtpn11.Clear();
            txtpp11.Clear();
            txtpq11.Clear();
            txtt11.Clear();
            txtproid11.Clear();

            con.Close();

          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataGridView25.DataSource = null;

            con.Open();

            string sqldeleteall = "TRUNCATE TABLE staffdrink";
            SqlCommand com2 = new SqlCommand(sqldeleteall, con);

            com2.ExecuteNonQuery();

            con.Close();

        }

        private void btnaddfb_Click(object sender, EventArgs e)
        {
            con.Open();

            string sqlinsert = "INSERT INTO finalreport(productid,productname,productprice,quantity,total)values(@productid,@productname,@productprice,@quantity,@total)";
            SqlCommand com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@productid", this.txtproid11.Text);
            com.Parameters.AddWithValue("@productname", this.txtpn11.Text);
            com.Parameters.AddWithValue("@productprice", this.txtpp11.Text);
            com.Parameters.AddWithValue("@quantity", this.txtpq11.Text);
            com.Parameters.AddWithValue("@total", this.txtt11.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("product inserted" + ret, "information");

            con.Close();
        }

        private void datadeleteview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("DELETE staffdrink WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", this.txtpid11.Text);


            com.ExecuteNonQuery();
            

            SqlCommand com2 = new SqlCommand("SELECT * FROM staffdrink", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView25.DataSource = dt;

            SqlCommand com3 = new SqlCommand("DELETE finalreport WHERE productid=@productid", con);
            com3.Parameters.AddWithValue("@productid", this.txtpid11.Text);

            com3.ExecuteNonQuery();
            MessageBox.Show("product deleted");

            con.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {

        }

        private void btndataupdateview_Click(object sender, EventArgs e)
        {
       
        }

        private void calculate3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("staff");
            this.Hide();
            ds.ShowDialog();
        }

        private void txtdid11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpn11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpp11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpq11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtt11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproid11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpid11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
