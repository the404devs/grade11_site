using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjStringFunctions1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            returnValue = String.Compare("elephant", "zebra");
            //Compare is a static function and as a result, it must be called directly from a string and not a variable containing string
            if (returnValue == 0)
            {
                MessageBox.Show("elephant comes before zebra");
            }
            else if (returnValue == 0)
            {
                MessageBox.Show("elephant comes after zebra");
            }
            else
            {
                MessageBox.Show("the two strings are identical");
            }
            //Using the Concat function
            MessageBox.Show (String.Concat("cat", "rat"));
            //Using the indexOf function.
           // This is not a static function and therefore must be called from a string variable containing a string object.
            String data = "elephant";
            returnValue = data.IndexOf("ph");
            MessageBox.Show(returnValue + "");
            //Using the remove function
            String returnValue2 = "";
            returnValue2 = data.Remove(3);
            MessageBox.Show(returnValue2 + "");
           // Using the StartsWith function
            MessageBox.Show(data.StartsWith("cat") + "");
           // Using the Substring funciton
            MessageBox.Show(data.Substring(2, 3));
          //  Using the ToUpper function
            MessageBox.Show(data.ToUpper());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            String input = txtS.Text;
            if (input.IndexOf(s) == -1)
            {
                lblS.Text = "There is no s in this string!";
            }
            else
            {
                lblS.Text = "There is an s in this string!";
            }
        }

        private void btnInitials_Click(object sender, EventArgs e)
        {
            String First = txtFirst.Text;
            String Middle = txtMiddle.Text;
            String Last = txtLast.Text;
            First = First.Substring(0, 1);
            Middle = Middle.Substring(0, 1);
            Last = Last.Substring(0, 1);
            String output = First + "." + Middle + "." + Last;
            lblInitials.Text = output;
        }

        private void btnInitialsL4_Click(object sender, EventArgs e)
        {
            String fullName = txtName.Text;
            String initials = fullName.Substring(0, 1);
            int spaceLocation = fullName.IndexOf(" ");
            if (spaceLocation == -1)
            {
                while (spaceLocation == -1)
                {
                    fullName = fullName.Remove(spaceLocation, 1);
                    initials += "." + fullName.Substring(spaceLocation, 1);
                    spaceLocation = fullName.IndexOf(" ");
                }
            }
            MessageBox.Show(initials);

            
              String fullName = txtName.Text;
              String initials = fullName.Substring(0, 1);
              for (int x = 1; x(name.length); x++)
              {
                  if (name.Substring(x, 1) == " ")
                  initials += name.Substring(x+1,1)+".";
              }
             
        }

        private void btnPunctuation_Click(object sender, EventArgs e)
        {
            //Would be easier if I could do something like this   Boolean Punctuation = Sentence.EndsWith(.    !);
            String Sentence = txtSentence.Text;
            Boolean Punctuation = Sentence.EndsWith(".");
            if (Punctuation == false)
            {
                Punctuation = Sentence.EndsWith("");
                if (Punctuation == false)
                {
                    Punctuation = Sentence.EndsWith("!");
                    if (Punctuation == false)
                    {
                        MessageBox.Show("Punctuation is not correct");
                    }
                }
            }
            if (Punctuation == true)
            {
                MessageBox.Show("Punctuation is correct");
            }
        }
    }
}
