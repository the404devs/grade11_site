using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjArrays
{
    public partial class Form1 : Form
    {
        String[] names = new String[5];
        Double[] numbers = new double[10000];

        //Parallel arrays
        String[] students = { "Bob", "Larry", "Steve", "Homer", "Trump" };
        String[] phoneNumbers = { "1-800-DANKMEMES", "696-969-6969", "888-888-8888", "Can't afford a phone", "Russia" };


        int[] data = { 3, 7, 6, 3, 2, 1, 6 };
        //function using an array as a parameter
        int sum(int[] values)
        {
            int answer = 0;
            for (int x = 0; x < values.Length; x++)
            {
                answer += values[x];
            }
            return answer;
        }

        Random r = new Random();
        int number = 0;
        string select = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            names[0] = "Bob";
            names[2] = "Kevin";
            names[3] = "Jatin";
            names[4] = "Pepe";
            btnProcess1.Enabled = true;
            btnProcess2.Enabled = true;
            btnProcess3.Enabled = true;
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = r.Next(0, 11);
            }
            MessageBox.Show("Arrays Filled!");

            //Fill the parallels
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            number = r.Next(0, 5);
            select = names[number];
            lblOut1.Text = select;
            string inputName = txtIn1.Text;
            for (int x = 0; x < names.Length; x++)
            {
                if (names[x] == inputName)
                {
                    MessageBox.Show("You exist!");
                    return;
                    //return stops this whole function. yay.
                }

            }
            MessageBox.Show("You don't exist!");

            double total = 0;
            double average = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                total += numbers[x];
            }
            average = total / numbers.Length;
            MessageBox.Show("The average is " + average);

        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            //Parallel Arrays
            String student = txtIn2.Text;
            String studentPN = "";
            for (int x = 0; x < students.Length; x++)
            {
                if (students[x] == student)
                {
                    studentPN = phoneNumbers[x];
                    break;
                }
            }
            lblOut2.Text = studentPN;

        }

        private void btnProcess3_Click(object sender, EventArgs e)
        {
            lblOut3.Text = sum(data)+"";
        }
    }
}
