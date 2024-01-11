using System;
using System.Collections.Generic;
using System.Numerics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam28
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(richTextBox1.Text);
            double b = Convert.ToDouble(richTextBox2.Text);
            double c = Convert.ToDouble(richTextBox3.Text);
            double d = Convert.ToDouble(richTextBox4.Text);
            richTextBox5.Text = ($"{a - c} {b - d}i, целая часть {a - c}, мнимая часть {b - d}i");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(richTextBox1.Text);
            double b = Convert.ToDouble(richTextBox2.Text);
            double c = Convert.ToDouble(richTextBox3.Text);
            double d = Convert.ToDouble(richTextBox4.Text);
            double niz = c * c + d * d;
            double verh_bez_i = (a * c + -(b * -(d))) / niz;
            double verh_s_i = (b * c + a * (-d)) / niz;
            richTextBox5.Text = ($"{verh_bez_i} + {verh_s_i}i, целая часть {verh_bez_i}, мнимая часть {verh_s_i}i");

        }
    }
}
