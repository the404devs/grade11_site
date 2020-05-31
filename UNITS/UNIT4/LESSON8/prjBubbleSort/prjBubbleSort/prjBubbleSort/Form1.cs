using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBubbleSort
{
    public partial class Form1 : Form
    {
        int[] data = new int[10];
        Random r = new Random();

        void displayArray()
        {
            //display values
            for (int x = 0; x < data.Length; x++)
            {
                rtbOutput.Text += data[x] + " ";
            }
            rtbOutput.Text += "\n";//New line
        }

        void bubbleSort()
        {
            //Sort array
            int temp = 0;//use for swapping
            for (int y = 0; y < data.Length; y++)//Repeat passes
            {
                for (int x = 0; x < data.Length - 1; x++)//One pass
                {
                    if (data[x] > data[x + 1])
                    {
                        //swap if greater
                        temp = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = temp;
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateAndDisplay_Click(object sender, EventArgs e)
        {
            //Fill array
            for (int x = 0; x < data.Length; x++) 
            {
                data[x] = r.Next(0, 101);
            }
            displayArray();
            
        }

        private void btnSortAndDisplay_Click(object sender, EventArgs e)
        {
            bubbleSort();
            displayArray();
        }


      

        private void btnTestSortFunction_Click(object sender, EventArgs e)
        {
           
        }

      

       
    }
}
