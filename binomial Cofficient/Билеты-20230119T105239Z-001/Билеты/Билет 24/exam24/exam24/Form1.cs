using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(richTextBox1.Text);
                int y = Convert.ToInt32(richTextBox2.Text);
                int z = Convert.ToInt32(richTextBox4.Text);

                richTextBox3.Text = Convert.ToString(x - y, 2);
                richTextBox5.Text = Convert.ToString(x / z, 2);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность данных");
            }
        }
    }
}
