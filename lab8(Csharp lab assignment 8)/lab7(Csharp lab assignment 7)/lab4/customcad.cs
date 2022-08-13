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
    public partial class customcad : UserControl
    {
        private Class1 myVar = new Class1();
        //class1 c = new class1();



        //public string title { get; set; }
        public Class1 MyProperty
        { //
            get { return myVar; }
            set { myVar = value; label1.Text = value.ToString(); label2.Text = value.ToString(); label3.Text = value.ToString(); }
        }
       
        public customcad()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customcad_Load(object sender, EventArgs e)
        {


        }
    }
}
        
    

