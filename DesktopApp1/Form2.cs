using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a,b,c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox6.Text);
            c = a + b;
            MessageBox.Show("Ans is " + " " + c);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox6.Text);
            c = a - b;
            MessageBox.Show("Ans is " + " " + c);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox6.Text);
            c = a * b;
            MessageBox.Show("Ans is " + " " + c);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox6.Text);
            c = a/b;
            MessageBox.Show("Ans is " +" "+ c);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
