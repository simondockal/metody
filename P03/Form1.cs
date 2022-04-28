using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!="")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int obsah;
                double uhlopricka;
                if(a==b)
                {
                    obsah = a * a;
                    uhlopricka = Math.Sqrt(a * a + a * a);
                    label3.Text = "Uhlopricka ctverce je " + uhlopricka.ToString("F2");
                    label4.Text = "Obsah ctverce je " + obsah;
                }
                else
                {
                    obsah = a*b;
                    uhlopricka = Math.Sqrt(a * a + b * b);
                    label3.Text = "Uhlopricka obdelniku je " + uhlopricka.ToString("F2");
                    label4.Text = "Obsah obdelniku je " + obsah;
                }
            }
        }
    }
}
