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
    public partial class Form4 : Form
    {
        double Celsius = 0;
        double Fahrenheit = 0;
        public Form4()
        {
            InitializeComponent();
        }
        

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            Celsius = Convert.ToDouble(txtCelsius.Text);
            Fahrenheit = ((Celsius * 9)/5) + 32;
            lblOutput.Text = Fahrenheit + "";
            btnReset.Enabled = true;
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            Fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            Celsius = ((Fahrenheit - 32) * 5)/9;
            lblOutput.Text = Celsius + "";
            btnReset.Enabled = true;
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "")
            {
                btnCtoF.Enabled = true;
                txtFahrenheit.Enabled = false;
            }
            else
            {
                btnCtoF.Enabled = false;
                txtFahrenheit.Enabled = true;
                lblOutput.Text = "";                
            }
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txtFahrenheit.Text != "")
            {
                btnFtoC.Enabled = true;
                txtCelsius.Enabled = false;
            }
            else
            {
                btnFtoC.Enabled = false;
                txtCelsius.Enabled = true;
                lblOutput.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Celsius = 0;
            Fahrenheit = 0;
            txtCelsius.Text = "";
            txtFahrenheit.Text = "";
            lblOutput.Text = "";
            btnReset.Enabled = false;
            btnFtoC.Enabled = false;
            btnCtoF.Enabled = false;
        }

        private void txtCelsius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Celsius = Convert.ToDouble(txtCelsius.Text);
                Fahrenheit = ((Celsius * 9) / 5) + 32;
                lblOutput.Text = Fahrenheit + "";
                btnReset.Enabled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtFahrenheit.Focus();
            }
        }

        private void txtFahrenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
                Celsius = ((Fahrenheit - 32) * 5) / 9;
                lblOutput.Text = Celsius + "";
                btnReset.Enabled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtCelsius.Focus();
            }
        }
    }
}
