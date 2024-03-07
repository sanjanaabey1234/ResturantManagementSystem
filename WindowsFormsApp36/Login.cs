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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

         
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerform form = new Registerform();
            this.Hide();
            form.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //create connection
            
            con.Open();

            //create command
            String sql="SELECT * FROM logindetailstbl WHERE Username=@Username and Password=@Password";
            SqlCommand cmd = new SqlCommand(sql,con);

            cmd.Parameters.AddWithValue("@Username", this.userbox.Text);
            cmd.Parameters.AddWithValue("@Password", this.passwordbox.Text);
            //execute command
            SqlDataReader reader = cmd.ExecuteReader();

            if (this.userbox.Text == "admin" && this.passwordbox.Text == "admin123")
            {

                Dashboard dr = new Dashboard(this.userbox.Text);

                this.Hide();
                dr.Show();
            }
            else if (this.userbox.Text == "" && this.passwordbox.Text == "")
            {

                MessageBox.Show("Empty username box and password box", "warning");
            }
                else if (reader.Read())
                {
                Dashboard dr = new Dashboard(this.userbox.Text);
                this.Hide();
                dr.Show();

                }
                     else
                     {

                           MessageBox.Show("Invalid user Name and password", "WarningBox",MessageBoxButtons.OK,MessageBoxIcon.Error);
                     }


         con.Close();

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '*';
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
