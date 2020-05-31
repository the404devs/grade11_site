using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjScope
{
    public partial class Form1 : Form
    {
        /*Scope referrs to the range of accessibility of variables, functions, and classes.
         * It is in part determined by the location of the block off code in which it is declared.
         * There are 2 main types of variables you are responsible for understanding
         * Local and instance (form level)*/
        /*All instance variables are made under the public partial class Form1 line
         * These are accessible anywhere in the form block.*/
        int x = 0;
        int y = 0;
        int z = 0;
        public Form1()//constructor block
        {
            InitializeComponent();
            x = 10;//ok
        }

        private void button1_Click(object sender, EventArgs e)// event function block
        {
            MessageBox.Show(x + "");//ok
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 20;//ok
            int a = 5;//local variable, only accessible in this function
            MessageBox.Show(a + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
           // MessageBox.Show(a + "");
            //Not ok because "a" is not avaliable in this part of the code
            int x = 5;         
            MessageBox.Show(x + "");//x refers to the LOCAL x
            //to get instance x, use "this"
            MessageBox.Show(this.x + "");
            
        }
    }
}
