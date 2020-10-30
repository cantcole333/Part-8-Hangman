using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8_Hangman
{
    public partial class Hangman : Form
    {
        string word = "COMPUTER";
        int guess = 0;
        string displayWord = "_ _ _ _ _ _ _ _";
        int index;
        public Hangman()
        {
            InitializeComponent();
        }

        private void lblWord_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            string userGuess = txtGuess.Text.ToUpper();
            if (word.Contains(userGuess))
            {
                index = word.IndexOf(userGuess);
                displayWord = displayWord.Remove(index*2, 1);
                displayWord = displayWord.Insert(index*2, userGuess);
                lblStatus.Text = Convert.ToString(index);
                lblWord.Text = displayWord;
                txtGuess.Text = "";
                if (userGuess == "")
                {
                    
                    lblStatus.Text = "Please enter something in the text box";
                }
                if (displayWord == "C O M P U T E R")
                {
                    lblStatus.Text = "Status: You Win!";
                }
            }
            else
            {
                lstGuessedLetters.Items.Add(userGuess);
                guess = guess += 1;
                if (guess == 1)
                {
                    lblStatus.Text = "Incorrect! you have two more guesses";
                    imgHangman.Image = Properties.Resources.hangman_1;
                }
                else if (guess == 2)
                {
                    lblStatus.Text = "Incorrect! you have " +
                        "one more guess";
                    imgHangman.Image = Properties.Resources.hangman_2;
                }
                else if (guess == 3)
                {
                    lblStatus.Text = "Incorrect! you have" +
                        " no more guesses";
                    imgHangman.Image = Properties.Resources.hangman_dead;
                }
                if (guess > 3)
                {
                    lblStatus.Text = "Status: You lose!";
                }
            }
            


        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            lblWord.Text = displayWord;
        }

        private void imgHangman_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblUsedLetters_Click(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
