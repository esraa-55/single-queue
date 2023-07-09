using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singlequeue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            double p = x / y;
            textBox4.Text = p.ToString();
            double l = (x / (y - x));
            textBox9.Text = l.ToString();
            double lq = p * l;
            textBox6.Text = lq.ToString();
            double w = (1 / (y - x));
            textBox7.Text = w.ToString();
            double wq = p * w;
            textBox8.Text = wq.ToString();
            int n = int.Parse(textBox3.Text);
            double sum = 0;
            double probanility;
            for (int i = 0; i <= 4; i++)
            {
                sum += (Math.Pow(p, i));

            }
            probanility = 1 - (1 - p) * sum;
            textBox5.Text = probanility.ToString();



















































































































































































































































































                    
            

        }
    }
}

