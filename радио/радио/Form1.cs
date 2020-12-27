using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace радио
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) textBox1.Text += "X";
            if (radioButton2.Checked) textBox1.Text += "Y";
            if (radioButton3.Checked) textBox1.Text += "Z";
            if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked) textBox2.Text += "A";
            if (checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked) textBox2.Text += "B";
            if (checkBox3.Checked && !checkBox2.Checked && !checkBox1.Checked) textBox2.Text += "C";
            if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked) textBox2.Text += "AB";
            if (checkBox1.Checked && checkBox3.Checked && !checkBox2.Checked) textBox2.Text += "AC";
            if (checkBox2.Checked && checkBox3.Checked && !checkBox1.Checked) textBox2.Text += "BC";
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked) textBox2.Text += "ABC";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox2.Clear();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
