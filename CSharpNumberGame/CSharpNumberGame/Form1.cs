using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Developed by Jack Tench and Tom Tinsley for release on GitHub.");

            Random rnd = new Random();
            targetNumber = rnd.Next(1, 5);
            string targetNumberStr = targetNumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usrGuessStr = textBox1.Text;
            int usrGuessInt = Int32.Parse(usrGuessStr);
            if (usrGuessInt == targetNumber)
            {
                MessageBox.Show("Correct");
            }
        }
    }
}
