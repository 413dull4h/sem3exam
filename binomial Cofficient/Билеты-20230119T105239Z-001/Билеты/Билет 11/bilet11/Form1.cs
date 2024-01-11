//Найти определитель матрицы 3х3 методом треугольника
namespace bilet11
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
                int determinant = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] - matrix[2, 0] * matrix[1, 1] * matrix[0, 2] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2] * matrix[0, 0];

                richTextBox1.Text = $"Определитель матрицы: {determinant}";
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте ввод данных !");
            }
        }
    }
}