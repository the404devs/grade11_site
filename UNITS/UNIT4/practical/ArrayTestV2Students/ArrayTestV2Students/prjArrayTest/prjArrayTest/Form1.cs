using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjArrayTest
{
    public partial class Form1 : Form
    {
        /***************DO NOT TOUCH ANY CODE ALREADY WRITTEN. SIMPLY ADD YOUR OWN TO
         * SUCCESSFULLY FILL THE LABELS IN THE FORM WITH THE ANSWERS.*********************/

        StreamReader sw;
        string[] words;//WORDS IS REQUIRED TO SOLVE THE WORS ARRAY PROBLEMS
        int[] numbers;//NUMBERS IS REQUIRED TO SOLVE THE NUMBERS ARRAYS PROBLEMS
        String _temp;
        int[] test = new int[10];

        public Form1()
        {
            InitializeComponent();
             String[] delimiterChars = { "\r","\r\n","\t"};
             sw= new StreamReader("words.txt");
             words = sw.ReadToEnd().Split(delimiterChars, StringSplitOptions.None);
             sw.Close();
             for (int x = 0; x < words.Length; x++)
             {
                 _temp = words[x];
                 words[x] = _temp.Trim();
             }
             sw = new StreamReader("numbers.txt");
             String[] temp = sw.ReadToEnd().Split(delimiterChars, StringSplitOptions.None);
             sw.Close();
             numbers = new int[temp.Length];
             for (int x = 0; x < temp.Length; x++)
             {
                 numbers[x]=Convert.ToInt16 (temp[x]);

             }
             lblStatus.Text = "All words and numbers are loaded into the array. Processing may commence.";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            /************************WORD ARRAY******************************************/
            //Check if the wrod array is over 1000 elements long.
            if (words.Length > 1000)
            {
                lblWordSize.Text = "Yes";
            }
            else
            {
                lblWordSize.Text = "No";
            }

            //Display the second element in the word array
            lblFirstWord.Text = words[1];

            //Display the second last word in the array
            lblLastWord.Text = words[words.Length - 1];

            //Combine the 100th word and 200th word in the array
            lbl100thWord.Text = words[99] + words[199];

            //Display the number of words that start with t or T
            int t = 0;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].StartsWith("t") == true || words[x].StartsWith("T") == true)
                {
                    t++;
                }

            }
            lblSwords.Text = t + "";

            //Display the number of words that contain the substring "the"
            int y = 0;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].Contains("the") == true || words[x].Contains("The") == true)
                {
                    y++;
                }

            }
            lblGiveWords.Text = y + "";

            //Check if the word "nonulcerously" is in the list
            Boolean hasWord = false;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x] == "nonulcerously")
                {
                    hasWord = true;
                }

            }
            lblPlethExists.Text = hasWord + "";

            //Show the number of words more than 14 letters long
            int count14 = 0;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].Length >= 14)
                {
                    count14++;
                }

            }
            lblDifferenceHotCold.Text = count14 + "";

            //Find the length of the longest word            
            int lengthTemp = 0;           
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].Length >= lengthTemp)
                {
                    lengthTemp = words[x].Length;
                }
            }
            lblLargestWord.Text = lengthTemp + "";

            /************************NUMBER ARRAY******************************************/
            //Show the size of the number array
            lblNumbersSize.Text = numbers.Length + "";

            //Show the first number in the array
            lblFirstNumber.Text = numbers[0] + "";

            //Show the last number in the array
            lblLastNumber.Text = numbers[numbers.Length - 1] + "";

            //Display the average of the first 10 numbers in the array
            double total = 0;
            double average = 0;
            for (int x = 0; x < 10; x++)
            {
                total = total + numbers[x];

            }
            average = total / 10;
            lblAverage.Text = average + "";

            //Display the number of numbers that are greater than 1000
            int over1000 = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] >= 14)
                {
                    over1000++;
                }

            }
            lblNumbersBelow.Text = over1000 + "";

            //Show the largest number in the array          
            int bigNum = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] >= bigNum)
                {
                    bigNum = numbers[x];
                }
            }
            lblLargestNumber.Text = bigNum + "";

            //Show the smallest number in the array
            int smallNum = bigNum;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] <= smallNum)
                {
                    smallNum = numbers[x];
                }
            }            
            lblSmallestNumber.Text = smallNum + "";

            //Show the number of odd numbers in the array
            int odds = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 != 0)
                {
                    odds++;
                }
            }
            lblNumberEvenNumbers.Text = odds + "";

            //Display the difference between the 10th and 20th elements
            //Hooray for an easy one at the end!
            int diff = numbers[19] - numbers[9];
            lblFactorial.Text = diff + "";
        }
    }
}


