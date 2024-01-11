using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(richTextBox1.Text);
            int y = Convert.ToInt32(richTextBox2.Text);
            int z = Convert.ToInt32(richTextBox3.Text);
            string ans0 = Convert.ToString(x + y);
            int ans1 = Convert.ToInt32(ans0, 2);
            string ans2 = Convert.ToString(x / y);
            int ans3 = Convert.ToInt32(ans2, 2);
            richTextBox4.Text = ans1.ToString();
            richTextBox5.Text = ans3.ToString();


        }
    }
}
