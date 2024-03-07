using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Mainform;

namespace WindowsFormsApp36
{
    public partial class cprogressbar : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int BottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );
       
        public cprogressbar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Prograssbar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Prograssbar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Prograssbar1.Value += 1;
            Prograssbar1.Text = Prograssbar1.Value.ToString() + "%"; ;
            if(Prograssbar1.Value==100)
            {
                timer1.Enabled = false;
                Login frm = new Login();
                this.Hide();
                frm.ShowDialog();

            }



        }
    }
}
