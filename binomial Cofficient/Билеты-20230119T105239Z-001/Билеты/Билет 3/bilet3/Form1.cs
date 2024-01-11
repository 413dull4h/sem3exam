namespace bilet3
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[Dimension.n, Dimension.n];
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                //Поиск минимального элемента среди чётных столбов
                int min = int.MaxValue;
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 1; j < Dimension.n; j += 2)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                }
                richTextBox1.Text = $"Минимальный элемент среди чётных столбов: {min}";

                //Поиск минимального элемента среди нечётных строк
                int max = int.MinValue;
                for (int i = 0; i < Dimension.n; i += 2)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                }
                richTextBox2.Text = $"Максимальный элемент среди нечётных строк: {max}";


                richTextBox3.Text = $"Разность: {min - max}";
                richTextBox4.Text = $"Частное от деления: {(double)min / max}";
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте ввод данных !");
            }
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Dimension.n;
            dataGridView1.ColumnCount = Dimension.n;
        }
    }
}