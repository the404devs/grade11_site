using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            /* Find and the display the third last character of the input string as a capital. */
            string input = rtbInput.Text;
            input = input.Substring(57, 1);
            input = input.ToUpper();
            rtbOutput.Text = input;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            /* Display the total number of vowels in the input string. */

            string input = rtbInput.Text;
            int vowels = 0;
            int position = 0;
            for (int x = 0; x <= 62; x++)
            {
                string check = input.Substring(position, 1);
                if (check == "a" || check == "e" || check == "i" || check == "o" || check == "u")
                {
                    vowels++;
                }
                position++;
            }
            rtbOutput.Text = vowels + "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            /* Determine if the input string starts with the word "The".*/
            string input = rtbInput.Text;
            Boolean start = input.StartsWith("The");
            if (start == true)
            {
                rtbOutput.Text = "This string starts with the word \"The\".";
            }

            else
            {
                rtbOutput.Text = "This string does not start with the word \"The\".";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            /* Replace all vowels with the character #. */
            string input = rtbInput.Text;
            input = input.Replace("a", "#");
            input = input.Replace("e", "#");
            input = input.Replace("i", "#");
            input = input.Replace("o", "#");
            input = input.Replace("u", "#");
            rtbOutput.Text = input;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            /* Determine how many commas can be found in the input string. */
            string input = rtbInput.Text;
            int commas = 0;
            int position = 0;
            for (int x = 0; x <= 62; x++)
            {
                string check = input.Substring(position, 1);
                if (check == ",")
                {
                    commas++;
                }
                position++;
            }
            rtbOutput.Text = commas + "";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            /* Determine how many words are in the input string */
            string input = rtbInput.Text;
            int words = 1;
            int position = 0;
            for (int x = 0; x <= 62; x++)
            {
                string check = input.Substring(position, 1);
                if (check == " ")
                {
                    words++;
                }
                position++;
            }
            rtbOutput.Text = words + "";

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            /* Remove the first three and last three characters of the input string. */
            string input = rtbInput.Text;
            input = input.Remove(0, 3);
            input = input.Remove(57, 3);
            rtbOutput.Text = input;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            /* Remove the third word in the input string.
             * We will assume that all words are separated by a single space.*/
            string input = rtbInput.Text;
            int words = 1;
            int position = 0;
            int s1 = 0;
            int s2 = 0;
            for (int x = 0; x <= 62; x++)
            {
                string check = input.Substring(position, 1);
                if (check == " ")
                {
                    words++;
                    if (words == 3)
                    {
                        s1 = position;
                        MessageBox.Show(s1 + "");
                    }
                    if (words == 4)
                    {
                        s2 = position;
                        int removeNum = s2 - s1;
                        input = input.Remove(s1, removeNum);
                    }
                }
                if (words == 4)
                {
                }
                else
                {
                    position++;
                }
            }
            rtbOutput.Text = input;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            /*Capitalize the last word in the input string. 
             * We will assume that all words are separated by a single space. */
            string input = rtbInput.Text;
            int lastSpace = input.LastIndexOf(" ");
            int cap = 63 - lastSpace;
            string lastWord = input.Substring(lastSpace, cap);
            input = input.Remove(lastSpace, cap);
            lastWord = lastWord.ToUpper();
            input = input + lastWord;
            rtbOutput.Text = input;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            /* Remove all spaces and then insert an underscore after every 5th character.
             */
            string input = rtbInput.Text;
            input = input.Replace(" ","");

            int position = 0;
            for (int x = 0; x <= 62; x++)
            {
                if (position == 5)
                {
                    input = input.Insert(x, "_");
                    position = -1;
                }
                position++;
            }
            rtbOutput.Text = input;
        }
    }
}
