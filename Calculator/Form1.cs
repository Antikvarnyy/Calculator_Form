using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double n1 = 0, res = 0;
        char ch = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
                textBox1.Text += 0;
        }
        private void button0_Enter(object sender, EventArgs e)
        {
            button0.BackColor = Color.Coral;
            button0.ForeColor = Color.Black;
        }
        private void button0_Leave(object sender, EventArgs e)
        {
            button0.BackColor = Color.Black;
            button0.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Coral;
            button1.ForeColor = Color.Black;
        }
        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void button2_Enter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Coral;
            button2.ForeColor = Color.Black;
        }
        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button3_Enter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Coral;
            button3.ForeColor = Color.Black;
        }
        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button4_Enter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Coral;
            button4.ForeColor = Color.Black;
        }
        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button5_Enter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Coral;
            button5.ForeColor = Color.Black;
        }
        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void button6_Enter(object sender, EventArgs e)
        {
            button6.BackColor = Color.Coral;
            button6.ForeColor = Color.Black;
        }
        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button7_Enter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Coral;
            button7.ForeColor = Color.Black;
        }
        private void button7_Leave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button8_Enter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Coral;
            button8.ForeColor = Color.Black;
        }
        private void button8_Leave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button9_Enter(object sender, EventArgs e)
        {
            button9.BackColor = Color.Coral;
            button9.ForeColor = Color.Black;
        }
        private void button9_Leave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }
        private void buttonDot_Enter(object sender, EventArgs e)
        {
            buttonDot.BackColor = Color.Coral;
            buttonDot.ForeColor = Color.Black;
        }
        private void buttonDot_Leave(object sender, EventArgs e)
        {
            buttonDot.BackColor = Color.Black;
            buttonDot.ForeColor = Color.White;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && ch != ' ')
            {
                if (ch == '+')
                    res = n1 + Convert.ToDouble(textBox1.Text);
                else if (ch == '-')
                    res = n1 - Convert.ToDouble(textBox1.Text);
                else if (ch == '*')
                    res = n1 * Convert.ToDouble(textBox1.Text);
                else if (ch == '/')
                    res = n1 / Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{res}";
            }
        }
        private void buttonEq_Enter(object sender, EventArgs e)
        {
            buttonEq.BackColor = Color.Coral;
            buttonEq.ForeColor = Color.Black;
        }
        private void buttonEq_Leave(object sender, EventArgs e)
        {
            buttonEq.BackColor = Color.Black;
            buttonEq.ForeColor = Color.White;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 += Convert.ToDouble(textBox1.Text);
                ch = '+';
                textBox1.Text = "";
            }
        }
        private void buttonAdd_Enter(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Coral;
            buttonAdd.ForeColor = Color.Black;
        }
        private void buttonAdd_Leave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Black;
            buttonAdd.ForeColor = Color.White;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (n1 == 0)
                    n1 += Convert.ToDouble(textBox1.Text);
                else
                {
                    n1 -= Convert.ToDouble(textBox1.Text);
                }
                ch = '-';
                textBox1.Text = "";
            }
        }
        private void buttonSub_Enter(object sender, EventArgs e)
        {
            buttonSub.BackColor = Color.Coral;
            buttonSub.ForeColor = Color.Black;
        }
        private void buttonSub_Leave(object sender, EventArgs e)
        {
            buttonSub.BackColor = Color.Black;
            buttonSub.ForeColor = Color.White;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (n1 == 0)
                    n1 += Convert.ToDouble(textBox1.Text);
                else
                {
                    n1 *= Convert.ToDouble(textBox1.Text);
                }
                ch = '*';
                textBox1.Text = "";
            }
        }
        private void buttonMult_Enter(object sender, EventArgs e)
        {
            buttonMult.BackColor = Color.Coral;
            buttonMult.ForeColor = Color.Black;
        }
        private void buttonMult_Leave(object sender, EventArgs e)
        {
            buttonMult.BackColor = Color.Black;
            buttonMult.ForeColor = Color.White;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (n1 == 0)
                    n1 += Convert.ToDouble(textBox1.Text);
                else
                {
                    n1 /= Convert.ToDouble(textBox1.Text);
                }
                ch = '/';
                textBox1.Text = "";
            }
        }
        private void buttonDiv_Enter(object sender, EventArgs e)
        {
            buttonDiv.BackColor = Color.Coral;
            buttonDiv.ForeColor = Color.Black;
        }
        private void buttonDiv_Leave(object sender, EventArgs e)
        {
            buttonDiv.BackColor = Color.Black;
            buttonDiv.ForeColor = Color.White;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            n1 = 0;
            res = 0;
            textBox1.Text = "";
            ch = ' ';
        }
        private void buttonClean_Enter(object sender, EventArgs e)
        {
            buttonClean.BackColor = Color.Coral;
            buttonClean.ForeColor = Color.Black;
        }

        private void buttonClean_Leave(object sender, EventArgs e)
        {
            buttonClean.BackColor = Color.Black;
            buttonClean.ForeColor = Color.White;
        }
    }
}
