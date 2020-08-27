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
    public partial class Form3 : Form
    {
        int flag=1,c=0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
 

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button1.Text = "0";
                flag = 0;
                button1.BackColor = Color.Red;

            }
            else
            {
                button1.Text = "X";
                flag = 1;
                button1.BackColor = Color.Green;

            }
            button1.Enabled = false;
            c++;
            Win();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button2.Text = "0";
                flag = 0;
                button2.BackColor = Color.Red;

            }
            else
            {
                button2.Text = "X";
                flag = 1;
                button2.BackColor = Color.Green;

            }
            button2.Enabled = false;

            c++;
            Win();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button3.Text = "0";
                flag = 0;
                button3.BackColor = Color.Red;

            }
            else
            {
                button3.Text = "X";
                flag = 1;
                button3.BackColor = Color.Green;

            }
            button3.Enabled = false;
            c++;
            Win();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button4.Text = "0";
                flag = 0;
                button4.BackColor = Color.Red;

            }
            else
            {
                button4.Text = "X";
                flag = 1;
                button4.BackColor = Color.Green;

            }
            button4.Enabled = false;
            c++;
            Win();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button5.Text = "0";
                flag = 0;
                button5.BackColor = Color.Red;

            }
            else
            {
                button5.Text = "X";
                flag = 1;
                button5.BackColor = Color.Green;

            }
            button5.Enabled = false;
            c++;
            Win();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button6.Text = "0";
                flag = 0;
                button6.BackColor = Color.Red;

            }
            else
            {
                button6.Text = "X";
                flag = 1;
                button6.BackColor = Color.Green;

            }
            button6.Enabled = false;
            c++;
            Win();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button7.Text = "0";
                flag = 0;
                button7.BackColor = Color.Red; 
            }
            else
            {
                button7.Text = "X";
                flag = 1;
                button7.BackColor = Color.Green;

            }
            button7.Enabled = false;
            c++;

            Win();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button8.Text = "0";
                flag = 0;
                button8.BackColor = Color.Red;

            }
            else
            {
                button8.Text = "X";
                flag = 1;
                button8.BackColor = Color.Green;

            }
            button8.Enabled = false;
            c++;
            Win();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                button9.Text = "0";
                flag = 0;
                button9.BackColor = Color.Red;

            }
            else
            {
                button9.Text = "X";
                flag = 1;
                button9.BackColor = Color.Green;

            }
            button9.Enabled = false;
            c++;
            Win();

        }
        void Win()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {   if(button1.Text=="0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }

                DialogResult dr = MessageBox.Show( "want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show("want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();

            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show( "want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show( "want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show("want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show( "want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show( "want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == "0")
                {
                    MessageBox.Show("WINNER IS 0");
                }
                else
                {
                    MessageBox.Show("WINNER IS X");

                }
                DialogResult dr = MessageBox.Show("want to play agin?", "WINNER WINNER", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();

            }
            else if (c == 9)
            {
                MessageBox.Show(" DRAW");
                  DialogResult dr = MessageBox.Show(" DRAW","want to play agin?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    reset();
                }
                else
                    this.Close();
            }

        }
       void reset()
        {
            button1.Text = "1";
            button1.Enabled = true;
            button1.BackColor = default;
            button2.Text = "2";
            button2.Enabled = true;
            button2.BackColor = default;

            button3.Text = "3";
            button3.Enabled = true;
            button3.BackColor = default;

            button4.Text = "4";
            button4.Enabled = true;
            button4.BackColor = default;

            button5.Text = "5";
            button5.Enabled = true;
            button5.BackColor = default;

            button6.Text = "6";
            button6.Enabled = true;
            button6.BackColor = default;

            button7.Text = "7";
            button7.Enabled = true;
            button7.BackColor = default;

            button8.Text = "8";
            button8.Enabled = true;
            button8.BackColor = default;

            button9.Text = "9";
            button9.Enabled = true;
            button9.BackColor = default;
            c = 0;


        }
    }
}
