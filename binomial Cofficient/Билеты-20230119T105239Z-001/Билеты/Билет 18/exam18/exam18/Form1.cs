using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam18
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
            int[] arrayAns = new int[200];
            int[] array = new int[2];
            for (int i = -100; i < 100; i++)
            {
                if ((a * Math.Pow(i, 2)) + (b * i) + c == 0)
                {
                    arrayAns[i] = i;
                }
            }
            for (int i = 0; i < 200; i++)
            {
                if (arrayAns[i] != 0)
                {
                    richTextBox4.Text += ($"Корни: х = {arrayAns[i]}");
                }
            }
            
        }
    }
}
