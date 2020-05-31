using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Stuff
{
    public partial class Form1 : Form
    {
        int grade = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            grade = Convert.ToInt16(txtGrade.Text);
            if (grade >= 101)
            {
                lblGrade.Text = "Cheater!";
                lblGrade.ForeColor = Color.Black;
            }
            else if (grade >= 90)
            {
                lblGrade.Text = "A+";
                lblGrade.ForeColor = Color.Green;
            }
            else if (grade >= 80)
            {
                lblGrade.Text = "A";
                lblGrade.ForeColor = Color.LimeGreen;
            }
            else if (grade >= 70)
            {
                lblGrade.Text = "B";
                lblGrade.ForeColor = Color.Yellow;
            }
            else if (grade >= 60)
            {
                lblGrade.Text = "C";
                lblGrade.ForeColor = Color.Orange;
            }
            else if (grade >= 50)
            {
                lblGrade.Text = "D";
                lblGrade.ForeColor = Color.OrangeRed;
            }
            else if (grade >= 1)
            {
                lblGrade.Text = "F";
                lblGrade.ForeColor = Color.Red;
            }
            else
            {
                lblGrade.Text = "Unacceptable";
                lblGrade.ForeColor = Color.Black;
            }
        }
    }
}
