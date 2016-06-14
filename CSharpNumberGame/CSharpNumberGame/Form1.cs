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

        int targetNumber { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Developed by Jack Tench and Tom Tinsley for release on GitHub.");

            Random rnd = new Random();
            int targetNumber = rnd.Next(1, 10);
            string targetNumberStr = targetNumber.ToString();
            MessageBox.Show(targetNumberStr);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usrGuessStr = textBox1.Text;
            int usrGuessInt = Int32.Parse(usrGuessStr);
            MessageBox.Show(usrGuessInt.ToString());
            if (usrGuessInt == targetNumber)
            {
                MessageBox.Show("Correct");
            }
        }
    }
}
