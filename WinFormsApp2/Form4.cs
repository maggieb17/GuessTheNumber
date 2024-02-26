using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        int attempts = 8;
        int randomNumber;
        bool gameOver = false;

        public Form4()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 100);
            attempts = 3;
            gameOver = false;
            label11.Text = attempts.ToString();
            textBox1.Enabled = true;
            label7.Visible = false;
            label12.Visible = false;
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                int guessedNumber;
                if (int.TryParse(textBox1.Text, out guessedNumber))
                {
                    if (guessedNumber == randomNumber)
                    {
                        label9.Visible = true;
                        label9.Text = "Congratulations! You guessed the number!";
                        gameOver = true;
                    }
                    else
                    {
                        attempts--;
                        label11.Text = $"{attempts}";
                        label11.Visible = true;
                        if (attempts == 0)
                        {
                            label9.Visible = true;
                            label9.Text = "Sorry, you lose! The number was: " + randomNumber;
                            gameOver = true;
                        }
                        else
                        {
                            if (guessedNumber < randomNumber)
                            {
                                label7.Visible = true;
                                label12.Visible = false;
                            }
                            else if (guessedNumber > randomNumber)
                            {
                                label12.Visible = true;
                                label7.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

