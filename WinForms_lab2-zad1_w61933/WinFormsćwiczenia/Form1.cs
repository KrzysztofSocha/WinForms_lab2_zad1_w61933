using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms_lab2_zad1_w61933
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lWynik_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            float x1 = (float)Convert.ToDouble(x);
            if(x1 < 101 || x1 > 250)
            {
                lwynik2.Text = "Nie poprawne dane";
            }
            else
            {
                if (chbStandardowa.Checked && chbIdealna.Checked==false && (rbMan.Checked || rbWoman.Checked))
                {

                    lwynik2.Text = "Waga standardowa wynosi: " + Convert.ToString(x1 - 100) + "kg";

                }
                else if (chbIdealna.Checked && rbMan.Checked && chbStandardowa.Checked==false)
                {
                    lwynik2.Text = "Waga idealna wynosi: " + Convert.ToString((x1-100)*0.9) + "kg";
                }else if (chbIdealna.Checked && rbWoman.Checked && chbStandardowa.Checked == false)
                {
                    lwynik2.Text = "Waga idealna wynosi: " + Convert.ToString((x1-100)*0.85) + "kg";
                }
                else if(chbIdealna.Checked && chbStandardowa.Checked && rbMan.Checked)
                {
                    lwynik2.Text = "Waga idealna wynosi: " + Convert.ToString((x1 - 100) * 0.9) + "kg "
                        + "Waga standardowa wynosi: " + Convert.ToString(x1 - 100) + "kg"; 
                }
                else if (chbIdealna.Checked && chbStandardowa.Checked && rbWoman.Checked)
                {
                    lwynik2.Text = "Waga idealna wynosi: " + Convert.ToString((x1 - 100) * 0.85) + "kg "
                        + "Waga standardowa wynosi: " + Convert.ToString(x1 - 100) + "kg";
                }
                else if(chbStandardowa.Checked==false && chbIdealna.Checked == false)
                {
                    lwynik2.Text = "Wybierz rodzaj wagi do obliczenia";
                }
                else
                {
                    lwynik2.Text = "Wybierz płeć";
                }
            }
            

        }

        private void chbStandardowa_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
