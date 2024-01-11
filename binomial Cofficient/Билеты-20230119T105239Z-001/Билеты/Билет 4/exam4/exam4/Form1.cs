using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam4
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
                int MinCells = 500;
                int MaxRows = -500;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i % 2 != 0)
                        {
                            if (MinCells > Convert.ToInt16(dataGridView1.Rows[j].Cells[i].Value))
                            {
                                MinCells = Convert.ToInt16(dataGridView1.Rows[j].Cells[i].Value);
                            }
                        }
                        if (i % 2 == 0)
                        {
                            if (MaxRows < Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                MaxRows = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                            }
                        }
                    }
                }
                richTextBox1.Text = ($"разность = {MinCells - MaxRows}, а частное = {MinCells / MaxRows}");
            }
            catch
            {
                MessageBox.Show("Найдены пустые значения");
            }

        }
    }
}
