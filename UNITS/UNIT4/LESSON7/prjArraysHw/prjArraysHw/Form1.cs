using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//߷
namespace prjArraysHw
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[100];
        int[] data = new int[10];
        double[] Power = new double[100];
        Random r = new Random();
        double sum = 0;
        double average = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /*double avg(double[] data) 
        {
            double sum = 0;
            for (int x = 0; x < data.Length; x++)
           {
              sum += data[x];
           }
            return (sum /data.Length);
        }*/
        void randomnumbers()
        {
            RTBOutput.Text = String.Empty;
            for (int x = 0; x < data.Length; x++)
            {
                data[x] = r.Next(1, 101);
            }
            for (int x = 0; x < data.Length; x++)

            {
                RTBOutput.Text += data[x] + " ";
            }

            RTBOutput.Text += "\n";//line break.
        }

        int averageofnumbers(int[] numbrs)
        {
            //Calculating the average of our 10000 element array.
            int sum = 0;
            for (int x = 0; x < numbrs.Length; x++)
                {
                    sum += numbrs[x];
                }
            int average = sum / numbrs.Length;
            return average;

        }
        void maximumnumber()
        {
            int max = 0;
            for (int x = 0; x < data.Length; x++)
            {
                if (max < data[x])
                {
                    max = data[x];
                }
                else if (max > data[x])
                {
                    RTBOutput.Text = "Maximum is: " + max;

                }
            }
        }

        void minimumnumber()
        {
            int min = 100;

            for (int y = 0; y < data.Length; y++)
            {
                if (min > data[y])
                {
                    min = data[y];
                }
                else if (min < data[y])
                {
                    RTBOutput.Text = "Minimum is: " + min;
                }
            }

        }




        private void BtnFill_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < numbers.Length; x++)
                numbers[x] = r.Next(0, 11);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int avg = averageofnumbers(numbers);
            MessageBox.Show("The total of all the numbers is " + sum);
            average = sum / numbers.Length;
            MessageBox.Show("The average is " + average);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] data = new int [10];
            double avg = 0;
            double sum = 0;
            for (int x = 0; x < data.Length; x++)
           {
              sum += data[x];
           }
        MessageBox.Show (sum /data.Length + "");

        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            randomnumbers();
        }

        private void BtnMaximum_Click(object sender, EventArgs e)
        {
            maximumnumber();
        }

        private void BtnMinimum_Click(object sender, EventArgs e)
        {
            minimumnumber();
        }
        // Power Number

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            rtbExponent.Text =  String.Format("{0,-10} {1,-10}", "index", "exponent");

            for (int x = 0; x < Power.Length; x++)
            {
                Power[x] = Math.Pow(x, 2);
                rtbExponent.Text = rtbExponent.Text + "\n" + String.Format("{0,-10} {1,-10}", x, Power[x]);
            }

        }

        private void LblNumber_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int avg = averageofnumbers(numbers);
            rtbOutputs.Text = "The average of the numbers is " + avg;
        }

        private void BtnNumbers2_Click(object sender, EventArgs e)
        {
            rtbOutputs.Text = String.Empty;
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = r.Next(1, 101);
                rtbOutputs.Text += numbers[x] + " ";
            }

        }

        private void BtnMax2_Click(object sender, EventArgs e)
        {
            int max = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (max < numbers[x])
                {
                    max = numbers[x];
                }
                else if (max > numbers[x])
                {
                    rtbOutputs.Text = "Maximum number is " + max;
                }
            }

        }

        private void BtnMin2_Click(object sender, EventArgs e)
        {
            int min = 100;

            for (int y = 0; y < data.Length; y++)
            {
                if (min > numbers[y])
                {
                    min = numbers[y];
                }
                else if (min < numbers[y])
                {
                    rtbOutputs.Text = "Minimum number is " + min;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn1000Numbers_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < data.Length; x++)
            {
                data[x] = r.Next(1, 1001);
            }
            MessageBox.Show("The numbers have been Created!");
            int number = Convert.ToInt16(txtNumberInput.Text);
            int iterations = 0;
                for (int x = 0; x < data.Length; x++)
                {
                    iterations++;
                    if (number == data[x])
                    {
                        MessageBox.Show("The number " + number + "is at position # " + iterations);
                    }
                    else if (number != data[x])
                    {
                        MessageBox.Show("The number " + number + "is not in the loop.");
                    }
                }
       }
    }    
}
