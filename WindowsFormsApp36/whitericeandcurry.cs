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

namespace WindowsFormsApp36
{
    public partial class whitericeandcurry : Form
    {
        String imageUrl = null;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public whitericeandcurry()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO adminwhite(productid,productname,productprice,containsofmeal,Photo,PhotoUrl)VALUES(@productid,@productname,@productprice,@containsofmeal,@Photo,@PhotoUrl)", con);
            com.Parameters.AddWithValue("@productid", txtprodid.Text);
            com.Parameters.AddWithValue("@ProductName", txtproductname.Text);
            com.Parameters.AddWithValue("@productprice", txtproductprice.Text);
            com.Parameters.AddWithValue("@containsofmeal", txtcontains.Text);
            com.Parameters.AddWithValue("@Photo", arr);
            com.Parameters.AddWithValue("@PhotoUrl", imageUrl);

            com.ExecuteNonQuery();
            MessageBox.Show("product saved");

            SqlCommand com2 = new SqlCommand("SELECT * FROM adminwhite", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void whitericeandcurry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet17.adminwhite' table. You can move, or remove it, as needed.
            this.adminwhiteTableAdapter.Fill(this.rESTURANTDATABASE2DataSet17.adminwhite);
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet7.riceandcurry2' table. You can move, or remove it, as needed.
            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand com = new SqlCommand("DELETE adminwhite WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", txtproductid.Text);


            com.ExecuteNonQuery();
            MessageBox.Show("product deleted");

            SqlCommand com2 = new SqlCommand("SELECT * FROM adminwhite", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn2browse2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = pictureBox2.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand com = new SqlCommand("UPDATE adminwhite SET productName=@productName,productprice=@productprice,containsofmeal=@containsofmeal,Photo=@Photo,PhotoUrl=@PhotoUrl WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", txtpid.Text);
            com.Parameters.AddWithValue("@ProductName", txtpname.Text);
            com.Parameters.AddWithValue("@productprice", txtpprice.Text);
            com.Parameters.AddWithValue("@containsofmeal", txtcontains2.Text);
            com.Parameters.AddWithValue("@Photo", arr);
            com.Parameters.AddWithValue("@PhotoUrl", imageUrl);

            com.ExecuteNonQuery();
            MessageBox.Show("product updated");

            SqlCommand com2 = new SqlCommand("SELECT * FROM adminwhite", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void redrice_Click(object sender, EventArgs e)
        {
            redriceandcurry frm = new redriceandcurry();
            this.Hide();
            frm.Show();
        }

        private void yellowrice_Click(object sender, EventArgs e)
        {
            yellowriceandcurry frm = new yellowriceandcurry();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("admin");
            this.Hide();
            ds.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtcontains2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtpprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
