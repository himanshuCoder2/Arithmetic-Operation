using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic_Operator
{
    public partial class Form1 : Form
    {
        int num1, num2, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "/";
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 / num2;
            textBox3.Text = res + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "%";
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 % num2;
            textBox3.Text = res + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1-num2;
            textBox3.Text = res + "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "*";
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 * num2;
            textBox3.Text = res + "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "+";
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 + num2;
            textBox3.Text=res+" ";
        }
    }
}
