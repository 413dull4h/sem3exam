using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam16
{
    public partial class Form1 : Form
    {
        Class1 matrix = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] arrayA = { {Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text) },
            {Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text) },
            {Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text), Convert.ToInt16(textBox11.Text) } };
            double[,] arrayB = { { Convert.ToInt16(textBox4.Text)}, {Convert.ToInt16(textBox8.Text)}, {Convert.ToInt16(textBox12.Text)} };
            double deter = Class1.Det(arrayA, 3);
            double[,] allyMatrix = new double[3, 3];
            double[,] arrayAns = new double[3, 1];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allyMatrix[i, j] = Class1.UnionMatrix(arrayA, i, j, 3) / deter;
                    
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        temp += allyMatrix[i, k] * arrayB[k, j];
                    }
                    arrayAns[i, j] = temp;
                }
            }
            richTextBox1.Text = ($"x1 = {arrayAns[0, 0]}, x2 = {arrayAns[1, 0]}, x3 = {arrayAns[2, 0]}");

        }
    }
}
