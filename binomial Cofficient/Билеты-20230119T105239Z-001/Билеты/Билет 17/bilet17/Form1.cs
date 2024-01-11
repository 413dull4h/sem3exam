namespace bilet17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Dimension.n;
            dataGridView1.ColumnCount = Dimension.n;

            dataGridView2.RowCount = Dimension.n;
            dataGridView2.ColumnCount = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.RowCount = Dimension.n;
                dataGridView3.ColumnCount = Dimension.n;
                dataGridView4.RowCount = Dimension.n;
                dataGridView4.ColumnCount = Dimension.n;
                dataGridView5.RowCount = Dimension.n;
                dataGridView5.ColumnCount = Dimension.n;

                int[,] matrix = new int[Dimension.n, Dimension.n];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                int determinant = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] - matrix[2, 0] * matrix[1, 1] * matrix[0, 2] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2] * matrix[0, 0];

                int[,] matrixFree = new int[Dimension.n, 1];
                for (int i = 0; i < Dimension.n; i++)
                {
                    matrixFree[i, 0] = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                }

                int[,] matrixX = new int[Dimension.n, Dimension.n];

                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        matrixX[i, j] = matrix[i, j];
                    }
                }
                matrixX[0, 0] = matrixFree[0, 0];
                matrixX[1, 0] = matrixFree[1, 0];
                matrixX[2, 0] = matrixFree[2, 0];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = matrixX[i, j].ToString();
                    }
                }

                int[,] matrixY = new int[Dimension.n, Dimension.n];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        matrixY[i, j] = matrix[i, j];
                    }
                }
                matrixY[0, 1] = matrixFree[0, 0];
                matrixY[1, 1] = matrixFree[1, 0];
                matrixY[2, 1] = matrixFree[2, 0];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        dataGridView4.Rows[i].Cells[j].Value = matrixY[i, j].ToString();
                    }
                }

                int[,] matrixZ = new int[Dimension.n, Dimension.n];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        matrixZ[i, j] = matrix[i, j];
                    }
                }
                matrixZ[0, 2] = matrixFree[0, 0];
                matrixZ[1, 2] = matrixFree[1, 0];
                matrixZ[2, 2] = matrixFree[2, 0];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        dataGridView5.Rows[i].Cells[j].Value = matrixZ[i, j].ToString();
                    }
                }

                double x, y, z = 1;
                int determinantX = matrixX[0, 0] * matrixX[1, 1] * matrixX[2, 2] + matrixX[1, 0] * matrixX[2, 1] * matrixX[0, 2] + matrixX[0, 1] * matrixX[1, 2] * matrixX[2, 0] - matrixX[2, 0] * matrixX[1, 1] * matrixX[0, 2] - matrixX[1, 0] * matrixX[0, 1] * matrixX[2, 2] - matrixX[2, 1] * matrixX[1, 2] * matrixX[0, 0];
                int determinantY = matrixY[0, 0] * matrixY[1, 1] * matrixY[2, 2] + matrixY[1, 0] * matrixY[2, 1] * matrixY[0, 2] + matrixY[0, 1] * matrixY[1, 2] * matrixY[2, 0] - matrixY[2, 0] * matrixY[1, 1] * matrixY[0, 2] - matrixY[1, 0] * matrixY[0, 1] * matrixY[2, 2] - matrixY[2, 1] * matrixY[1, 2] * matrixY[0, 0];
                int determinantZ = matrixZ[0, 0] * matrixZ[1, 1] * matrixZ[2, 2] + matrixZ[1, 0] * matrixZ[2, 1] * matrixZ[0, 2] + matrixZ[0, 1] * matrixZ[1, 2] * matrixZ[2, 0] - matrixZ[2, 0] * matrixZ[1, 1] * matrixZ[0, 2] - matrixZ[1, 0] * matrixZ[0, 1] * matrixZ[2, 2] - matrixZ[2, 1] * matrixZ[1, 2] * matrixZ[0, 0];

                x = (double)determinantX / (double)determinant;
                y = (double)determinantY / (double)determinant;
                z = (double)determinantZ / (double)determinant;

                richTextBox1.Text = $"Корни уравнения: {x}; {y}; {z};";
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте ввод данных");
            }
        }
    }
}