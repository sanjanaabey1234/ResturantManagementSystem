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

namespace WindowsFormsApp36
{
    public partial class mangerreport : Form
    {
        public mangerreport()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard("manager");
            this.Hide();
            ds.ShowDialog();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = "C:\\Users\\User\\OneDrive\\Desktop\\New folder (8)\\New folder (7)\\New folder\\WindowsFormsApp36\\CrystalReport2.rpt";
        }
    }
}
