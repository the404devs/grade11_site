using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjModularity2
{
    public partial class Form1 : Form
    {
        /*Functions*/
        double totalValue(int Q, int D, int N, int P)
        {
            double sum = (Q * 0.25 + D * 0.1 + N * 0.05 + P * 0.01);
            return sum;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Q = Convert.ToInt16(txtQ.Text);
            int D = Convert.ToInt16(txtD.Text);
            int N = Convert.ToInt16(txtN.Text);
            int P = Convert.ToInt16(txtP.Text);
            lblOutput.Text = "$" + totalValue(Q, D, N, P);
        }
    }
}
