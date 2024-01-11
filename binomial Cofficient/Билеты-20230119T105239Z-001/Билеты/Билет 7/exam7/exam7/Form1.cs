using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-20, 20);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] array = new int[5] { 1, 1, 1, 1, 1 };
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array[i] *= Convert.ToInt16(dataGridView1.Rows[j].Cells[i].Value);
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = array[i];
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных");
            }
        }
    }
}
