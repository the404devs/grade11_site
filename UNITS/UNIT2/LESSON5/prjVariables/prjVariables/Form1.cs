using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Most programs follow the IPO model.
         * IPO is Input Processing Output.
         * This means most programs will need data as input, then will perform calculations and/or descisions on that data, and then provide a response to the processing.
         * most data that is provided to a program must first be stored in a memory block
         *  all memory blocks must be reserved before they can be used
         *  these are called variables
         *  When reserving (declaring) variables, you must give it a name and data type.           
         * Data types refer to the type of data to be stored in the variable. */
        /*Make all variables here*/
        double initialCost = 0;
        double taxRate = 0;
        double taxes = 0;
        double total = 0;
        /* Format for declaring is
         * datatype name=value*/
        private void btnCalc_Click(object sender, EventArgs e)
        {
           /* input the cost and tax rate into the vaiables*/
            taxRate = Convert.ToDouble(txtTaxRate.Text);
            initialCost = Convert.ToDouble(txtInitialCost.Text);
            /*Processing:
             * here we are going to calculate the taxes and add it to the initial cost for the final cost.*/
            taxRate = taxRate / 100.0;
            taxes = initialCost * taxRate;
            total = initialCost + taxes;
            /* 
             * * is multiply
             * / is division
             * +is addition
             * - is subtraction*/
            /*output:
             * here we display the results of the calculations*/
            lblTaxes.Text = taxes + "";
            lblTotal.Text = total + "";
            txtInitialCost.Enabled = true;
            txtTaxRate.Enabled = false;
            btnCalc.Enabled = false;
        }

        private void txtInitialCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTaxRate.Enabled = true;
        }

        private void txtTaxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCalc.Enabled = true;
        }
    }
}
