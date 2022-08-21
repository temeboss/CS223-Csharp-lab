using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec_8
{
    public partial class card : UserControl
    {
        private string ID;

        Class1 c = new Class1();
        public string Id
        {
            get { return ID; }
            set { ID = value; idmodel.Text = value; }
        }
        private string fn;

        public string First
        {
            get { return fn; }
            set { fn += value; fnmodel.Text = value; }
        }
        
        private string ln;

        public string last
        {
            get { return ln; }
            set { ln = value; lnmodel.Text = value; }
        }
        private string add;

        public string address
        {
            get { return add; }
            set { add = value; addressmodel.Text = value; }
        }
        private string schoolyear;

        public string date
        {
            get { return schoolyear; }
            set { schoolyear = value; datemodel.Text =value ; }
        }
        private string gen;

        public string gender
        {
            get { return gen; }
            set { gen = value; gendermodel.Text = value; } 
        }
        public card()
        {
            InitializeComponent();
        }

        private void card_Load(object sender, EventArgs e)
        {

           

        }
    }
}
