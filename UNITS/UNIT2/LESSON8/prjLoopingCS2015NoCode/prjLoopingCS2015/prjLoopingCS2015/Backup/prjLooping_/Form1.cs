using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjLooping_
{
    public partial class Form1 : Form
    {
        double principal = 0;
        double rate = 0;
        double interest = 0;
        int year = 0;
        int term = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            int term = Convert.ToInt16(txtTerm.Text);
            rate = Convert.ToDouble(txtRate.Text);
            principal = Convert.ToDouble(txtPrincipal.Text);
            year = 0;

            do
            {

                interest = Math.Round(principal * rate / 100.0, 2);
                principal += interest;
                year++;

                rtbResults.Text += "\n" + "Year: " + year + "      New Principal: $" + principal + "      Interest: $" + interest;

            } while (year < term);
        }

        private void btnPreConditionLoop_Click(object sender, EventArgs e)
        {
            //a precondition loop has its condition at the start
            //as a result it can iterate a minimum of zero times

            //here's a simple example of a precondition loop
           /* while (1 == 1)//this condition creates an
                //infinite loop i.e. iterates forever
            {
                MessageBox.Show("Hello");
            }
            */

            int c = 0;
            while (c <5)
            {  
                c+=3;
                MessageBox.Show("The trace value of c is " + c);
              
            }

        }
    }
}
