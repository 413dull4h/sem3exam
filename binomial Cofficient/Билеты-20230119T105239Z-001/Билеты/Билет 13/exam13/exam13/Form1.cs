﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) + Convert.ToInt16(dataGridView2.Rows[i].Cells[j].Value);
                    dataGridView4.Rows[i].Cells[j].Value = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToInt16(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;
            dataGridView3.RowCount = 3;
            dataGridView3.ColumnCount = 3;
            dataGridView4.RowCount = 3;
            dataGridView4.ColumnCount = 3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-20, 20);
                    dataGridView2.Rows[i].Cells[j].Value = rnd.Next(-20, 20);

                }
            }
        }
    }
}
