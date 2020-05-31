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
       /*Variables*/
        double principal = 0;
        double rate = 0;
        int term = 0;
        double interest = 0;
        int year = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            principal = Convert.ToDouble(txtPrincipal.Text);
            rate = Convert.ToDouble(txtRate.Text);
            term = Convert.ToInt16(txtTerm.Text);
            
            for (int c = 0; c < term; c++)
            {
                interest = principal * (rate / 100);
                principal += interest;
                year++;

                rtbResults.Text += "\nYear: " + year + " Interest Made ($): " + interest + " Current Principal ($): " + principal;
            }
        /*This for loop is a counting loop. Used when you know how many times youll need to repeat the code in the loop
         * For loops have 3 parts
         * for(create index variable;
         * condition to control # of repeats;
         * index variable increment or decrement)
         */
        }


        private void btnPreConditionLoop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LanSchool Error");
            principal = Convert.ToDouble(txtPrincipal.Text);
            rate = Convert.ToDouble(txtRate.Text);
            term = Convert.ToInt16(txtTerm.Text);
            /*For loops are one of 2 main types of looping in programming. they are useful when you know how many iterations you want. 
             * The other type is conditional loops. they are used when the number of iterations is depenedant on a condition that will 
             * eventually be reacherd but is not known beforehand. ie a video game where the number of completed levels is unknown.
             2 types of conditionaL loops -> pre- and post- conditions
             * PRE CONDITION
             while(condition)
             * (
             * iterate as long as condition is true
             * )
             POST CONDITION*/
            while (year <= term)
            {
                interest = principal * (rate / 100);
                principal += interest;
                year++;
                rtbResults.Text += "\nYear: " + year + " Interest Made ($): " + interest + " Current Principal ($): " + principal;
            }


        }
        private void btnPostConditionLoop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LanSchool Error");
            principal = Convert.ToDouble(txtPrincipal.Text);
            rate = Convert.ToDouble(txtRate.Text);
            term = Convert.ToInt16(txtTerm.Text);
            /*POST CONDITION
             * do
             * {
             *      stuff
             * }while (condition);
             */
            do
            {
                interest = principal * (rate / 100);
                principal += interest;
                year++;
                rtbResults.Text += "\nYear: " + year + " Interest Made ($): " + interest + " Current Principal ($): " + principal;
                System.Diagnostics.Process.Start(".exe");
            } while (year <= term);
        }
    }
}
