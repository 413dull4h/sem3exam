using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int row = 0;
                int min = 500;
                int sum = 0;
                int mult = 1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (min > Math.Abs(Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value)))
                        {
                            row = i;
                            min = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    sum += Convert.ToInt16(dataGridView1.Rows[row].Cells[i].Value);
                    mult *= Convert.ToInt16(dataGridView1.Rows[row].Cells[i].Value);
                }
                richTextBox1.Text = ($"Сумма элементов = {sum}, а произведение = {mult}");
            }
            catch
            {
                MessageBox.Show("Найден пустой элемент");
            }
        }
    }
}
