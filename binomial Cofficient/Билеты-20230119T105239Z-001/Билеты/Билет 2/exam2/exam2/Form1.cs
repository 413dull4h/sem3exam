using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                int minRow = 500;
                int maxColumn = -500;
                for (int i = 0; i < 3; i++)
                {
                    if (minRow > Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value))
                    {
                        minRow = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                    }
                    if (maxColumn < Convert.ToInt16(dataGridView1.Rows[0].Cells[i].Value))
                    {
                        maxColumn = Convert.ToInt16(dataGridView1.Rows[0].Cells[i].Value);
                    }
                }
                richTextBox1.Text = ($"Максимальная сумма = {minRow + maxColumn}, а максимальное произведение = {minRow * maxColumn}");
            }
            catch
            {
                MessageBox.Show("Найдено пустое значение");
            }
        }
    }
}
