﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace guess100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int targetNumber;
        int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Developed by Jack Tench and Tom Tinsley for release on GitHub.");

            Random rnd = new Random();
            targetNumber = rnd.Next(1, 100);
            string targetNumberStr = targetNumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string usrGuessStr = textBox1.Text;
                bool usrGuessDigit = usrGuessStr.All(char.IsDigit);
                if (usrGuessDigit == true)
                {
                    int usrGuessInt = int.Parse(usrGuessStr);
                    if (Enumerable.Range(1, 100).Contains(usrGuessInt))
                    {
                        counter += 1;
                        if (usrGuessInt == targetNumber)
                        {
                            if (counter == 1)
                            {
                                MessageBox.Show("Congratulations you got it first time!");
                            }
                            else
                            {
                                MessageBox.Show("Congratulations you got it in " + counter + " guesses.");
                            }
                            Random rnd = new Random();
                            targetNumber = rnd.Next(1, 100);
                            string targetNumberStr = targetNumber.ToString();
                            counter = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number from 1-100.");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a positive integer.");
                }
            }

            else
            {
                MessageBox.Show("Please enter a number.");
            }

            textBox1.Text = "";
            label3.Text = "Guesses: " + counter.ToString();
            this.Text = "Guess100 (" + counter.ToString() + ")";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            targetNumber = rnd.Next(1, 100);
            string targetNumberStr = targetNumber.ToString();
            counter = 0;
            label3.Text = "Guesses: " + counter.ToString();
            this.Text = "Guess100 (" + counter.ToString() + ")";
        }
    }
}
