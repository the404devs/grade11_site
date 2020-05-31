using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjModularity
{
    public partial class Form1 : Form
    {
        /*My instance variables*/
        Random r = new Random();
        int comNumber = 0;
        int guess = 0;
        DialogResult dr; // dr is a variable that will store a dialog result object.

        /*My custom functions
         Functions are blocks of code that have been given a name. They are a part of
         * modular programming in that they compartmentalize the code. It makes writing 
         * code more efficient. Reduces size, easier to debug and less lines of code.*/
        void quit()
        {
            dr = MessageBox.Show("Quit?", "QUIT", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("We're no strangers to love You know the rules and so do I A full commitment's what I'm thinking of You wouldn't get this from any other guy I just want to tell you how I'm feeling Gotta make you understand Never gonna give you up, never gonna let you down Never gonna run around and desert you Never gonna make you cry, never gonna say goodbye Never gonna tell a lie and hurt you We've known each other for so long Your heart's been aching but you're too shy to say it Inside we both know what's been going on We know the game and we're gonna play it And if you ask me how I'm feeling Don't tell me you're too blind to see Never gonna give you up, never gonna let you down Never gonna run around and desert you Never gonna make you cry, never gonna say goodbye Never gonna tell a lie and hurt you Never gonna give you up, never gonna let you down Never gonna run around and desert you Never gonna make you cry, never gonna say goodbye Never gonna tell a lie and hurt you We've known each other for so long Your heart's been aching but you're too shy to say it Inside we both know what's been going on We know the game and we're gonna play it I just want to tell you how I'm feeling Gotta make you understand Never gonna give you up, never gonna let you down Never gonna run around and desert you Never gonna make you cry, never gonna say goodbye Never gonna tell a lie and hurt you");
            }
        }


        

        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
          /* This event occurs when the form first loads. Often used to initialize the values of variables.*/
            comNumber = r.Next(1,11);
            MessageBox.Show(comNumber + "");
            MessageBox.Show("Start guessing!");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt16(txtNumber.Text);

            if (guess == comNumber)
            {
                MessageBox.Show("You got it!");
                quit();
            }
            else
            {
                MessageBox.Show("Wrong! Try again!");
                txtNumber.Focus();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            quit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            quit(); 
            
        }
    }
}
