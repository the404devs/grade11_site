using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCPDRT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lblBlue_MouseMove(object sender, MouseEventArgs e)
        {
            lblMid.BackColor = lblBlue.BackColor;
        }

        private void lblRed_MouseMove(object sender, EventArgs e)
        {
            lblMid.BackColor = lblRed.BackColor;
        }

        private void lblYellow_MouseMove(object sender, EventArgs e)
        {
            lblMid.BackColor = lblYellow.BackColor;
        }

        private void lblGreen_MouseMove(object sender, EventArgs e)
        {
            lblMid.BackColor = lblGreen.BackColor;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void lblWhite_MouseHover(object sender, EventArgs e)
        {
            lblMid.BackColor = lblWhite.BackColor;
        }

    }
}