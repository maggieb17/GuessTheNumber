using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        int attempts = 8;
        int randomNumber;
        bool gameOver = false;

        public Form2()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 100);
            attempts = 8;
            gameOver = false;
            label4.Text = attempts.ToString();
            textBox1.Enabled = true;
            label7.Visible = false;
            label8.Visible = false;
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
                        label9.Text = "Congratulations! You guessed the number!";
                        label9.Visible = true;
                        gameOver = true;
                    }
                    else
                    {
                        attempts--;
                        label4.Text = $"{attempts}";
                        label4.Visible = true;
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
    }
}
