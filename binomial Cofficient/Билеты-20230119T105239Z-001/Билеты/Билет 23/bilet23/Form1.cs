namespace bilet23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(richTextBox1.Text);
            int j = Convert.ToInt32(richTextBox2.Text);
            




            richTextBox3.Text = Convert.ToString(i + j, 2);
            richTextBox6.Text = Convert.ToString(i * j, 2);
            

        }
    }
}