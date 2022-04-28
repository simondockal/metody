using poleUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {

                int n = Convert.ToInt32(textBox1.Text);
                int[] pole;
                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    int prvni = Convert.ToInt32(textBox2.Text);
                    int druhe = Convert.ToInt32(textBox3.Text);
                    pole = Pole.generate(n, prvni, druhe);

                }
                else
                {
                    pole = Pole.generate(n);
                }
                Pole.zobrazeni(listBox1, pole);
                int pocty = Pole.pocets(pole, out int licha);
                label4.Text = "pocet lichych cisel je " + licha;
                label5.Text = "soucet sudych cisel je " + pocty;
                bool ros = Pole.rostouci(pole);
                if (!ros)
                {
                    label7.Text = "Pole neni rostouci";
                }
                else
                {
                    label7.Text = "Pole je roustouci";
                }
                Pole.vymena(pole);
                Pole.zobrazeni(listBox2, pole);
            }
        }
    }
}