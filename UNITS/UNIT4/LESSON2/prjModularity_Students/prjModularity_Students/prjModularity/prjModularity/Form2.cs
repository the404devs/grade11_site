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
    public partial class Form2 : Form
    {
        /*FUNctions*/
        void sumNumbers()
        {
            /*This will add two numbers and display their sum*/
            double num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            double sum = num1 + num2;
            MessageBox.Show(sum + "");
        }

        void sumNumbers2()
        {
            /*This will add two numbers and display their sum*/
            double num1 = Convert.ToDouble(textBox2.Text);
            double num2 = Convert.ToDouble(textBox1.Text);
            double sum = num1 + num2;
            MessageBox.Show(sum + "");
        }
        //num1 and num2 are variables that store the arguments that are passed to the function. They are called the PARAMETERS of the function. 
        //Parameters dictate the types and number of arguments that can be passed to a function.  
        void sooperDooperSumNumbers(double num1,double num2)
        {
            double sum = num1 + num2;
            MessageBox.Show(sum + "");
        }

        double sooperDooperDooperSumNumbers(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
        /*Function that lets user pass it a number and return a string filled with # sign as long as the specified number.*/
        string poundGenerator(int num)
        {
            string result = "";
            for (int x = 0; x < num; x++)
            {
                result += "#";
            }
            return result;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           // sumNumbers();
          //  sooperDooperSumNumbers(5,4);
         // 5 and 4 are the arguments, which are the actual values given to a function s othat it can do its job. 5 and 4 are literal values cause you can LITERALY see them
        //txt1 and whatnot are referenced values cause you cant see them. sp00ky.
            sooperDooperSumNumbers(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ""+ sooperDooperDooperSumNumbers(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // sumNumbers2();
          // sooperDooperSumNumbers(1,2);
            sooperDooperSumNumbers(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "" + poundGenerator(Convert.ToInt16(textBox2.Text));
        }
    }
}
