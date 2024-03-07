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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mainform;

namespace WindowsFormsApp36
{
    public partial class redriceandcurry : Form
    {
        String imageUrl = null;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public redriceandcurry()
        {
          
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            SqlCommand com = new SqlCommand("INSERT INTO addminred(productid,productname,productprice,containsofmeal,Photo,PhotoUrl)VALUES(@productid,@productname,@productprice,@containsofmeal,@Photo,@PhotoUrl)", con);
            com.Parameters.AddWithValue("@productid", txtproid.Text);
            com.Parameters.AddWithValue("@productname", txtproductname.Text);
            com.Parameters.AddWithValue("@productprice", txtproductprice.Text);
            com.Parameters.AddWithValue("@containsofmeal", txtcontains.Text);
            com.Parameters.AddWithValue("@Photo", arr);
            com.Parameters.AddWithValue("@PhotoUrl", imageUrl);

            com.ExecuteNonQuery();
            MessageBox.Show("product saved");

            SqlCommand com2 = new SqlCommand("SELECT * FROM addminred", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet15.addminred' table. You can move, or remove it, as needed.
            this.addminredTableAdapter.Fill(this.rESTURANTDATABASE2DataSet15.addminred);
            // TODO: This line of code loads data into the 'rESTURANTDATABASE2DataSet.riceandcurry' table. You can move, or remove it, as needed.
           

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand com = new SqlCommand("DELETE addminred WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", txtproductid.Text);


            com.ExecuteNonQuery();
            MessageBox.Show("product deleted");

            SqlCommand com2 = new SqlCommand("SELECT * FROM addminred", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn2browse2_click(object sender, EventArgs e)
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
            SqlCommand com = new SqlCommand("UPDATE addminred SET productName=@productName,productprice=@productprice,containsofmeal=@containsofmeal,Photo=@Photo,PhotoUrl=@PhotoUrl WHERE productid=@productid", con);
            com.Parameters.AddWithValue("@productid", txtpid.Text);
            com.Parameters.AddWithValue("@ProductName", txtpname.Text);
            com.Parameters.AddWithValue("@productprice", txtpprice.Text);
            com.Parameters.AddWithValue("@containsofmeal", txtcontains2.Text);
            com.Parameters.AddWithValue("@Photo", arr);
            com.Parameters.AddWithValue("@PhotoUrl", imageUrl);

            com.ExecuteNonQuery();
            MessageBox.Show("product updated");

            SqlCommand com2 = new SqlCommand("SELECT * FROM addminred", con);
            DataTable dt = new DataTable();
            dt.Load(com2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void whiterice_Click(object sender, EventArgs e)
        {
            whitericeandcurry frm = new whitericeandcurry();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
