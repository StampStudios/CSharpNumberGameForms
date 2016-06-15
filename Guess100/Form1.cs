using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpNumberGame
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

            string usrGuessStr = textBox1.Text;
            bool usrGuessDigit = usrGuessStr.All(char.IsDigit);
            if (usrGuessDigit == true)
            {
                int usrGuessInt = int.Parse(usrGuessStr);
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
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive integer.");
            }

        }
    }
}
