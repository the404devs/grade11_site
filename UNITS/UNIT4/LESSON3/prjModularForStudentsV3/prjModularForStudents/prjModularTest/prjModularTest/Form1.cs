using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjModularTest
{
    public partial class Form1 : Form
    {
        //variables-the random object is created only once
        //the random object variable r can be used in any function
        Random r = new Random();
        //These variables are used to maintain the game scores.
        int playerScore = 0;
        int computerScore = 0;
        //DO NOT create any other variable here
        //all necessary variables are to be made in the functions

        //Create all listed functions here
        //MY FUNCTIONS
        void dealCardsToPlayer()
        {
            lblCard1.Text = r.Next(1, 11) + "";
            lblCard2.Text = r.Next(1, 11) + "";
            lblCard3.Text = r.Next(1, 11) + "";
        }

        void dealCardsToComputer()
        {
            lblCard4.Text = r.Next(1, 11) + "";
            lblCard5.Text = r.Next(1, 11) + "";
            lblCard6.Text = r.Next(1, 11) + "";
        }

        int playerTotal(int card1, int card2, int card3)
        {
            int sum = card1 + card2 + card3;
            return sum;
        }

        int computerTotal(int card1, int card2, int card3)
        {
            int sum = card1 + card2 + card3;
            return sum;
        }

        void updatePlayerScore()
        {
            playerScore++;
            lblPlayerPoints.Text = (playerScore + "");       
            lblWinner.Text = "Player Wins!";
        }

        void updateComputerScore()
        {
            computerScore++;
            lblComputerPoints.Text = (computerScore + "");           
            lblWinner.Text = "Computer Wins!";
        }

        void updateTies()
        {
            lblTies.Text = (Convert.ToInt16(lblTies.Text) + 1) + "";
            lblWinner.Text = "Draw!";
        }


        public Form1()
        {
            InitializeComponent();
        }

    

        //******************************************
        //********DO NOT modify the following*******
        //******************************************
        private void btnPlay_Click(object sender, EventArgs e)
        {
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;
            
            dealCardsToPlayer();
            dealCardsToComputer();

            card1 = Convert.ToInt16(lblCard1.Text);
            card2 = Convert.ToInt16(lblCard2.Text);
            card3 = Convert.ToInt16(lblCard3.Text);
            int player = playerTotal(card1,card2,card3);

            card1 = Convert.ToInt16(lblCard4.Text);
            card2 = Convert.ToInt16(lblCard5.Text);
            card3 = Convert.ToInt16(lblCard6.Text);
            int computer = computerTotal(card1,card2,card3);

            lblPlayerTotal.Text = player + "";
            lblComputerTotal.Text = computer + "";

            if (player > computer)
            {
                updatePlayerScore();
            }
            else if (player < computer)
            {
                updateComputerScore();
            }
            else
            {
                updateTies();
            }

        }
    }
}
