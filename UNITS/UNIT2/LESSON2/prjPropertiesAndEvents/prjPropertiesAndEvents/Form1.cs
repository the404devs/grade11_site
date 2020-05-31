using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPropertiesAndEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*The following is refered to as an Event Function. It is a block of code that will be executed when the specified object has the specified event occur (In this case, when it is clicked.)*/

        private void button1_Click(object sender, EventArgs e)
        {
            /*Whatever code that is in here will be executed when button1 is clicked.*/
            MessageBox.Show("Dab");
        }/*The button function ends here*/

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dank Memes");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Water Bottle Flip");
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Get back here");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
