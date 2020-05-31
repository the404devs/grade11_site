using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            lblRed.Width = btnMaybe.Width;
            lblRed.Height = btnMaybe.Height;
        }

        private void lblTop_DoubleClick(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.Green;
        }

        /*private void txtLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLeft.Font.Name = new Font("Tahoma", "8.25");
         }*/


        private void lblRed_MouseHover(object sender, EventArgs e)
        {
            lblRed.BackColor = Color.Green;
        }

        private void lblRed_MouseLeave(object sender, EventArgs e)
        {
            lblRed.BackColor = Color.Red;
        }

        private void lblYellow_MouseHover(object sender, EventArgs e)
        {
            lblYellow.BackColor = Color.Green;
        }

        private void lblYellow_MouseLeave(object sender, EventArgs e)
        {
            lblYellow.BackColor = Color.Yellow;
        }

        private void lblBlue_MouseHover(object sender, EventArgs e)
        {
            lblBlue.BackColor = Color.Green;
        }

        private void lblBlue_MouseLeave(object sender, EventArgs e)
        {
            lblBlue.BackColor = Color.Blue;
        }

        private void lblBrown_MouseHover(object sender, EventArgs e)
        {
            lblBrown.BackColor = Color.Green;
        }

        private void lblBrown_MouseLeave(object sender, EventArgs e)
        {
            lblBrown.BackColor = Color.DarkRed;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNo.Visible = false;
        }

        private void btnMaybe_Click(object sender, EventArgs e)
        {
            txtLeft.Text = "May";
            txtRight.Text = "be";
        }

        private void txtRight_DoubleClick(object sender, EventArgs e)
        {
            txtRight.Enabled = false;
        }

        private void txtLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLeft.Font = new Font("Tahoma", 18);
            txtLeft.Font = new Font("Tahoma", 18, FontStyle.Bold);
        }
    }

    namespace Unit2Test
    {
        class Form1
        {
        }
    }
}
