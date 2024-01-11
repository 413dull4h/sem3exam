using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double[,] a = new double[3, 3];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-20, 20);
                    a[i, j] = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ($"Определитель матрицы = {Det(a, 3)}");
        }
        static public double Det(double[,] mas, int razmer)
        {

            if (razmer == 2)
            {
                return (mas[0, 0] * mas[1, 1] - mas[0, 1] * mas[1, 0]);
            }
            else if (razmer == 1)
            {
                return (mas[0, 0]);
            }
            else if (razmer >= 3)
            {
                double det = 0;
                int a, b;
                double[,] newA = new double[razmer - 1, razmer - 1];
                for (int i = 0; i < razmer; i++)
                {
                    a = 0;
                    for (int j = 1; j < razmer; j++)
                    {
                        b = 0;
                        for (int c = 0; c < razmer; c++)
                        {
                            if (c != i)
                            {
                                newA[a, b] = mas[j, c];
                                b++;
                            }
                        }
                        a++;
                    }
                    det += Math.Pow(-1, i + 2) * mas[0, i] * Det(newA, razmer - 1);

                }
                return det;
            }
            return 0;
        }
    }
}
