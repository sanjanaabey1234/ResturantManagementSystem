using Mainform;
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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp36
{
    public partial class staffreport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NSJLTCI\\SANJANA;Initial Catalog=RESTURANTDATABASE2;Integrated Security=True");
        public staffreport()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("staff");
            this.Hide();
            ds.ShowDialog();


        }


       
        private void staffreport_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            this.crystalReportViewer1.ReportSource = "C:\\Users\\User\\OneDrive\\Desktop\\New folder (8)\\New folder (7)\\New folder\\WindowsFormsApp36\\CrystalReport1.rpt";
           


        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
           


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
