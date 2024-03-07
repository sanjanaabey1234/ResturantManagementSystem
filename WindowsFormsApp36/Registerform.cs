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

namespace Mainform
{
    public partial class Registerform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");

        public Registerform()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Login lg= new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {

            //create connection
           
            con.Open();

            //create command
            String sql = "INSERT INTO logindetailstbl(Username,Password,Contact)VALUES(@Username,@Password,@Contact)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Username", this.newusernamebox.Text);
            cmd.Parameters.AddWithValue("@Contact", this.contectbox.Text);

            //check the confirm password 
            if (this.newuserspasswordbox.Text == confirmbox.Text)
            {
                cmd.Parameters.AddWithValue("@Password", this.newuserspasswordbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully Registration,You Can Login Now","Information");
                Login lg = new Login();
                this.Hide(); 
                lg.ShowDialog();
            }
            else
            {
                //clear confirm password text
                confirmbox.Text = "";
                errorProvider1.SetError(this.confirmbox, "Invalid confirm password");
            }


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
