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
        //Make all variables here. This will change in the future
        //when we learn about the topic "Scope".
        string UN = "";
        string pass = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void picStatus_Click(object sender, EventArgs e)
        {
            //Have the user enter their login and password.
            //When the image is clicked we check that these
            //credentials are correct (user="ICS3U" and psed="computers").
            //If correct we enable the login button and show the access granted image, otherwise
            //we show the access denied image.


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
            UN = txtUsername.Text;
            pass = txtPassword.Text;
           
            /*if (UN == "ICS3U")
                if (pass == "computers")
                {
                    btnLogin.Enabled = true;
                    picStatus.Image=Image.FromFile("images/accessGranted.jpeg");
                    mario.Visible=true; 
        }      
                else
            {
                    picStatus.Image=Image.FromFile("images/accessDenied.jpeg");
                    mario.Visible=false;
        }                  
            else
            {
                picStatus.Image=Image.FromFile("images/accessDenied.jpeg");
                mario.Visible=false;
        }*/
            if (UN == "ICS3U" && pass == "computers")
            {
                btnLogin.Enabled = true;
                picStatus.Image = Image.FromFile("images/accessGranted.jpeg");
                mario.Visible = true;
            }
            else
            {
                picStatus.Image = Image.FromFile("images/accessDenied.jpeg");
                mario.Visible = false;
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if login credentials are correct then enable this button and go to form2
           Form2 frm = new Form2();
           frm.Show();
          
        }
    }
}
