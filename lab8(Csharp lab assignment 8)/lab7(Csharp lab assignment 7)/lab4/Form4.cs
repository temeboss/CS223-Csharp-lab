using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //indicator.Top = 120;
            //panel1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            indicator.Top = 80;
            panel1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indicator_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
