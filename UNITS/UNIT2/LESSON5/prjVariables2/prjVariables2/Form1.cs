using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVariables2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Pennies = 0, Nickels = 0, Dimes = 0, Quarters = 0, Total = 0;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Pennies = Convert.ToDouble(txtPenny.Text);
            Nickels = Convert.ToDouble(txtNickel.Text);
            Dimes = Convert.ToDouble(txtDime.Text);
            Quarters = Convert.ToDouble(txtQuarter.Text);

            Pennies = Pennies * 0.01;
            Nickels = Nickels * 0.05;
            Dimes = Dimes * 0.10;
            Quarters = Quarters * 0.25;

            Total = Pennies + Nickels + Dimes + Quarters;

            txtTotal.Text = ("$"+Convert.ToString(Total));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Pennies = 0;
            Nickels = 0;
            Dimes = 0;
            Quarters = 0;
            Total = 0;

            txtPenny.Text = ("0");
            txtNickel.Text = ("0");
            txtDime.Text = ("0");
            txtQuarter.Text = ("0");
            txtTotal.Text = ("$0");
        }
    }
}
