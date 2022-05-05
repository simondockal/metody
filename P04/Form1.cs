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

namespace P04
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
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                int n = Convert.ToInt32(textBox1.Text);
                int x = Convert.ToInt32(textBox2.Text);
                int[] pole;
                pole = Pole.generate(n, -100, 101);
                Pole.zobrazeni(listBox1,pole);
                Pole.nulovani(pole, x);
                Pole.zobrazeni(listBox2, pole);
            }
        }
    }
}
