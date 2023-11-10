using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_5
{
    public partial class Form1 : Form
    {
        private int randomNumber; 

        public Form1()

        {
            InitializeComponent();
            GenerateRandomNumber();
        }
        private void GenerateRandomNumber()

        {

               
                Random random = new Random();
                randomNumber = random.Next(1, 101);
                label2.Text = "Guess a number in the range of 1-100";

            }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userGuess = int.Parse(textBox1.Text);

                if (userGuess == randomNumber)
                {
                    string message = $"Congratulations! You guessed the correct number: {randomNumber}\nDo you want to play again?";
                    DialogResult result = MessageBox.Show(message, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GenerateRandomNumber();
                        textBox1.Text = string.Empty; 
                    }
                    else
                    {
                        Close(); 
                    }
                }
                else
                {
                    string resultMessage = (userGuess < randomNumber) ? "Try a higher number." : "Try a lower number.";
                    label2.Text = resultMessage;
                }
            }
            catch (FormatException)
            {
                label2.Text = "Please enter a valid number.";
            }
        }
    }
}
