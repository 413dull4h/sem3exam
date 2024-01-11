namespace bilet19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = -values.b / values.a;
            string helper = "";
            if (x1 < 0)
            {
                x1 = x1 * -1;
                helper = "i";

            }
            double x2 = Math.Sqrt(x1);
            double x3 = x2 * -1;

            richTextBox1.Text = ($"Корени уравнения: {x2}{helper} и {x3}{helper}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = Convert.ToString($"{values.a}x^2 + {values.b} = 0");
           
        }
    }
}