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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customcad1_Load(object sender, EventArgs e)
        {
            //Class1 cl= new Class1();
            //List<string> d = new List<string>() { "item 1", "item 2", "item3" };
            flowLayoutPanel1.Controls.Clear();
            //foreach (var item in Class1.getall())
            foreach (var item in Class1.getall())
            {
            customcad c = new customcad();
            c.MyProperty = item;
            // c.title = item;
            //add the rest 
            flowLayoutPanel1.Controls.Add(c);
            }
        }
        // added custom card, indicator, flowlayoutpanel
    }
}
