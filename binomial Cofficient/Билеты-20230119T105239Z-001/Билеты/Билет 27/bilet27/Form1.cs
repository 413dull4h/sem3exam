//Найти сумму и произведение комплексных чисел. Выделить действительную и мнимую часть
using System.Numerics;
namespace bilet27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = $"({Values.x1} + {Values.j1}j) + ({Values.x2} - {Values.j2}j) = ({Values.x3} - {Values.j3}j)";

            richTextBox6.Text = $"({Values.xp1} - {Values.jp1}j) * ({Values.xp2} + {Values.jp2}j) = ({Values.xp3} + {Values.jp3}j)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xchanged = Values.x1 + Values.x2 - Values.x3;
            int jchanged = Values.j1 - Values.j2 + Values.j3;

            Complex c1 = new Complex(xchanged, jchanged);

            richTextBox4.Text = $"{xchanged} + {jchanged}j";

            richTextBox1.Text = Convert.ToString(c1);
            

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string helper = "j^2";

            int xpchanged = Values.xp1 * Values.xp2 - Values.xp3;
            int jpchanged = -Values.jp1 * Values.xp2  - Values.jp3 + Values.xp1 * Values.jp2;
            int jp2changed = -Values.jp1 * Values.jp2;
            

            richTextBox5.Text = $"{jp2changed}{helper} + {jpchanged}j + {xpchanged} ";

            jp2changed = jp2changed * -1;
            helper = "";
            xpchanged = xpchanged + jp2changed;

            Complex c2 = new Complex(xpchanged, jpchanged);

            richTextBox8.Text = Convert.ToString(c2);
        }
    }
}