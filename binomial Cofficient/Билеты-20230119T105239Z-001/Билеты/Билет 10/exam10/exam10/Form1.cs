using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;
            
        }
        double[,] allyMatrix = new double[3, 3];
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
            
        }
        static public double UnionMatrix(double[,] mas, int num1 , int num2, int razmer)
        {
            double[,] podmass = new double[razmer - 1, razmer - 1];
            int indI = num1;
            int indB = num2;
            int s = 0;
            int s1 = 0;
            for (int ind1 = 0; ind1 < razmer; ind1++)
            {
                if (ind1 != indI)
                {
                    s1 = 0;
                    for (int ind2 = 0; ind2 < razmer; ind2++)
                    {
                        if (ind2 != indB)
                        {
                            podmass[s, s1] = mas[ind1, ind2];
                            s1++;
                        }
                    }
                    s++;
                }
            }
            return Math.Pow(-1, indB + indI + 2) * Det(podmass, razmer - 1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allyMatrix[j, i] = UnionMatrix(a, i, j, 3);
                    dataGridView2.Rows[j].Cells[i].Value = allyMatrix[j, i].ToString();
                }
            }
        }
    }
}
