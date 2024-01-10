using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] correctAnswers = {
                'B', 'D', 'A', 'A', 'C',
                'A', 'B', 'A', 'C', 'D',
                'B', 'C', 'D', 'A', 'D',
                'C', 'C', 'B', 'D', 'A'
            };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] studentAnswers; 

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentAnswers = File.ReadAllLines(openFileDialog.FileName);

                

                if (studentAnswers.Length != 20)
                {
                    MessageBox.Show("Error: Invalid number of answers in the file. The file should contain 20 answers.");
                    return;
                }

                
                int correctCount = 0;
                int incorrectCount = 0;
                List<int> incorrectQuestions = new List<int>();

                for (int i = 0; i < correctAnswers.Length; i++)
                {
                    
                    if (studentAnswers[i].Length > 0 && char.ToUpper(studentAnswers[i][0]) == correctAnswers[i])
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectQuestions.Add(i + 1); 
                        incorrectCount++;
                    }
                }

                
                MessageBox.Show($"Total number of correctly answered questions: {correctCount}\n" +
                                $"Total number of incorrectly answered questions: {incorrectCount}\n" +
                                $"{(correctCount >= 15 ? "The student passed the exam!" : "The student failed the exam.")}\n" +
                                $"Question numbers of incorrectly answered questions: {string.Join(", ", incorrectQuestions)}");

            }
        }

    }
}
