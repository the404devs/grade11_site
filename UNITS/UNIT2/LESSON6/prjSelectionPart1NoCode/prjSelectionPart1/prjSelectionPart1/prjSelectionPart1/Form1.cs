using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSelectionPart1
{
    public partial class Form1 : Form
    {
        /*Game Variables*/
        int cpuNum = 0;
        int userNum = 0;
        int diffNum = 0;
        int guesses = 0;
        Random r = new Random();
        /*The above line declares the variable r to store a random object. Most objects are created with the keyword "new". Random objects are used to create random values, commonly used in games.*/

       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            /*Generate random number*/
            cpuNum = r.Next(1,101);
            /*This is a function that accepts two intergers as its arguements and will return a random number between the two.*/
            /*MessageBox.Show(cpuNum + "");*/
            lblMessage.Text = "Ready!";
            btnStartGame.Enabled = false;
            btnSubmitGuess.Enabled = true;
            txtUsersGuess.Enabled = true;
            lblNumberGuesses.Text = "0";
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            userNum = Convert.ToInt16(txtUsersGuess.Text);
            guesses++;
            /*TIPS AND TRICKS TO MAKE YOU A BETTER PROGRAMMER:
             * ++ means to increase the value by 1. It's a shortcut for guesses = guesses + 1;*/
            lblNumberGuesses.Text = guesses + "";
            diffNum = Math.Abs(cpuNum - userNum);
            /* Math object has many functions to help with  calculations, one of which is the abs function, which will get rid of a negative*/
            if(diffNum == 0)
            {
                lblTemperature.Text = "CORRECT!";
                lblTemperature.ForeColor = Color.Green;
                btnSubmitGuess.Enabled = false;
                txtUsersGuess.Enabled = false;
                btnStartGame.Enabled = true;
                txtUsersGuess.Text = "";
                btnStartGame.Focus();
                guesses = 0;
                
            }
            else if(diffNum <= 5)
            {
                lblTemperature.Text = "HOT";
                lblTemperature.ForeColor = Color.Red;
            }
            else if (diffNum <= 10)
            {
                lblTemperature.Text = "WARM";
                lblTemperature.ForeColor = Color.Orange;
            }
            else 
            {
                lblTemperature.Text = "COLD";
                lblTemperature.ForeColor = Color.Blue;
            }

        }
    }
}
