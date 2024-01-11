using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(richTextBox1.Text);
                double x2 = Convert.ToDouble(richTextBox2.Text);
                double x3 = Convert.ToDouble(richTextBox3.Text);
                double x4 = Convert.ToDouble(richTextBox4.Text);
                double x5 = Convert.ToDouble(richTextBox5.Text);
                double x6 = Convert.ToDouble(richTextBox6.Text);
                double x7 = Convert.ToDouble(richTextBox7.Text);
                double x8 = Convert.ToDouble(richTextBox8.Text);
                double x = ((x1 / x2) - Math.Pow(x3, x4)) + ((x5 / x6) / (x7 / x8));
                MessageBox.Show(Convert.ToString(x));
            }
            catch
            {
                MessageBox.Show("Проверьте корректность данных");
            }
        }
    }
}
