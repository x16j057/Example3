using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            lblAns1.Text = String.Format("{0}", 1 + 2 * 3);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblAns2.Text = String.Format("{0}", (1 + 2) * 3);
        }
    }
}
