namespace bilet25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Values.a.ToString();
            richTextBox2.Text = Values.b.ToString();
            richTextBox4.Text = Values.c.ToString();
            richTextBox5.Text = Values.d.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Перед вводом новых значений, проверьте, можно ли складывать введенные вами двоичные числа
            try
            {
                int h = Convert.ToInt32(richTextBox1.Text);
                int h1 = Convert.ToInt32(richTextBox2.Text);

                int h2 = Convert.ToInt32(richTextBox4.Text);
                int h3 = Convert.ToInt32(richTextBox5.Text);

                string j = Convert.ToString(h + h1);

                int i = Convert.ToInt32(j, 2);

                string j1 = Convert.ToString(h2 * h3);

                int i1 = Convert.ToInt32(j1, 2);


                richTextBox3.Text = Convert.ToString(i);
                richTextBox6.Text = Convert.ToString(i1);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте ввод данных !");
            }
        }
    }
}