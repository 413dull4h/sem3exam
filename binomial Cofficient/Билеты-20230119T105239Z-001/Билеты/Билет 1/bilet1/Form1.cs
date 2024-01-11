namespace bilet1
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
                //Поиск минимального элемента в первых трёх столбах
                int min = int.MaxValue;
                for (int i = 0; i < Dimension.n; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                }
                richTextBox2.Text = $"Минимальный элемент среди первых трёх столбов: {min}";

                int max = int.MinValue;
                //Поиск Максимального элемента среди первых трёх строк    
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < Dimension.n; j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                }
                richTextBox3.Text = $"Максимальный элемент среди первых трёх строк: {max}";

                richTextBox1.Text = $"Cумма: {max + min}";
                richTextBox4.Text = $"Результат умножения: {max * min}";
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте ввод данных !");
            }
        }
            

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}