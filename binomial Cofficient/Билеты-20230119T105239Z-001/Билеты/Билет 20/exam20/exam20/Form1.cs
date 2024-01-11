using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(richTextBox1.Text);
            double b = Convert.ToInt32(richTextBox2.Text);
            double c = Convert.ToInt32(richTextBox3.Text);
            double d = Convert.ToInt32(richTextBox4.Text);
            double f = Convert.ToInt32(richTextBox5.Text);
            double k = Convert.ToInt32(richTextBox6.Text);
            richTextBox7.Text = ($"x = {(Math.Log(b, a) + Math.Log(d, c)) / Math.Log(k, f)}");
        }
    }
}
