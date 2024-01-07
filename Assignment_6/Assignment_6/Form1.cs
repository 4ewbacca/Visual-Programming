using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayGame("rock");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayGame("scissors");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void PlayGame(string userChoice)
        {
            int computerChoice = random.Next(1, 4); 

            DisplayComputerChoice(computerChoice); 

            string result = DetermineWinner(userChoice, computerChoice);

            label3.Text = result; 
        }
        private void DisplayComputerChoice(int choice)
        {
            string computerChoice = "";
            switch (choice)
            {
                case 1:
                    computerChoice = "rock";
                    break;
                case 2:
                    computerChoice = "paper";
                    break;
                case 3:
                    computerChoice = "scissors";
                    break;
            }
            textBox1.Text = computerChoice;
        }

        private string DetermineWinner(string userChoice, int computerChoice)
        {
            string result = "";
            switch (userChoice)
            {
                case "rock":
                    result = computerChoice == 1 ? "Try Again!" : (computerChoice == 2 ? "You Lost!" : "Congratulations You Won!");
                    break;
                case "paper":
                    result = computerChoice == 2 ? "Try Again!" : (computerChoice == 3 ? "You Lost!" : "Congratulations You Won!");
                    break;
                case "scissors":
                    result = computerChoice == 3 ? "Try Again!" : (computerChoice == 1 ? "You Lost!" : "Congratulations You Won!");
                    break;
                default:
                    result = "Please select an option.";
                    break;
            }
            return result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
