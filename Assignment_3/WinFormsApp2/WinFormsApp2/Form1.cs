using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            string a = textBox1.Text;
            string b = textBox2.Text;
            double a_1 = Convert.ToInt32(a);
            double b_1 = Convert.ToInt32(b)* Convert.ToInt32(b);
            double c = 703*a_1 / b_1;
            double roundedNumber = Math.Round(c, 2);
            label3.Text = "BMI: " + roundedNumber.ToString();
            if (roundedNumber > 25)
            {
                label4.Text = "Status: " + "overweight";
            }
            else if (roundedNumber < 18.5)
            {
                label4.Text = "Status: " + "underweight";

            }
            else {
                label4.Text = "Status: " + "normal weight";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
