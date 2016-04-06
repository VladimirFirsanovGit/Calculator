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
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)// 0
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)// 1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)// 2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)// 3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)// 4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)// 5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)// 6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)// 7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)// 8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)// 9
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)// C
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)// +
        {
            textBox1.Text = textBox1.Text + '+';
        }

        private void button12_Click(object sender, EventArgs e)// -
        {
            textBox1.Text = textBox1.Text + '-';
        }

        private void button13_Click(object sender, EventArgs e)// *
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void button14_Click(object sender, EventArgs e)// /
        {
            textBox1.Text = textBox1.Text + '/';
        }
    }
}
