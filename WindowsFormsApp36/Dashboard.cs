using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp27;
using WindowsFormsApp36;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Mainform
{
    public partial class Dashboard : MaterialForm
    {
        string type;
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager= MaterialSkinManager.Instance;
        public Dashboard(String S)
        {
            InitializeComponent();
            if (S == "admin")
            {
                REPORTBUTTON.Hide();
                finalbillbutton.Hide();
                this.BackColor= Color.LightBlue;
            }
            else if (S == "manager")
            {
                riceandcurrybutton.Hide();
                drinksbutton.Hide();
                shortiesbutton.Hide();
                finalbillbutton.Hide();
                this.BackColor = Color.Purple;

            }
               else
                  {

                   }
            type = S; 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
           
        }

        private void PLACEORDERBUTTON_Click(object sender, EventArgs e)
        {
           
        }

        private void riceandcurry_Click(object sender, EventArgs e)
        {
            if (type == "admin")
            {
                yellowriceandcurry frm = new yellowriceandcurry();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                customerrandc rc= new customerrandc();
                this.Hide();
                rc.ShowDialog();

            }


        }

        private void shortiesbutton_Click(object sender, EventArgs e)
        {
            if (type == "admin")
            {
                adminshorties frm = new adminshorties();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                staffshorties rc = new staffshorties();
                this.Hide();
                rc.ShowDialog();

            }
        }

        private void dinksbtn_Click(object sender, EventArgs e)
        {
            if (type == "admin")
            {
                addmindrinks frm = new addmindrinks();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                staffdrinks rc = new staffdrinks();
                this.Hide();
                rc.ShowDialog();

            }
        }

        private void finalbillbtn_Click(object sender, EventArgs e)
        {
            if (type == "staff")
            {
                finalbill frm = new finalbill();
                this.Hide();
                frm.ShowDialog();

            }
            
        }

        private void report_Click(object sender, EventArgs e)
        {
            if (type == "staff")
            {
                staffreport frm = new staffreport();
                this.Hide();
                frm.ShowDialog();

            }
            else if (type == "manager")
            {
                mangerreport frm = new mangerreport();
                this.Hide();
                frm.ShowDialog();

            }
        }

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(themeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;

            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900,Primary.Green500,Accent.Green400,TextShade.WHITE);
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
