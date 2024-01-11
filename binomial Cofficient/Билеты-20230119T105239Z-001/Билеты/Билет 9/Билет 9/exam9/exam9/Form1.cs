﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam9
{
    public partial class Form1 : Form
    {
        matrix _matrix = new matrix();
        public Form1()
        {
            InitializeComponent();
        }
        double[,] a = new double[3, 3];
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;

        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            double determinantMainMatrix = matrix.Det(a, 3);
            double[,] allyMass = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allyMass[i, j] = UnionMatr.UnionMatrix(a, i, j, 3);
                    
                }
            }
            double[,] transMatrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transMatrix[j, i] = allyMass[i, j];
                    
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transMatrix[i, j] = transMatrix[i, j] / determinantMainMatrix;
                    dataGridView2.Rows[i].Cells[j].Value = Math.Round(transMatrix[i, j], 2).ToString();
                }
            }
        }
    }
}
