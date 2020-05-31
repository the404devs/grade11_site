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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblHi.Visible = true;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
        
    }
}

