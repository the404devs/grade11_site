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
    public partial class Form2 : Form
    {
        double Pounds = 0;
        double Ounces = 0;
        double Total = 0;
        double Cost = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Pounds = Convert.ToInt16(txtPounds.Text);
            Ounces = Convert.ToInt16(txtOunces.Text);

            Total = (Pounds / 0.0625) + Ounces;
            Cost = Total * 0.15;
            lblTotal.Text = Total + "";
            lblCost.Text = Cost + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            double Pounds = 0;
            double Ounces = 0;
            double Total = 0;
            double Cost = 0;

            lblCost.Text = "";
            lblTotal.Text = "";
            txtOunces.Text = "";
            txtPounds.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
