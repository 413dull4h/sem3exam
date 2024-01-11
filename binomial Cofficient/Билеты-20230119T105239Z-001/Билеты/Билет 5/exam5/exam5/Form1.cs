using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam5
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = -200;
            int index = 0;
            int summa = 0;
            int prizv = 1;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Math.Abs(Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value)) > max)
                        {
                            max = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                            index = i;
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    summa += Convert.ToInt16(dataGridView1.Rows[index].Cells[i].Value);
                    prizv *= Convert.ToInt16(dataGridView1.Rows[index].Cells[i].Value);
                }
                richTextBox1.Text = ($"Сумма {index+1} строки {summa}, а произведение {prizv}");
            }
            
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных");
            }
        }
    }
}
