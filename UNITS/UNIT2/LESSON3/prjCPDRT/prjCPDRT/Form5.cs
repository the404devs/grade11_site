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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void scrH_Scroll(object sender, ScrollEventArgs e)
        {
            pboxMario.Width = scrH.Value;
        }

        private void scrV_Scroll(object sender, ScrollEventArgs e)
        {
            pboxMario.Height = scrV.Value;
        }

       
    }
}
