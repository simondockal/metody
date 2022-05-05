using P03priklad;
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
               if(textBox3.Text=="")
               {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                    int obsah = Telesa.Obsah(a, b, out double uhlopricka);

                if(a==b)
                {
                    label3.Text = "Uhlopricka ctverce je " + uhlopricka.ToString("F2");
                    label4.Text = "Obsah ctverce je " + obsah;

                }
                else
                {
                    label3.Text = "Uhlopricka obdelniku je " + uhlopricka.ToString("F2");
                    label4.Text = "Obsah obdelniku je " + obsah;
                }

               }
               else
               {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox2.Text);
                    int hloubka = Convert.ToInt32(textBox3.Text);

                    double objem = Telesa.Objem(a, b, hloubka, out double telesnauhlopricka);
                    label4.Text = "Telesna uhlovpricka je " + telesnauhlopricka.ToString("F2");

                    if (a==b&&a==hloubka)
                    {
                        label3.Text = "Objem krychle je " + objem.ToString("F2");
                    }
                    else
                    {
                        label3.Text = "Objem kvadru je " + objem.ToString("F2");
                    }
               }


            }
        }
    }
}
