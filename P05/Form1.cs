using MatematikaUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                string chain = textBox1.Text;
                int soucet= MatUtil.Obsahujecifru(chain, out int pocet);
                bool prv = MatUtil.Prvocislo(soucet);

                if(prv)
                {
                    label3.Text = "soucet je prvocislo";
                }
                else
                {
                    label3.Text = "soucet neni prvocislo";
                }
                label1.Text = "pocet cifer " + pocet;
                label2.Text = "soucet lichich cifer je " + soucet;
            }
        }
    }
}
