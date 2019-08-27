using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        Player currentPlayer;

        List<Button> allButtons;
        Random randomNumber = new Random();
        int playerWins = 0;
        int aiWins = 0;

        //enum to control the player and AI symbols
        public enum Player 
        {
            X, O
        }
        public TicTacToeForm()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
        {
            var btn = (Button)sender; //find which button was clicked
            currentPlayer = Player.X; //give the player the X
            btn.Text = currentPlayer.ToString(); //chnage the text of the clicked Button to X
            btn.Enabled = false; //disable button
            btn.BackColor = System.Drawing.Color.Cyan; //change the player color to cyan
            allButtons.Remove(btn); //remove clicked button from list, that the AI can't click him
            check(); //check if the player won
            AImoves.Start(); //start the AI
        }

        //the AI will choose randomly a button from the list while array is greater 
        //than 0 on the other hand it will stop playing
        private void AImove(object sender, EventArgs e)
        {
            if (allButtons.Count > 0)
            {
                int index = randomNumber.Next(allButtons.Count); //generate a random number within 
                                                                 //the number of available buttons
                allButtons[index].Enabled = false;

                currentPlayer = Player.O; // set AI with O
                allButtons[index].Text = currentPlayer.ToString();
                allButtons[index].BackColor = System.Drawing.Color.DarkSalmon;
                allButtons.RemoveAt(index);
                check();
                AImoves.Stop();
            }
        }

        //call resetGame() if the Restart buttons is pressed
        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadButtons()
        {
            allButtons = new List<Button> { tile1, tile2, tile3, tile4, tile5, tile6,
                tile7, tile8, tile9 };
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; //change all buttons back to enabled
                    ((Button)X).Text = "?"; //set text to ?
                    ((Button)X).BackColor = default(Color); //change the background color 
                                                            //to default button colors
                }
            }
            loadButtons(); //insert all buttons back in the array
        }

        //cheack if the play or AI won
        private void check()
        {
            if(tile1.Text == "X" && tile2.Text == "X" && tile3.Text == "X" ||
               tile4.Text == "X" && tile5.Text == "X" && tile6.Text == "X" ||
               tile7.Text == "X" && tile8.Text == "X" && tile9.Text == "X" ||
               tile1.Text == "X" && tile4.Text == "X" && tile7.Text == "X" ||
               tile2.Text == "X" && tile5.Text == "X" && tile8.Text == "X" ||
               tile3.Text == "X" && tile6.Text == "X" && tile9.Text == "X" ||
               tile1.Text == "X" && tile5.Text == "X" && tile9.Text == "X" ||
               tile3.Text == "X" && tile5.Text == "X" && tile7.Text == "X" )
            {
                AImoves.Stop();
                MessageBox.Show("Player WINS");
                playerWins++;
                playerWinsLabel.Text = "Player Wins - " + playerWins;
                resetGame();
            }else if (tile1.Text == "O" && tile2.Text == "O" && tile3.Text == "O" ||
               tile4.Text == "O" && tile5.Text == "O" && tile6.Text == "O" ||
               tile7.Text == "O" && tile8.Text == "O" && tile9.Text == "O" ||
               tile1.Text == "O" && tile4.Text == "O" && tile7.Text == "O" ||
               tile2.Text == "O" && tile5.Text == "O" && tile8.Text == "O" ||
               tile3.Text == "O" && tile6.Text == "O" && tile9.Text == "O" ||
               tile1.Text == "O" && tile5.Text == "O" && tile9.Text == "O" ||
               tile3.Text == "O" && tile5.Text == "O" && tile7.Text == "O")
            {
                AImoves.Stop();
                MessageBox.Show("AI WINS");
                aiWins++;
                aiWinsLabel.Text = "AI Wins - " + aiWins;
                resetGame();
            }
        }
    }
}
