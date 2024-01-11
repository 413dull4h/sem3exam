//Найти значения X 
namespace bilet21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Class1.x1 = Convert.ToDouble(richTextBox2.Text);
                Class1.x2 = Convert.ToDouble(richTextBox3.Text);
                Class1.x3 = Convert.ToDouble(richTextBox4.Text);
                Class1.x4 = Convert.ToDouble(richTextBox5.Text);

                double x = (Class1.x1 + Math.Pow(Class1.x2, 2) - Class1.x3 * Class1.x4);

                richTextBox1.Text = Convert.ToString(x);
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте корректность введенных значений");
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}