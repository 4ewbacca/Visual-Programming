using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_project
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
            AttachEventHandlers();
        }
        private void AttachEventHandlers()
        {
            button0.Click += NumberButton_Click;
            button1.Click += NumberButton_Click;
            button2.Click += NumberButton_Click;
            button3.Click += NumberButton_Click;
            button4.Click += NumberButton_Click;
            button5.Click += NumberButton_Click;
            button6.Click += NumberButton_Click;
            button7.Click += NumberButton_Click;
            button8.Click += NumberButton_Click;
            button9.Click += NumberButton_Click;

            buttonmultiply.Click += OperatorButton_Click;
            buttondev.Click += OperatorButton_Click;
            buttonadd.Click += OperatorButton_Click;
            buttonsub.Click += OperatorButton_Click;
            button_equ.Click += ButtonEqu_Click;
            button_dot.Click += OperatorButton_Click;
           
        }

     

        private void ButtonEqu_Click(object sender, EventArgs e)
        {
            string expression = Result.Text;

            try
            {
                expression = expression.Replace(',', '.');
                var result = CalculateResult(expression);
                Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private object CalculateResult(string expression)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(expression, "");
            negative_checkBox.Checked = false;
            if (Result.Text != "")
            {
                comboBox1.Items.Add(result);
                
                button_dot.Enabled = true;
            }
            return result;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
          
            string number = ((Button)sender).Text;


           
            Result.Text += number;
            
        }
        private void button0_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void realtime_result_Click(object sender, EventArgs e)
        {

        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            string operation = "";
         
            

            if (sender == buttonmultiply)
            {
                operation = "*";
                
            }
            else if (sender == buttondev)
            {
                operation = "/";
                
            }
            else if (sender == buttonadd)
            {
                operation = "+";
            }
            else if (sender == buttonsub)
            {
                operation = "-";
            }
            else if (sender == button_dot)
            {
                string number = ((Button)sender).Text;
                if (Result.Text.Length == 0 || "+-*/".Contains(Result.Text.Last()))
                {
                    if (number == ",")
                    {
                        Result.Text += "0" + ",";
                        button_dot.Enabled = false;

                    }
                    else
                    {
                        Result.Text += number;
                        
                    }
                }
                else if (number == ",")
                {
                    
                    if (!Result.Text.EndsWith(","))
                    {
                        Result.Text += ",";
                        button_dot.Enabled = false;
                    }
                }
                else
                {
                    Result.Text += number;
                }
            }
       
            if (Result.Text.Length > 0 && !"+-*/,".Contains(Result.Text.Last()))
            {
                Result.Text += operation;
                button_dot.Enabled = true;
              
            }
            



        }

        private void button_equ_Click(object sender, EventArgs e)
        {

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Result.Text = comboBox1.Text;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            negative_checkBox.Checked = false;
            button_dot.Enabled = true;
        }

        private void negative_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (negative_checkBox.Checked)
            {
                if (Result.Text == ""|| Result.Text[0] != '-')
                {
                    Result.Text = "-" + Result.Text;
                }

            }
            else
            {
                if (Result.Text.Length > 0 && Result.Text[0] == '-')
                {
                    Result.Text = Result.Text.Substring(1);
                }
            }
            }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
