using Mainform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp27;

namespace WindowsFormsApp36
{
    public partial class finalbill : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public finalbill()
        {
            InitializeComponent();
        }

        private void dataGridView41_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet14.finalreport' table. You can move, or remove it, as needed.
            this.finalreportTableAdapter.Fill(this.rESTURANTDATABASE2DataSet14.finalreport);
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet6.addfinal' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet5.addfinal' table. You can move, or remove it, as needed.
            

            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqldelete = "DELETE finalreport WHERE productid=@productid";
            SqlCommand com = new SqlCommand(sqldelete, con);
            com.Parameters.AddWithValue("@productid", this.txtproid.Text);
            

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("product deleted" + ret, "information");

            SqlCommand com2 = new SqlCommand("SELECT * FROM finalreport", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView41.DataSource = dt;
            
            con.Close();
            

        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            SqlCommand com2 = new SqlCommand("SELECT * FROM finalreport", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView41.DataSource = dt;

            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataGridView41.DataSource = null;

            con.Open();

            string sqldeleteall = "TRUNCATE TABLE finalreport";
            SqlCommand com2 = new SqlCommand(sqldeleteall, con);

            com2.ExecuteNonQuery();

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("staff");
            this.Hide();
            ds.ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {
            staffreport frm = new staffreport();
            this.Hide();
            frm.ShowDialog();
           

        }
    }
}
