using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.ColumnCount = 2;
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 2;

        }
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-20, 20);
                    a[i, j] = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                    dataGridView2.Rows[i].Cells[j].Value = rnd.Next(-20, 20);
                    b[i, j] = Convert.ToInt16(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }
                    dataGridView3.Rows[i].Cells[j].Value = temp;
                }
            }
        }
    }
}
