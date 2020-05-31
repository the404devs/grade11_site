using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPropertiesAndCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            /*The following is the click event for the button btnChange*/
            /* the format for changing the property of an object in an event is as follows:
             componentName.propertyName=value as appropriate type;*/
            picImage.Visible = true;
            lblOutputData.Text = "Game over!";
            /*"Game over!" is a string. Strings are data that contains text which may contain numbers. A string must be enclosed in quotes*/
            btnChange.Width = 100;
            txtData.BackColor = Color.Blue;
            lblOutputData.Text = txtData.Text;
            picImage.Width = picImage.Height;
            /*the above lines of code are acceptable because you are assigning the proper data type to a property. As long as a text property gets a sting or a width property gets a number it doesn't matter where it comes from.*/
        }

        private void scrInfo_Scroll(object sender, ScrollEventArgs e)
        {
            lblOutputData.Text = Convert.ToString(scrInfo.Value);
            /*Gotta convert the Value property to a string so it works.*/
        }
    }
}
