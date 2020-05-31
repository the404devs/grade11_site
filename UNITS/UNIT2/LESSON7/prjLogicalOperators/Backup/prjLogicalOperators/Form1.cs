using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjLogicalOperators
{
    public partial class Form1 : Form
    {
        string user = "";
        string pswd = "";
        Form f;

        public Form1()
        {
            InitializeComponent();
        }

        private void picStatus_Click(object sender, EventArgs e)
        {
            user = txtUsername.Text;
            pswd = txtPassword.Text;

            if(user=="ICS3U" && pswd =="computers")
            {
                picStatus.Image = Image.FromFile("images/accessGranted.jpeg");
                btnLogin.Enabled = true;
            }
            else
            {
                picStatus.Image = Image.FromFile("images/accessDenied.jpeg");
            }
            /*The Logical Operators
             * A logical operator is used to create a more
             * sophisticated condition by combining separate
             * conditions using the AND (&&) or OR(||)
             * operators. When using && both conditions
             * on either side have to be true so that it all
             * evaluates to true. When using the || only one
             * condition needs to be true so that it all 
             * evaluates to true.
             * The last logical operator is the NOT(!). The !
             * operator inverts the value of your condition.
             * Example: !(1==2)-->true
             * 
             */

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();

        }
    }
}
