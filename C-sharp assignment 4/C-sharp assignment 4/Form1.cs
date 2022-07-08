using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labGUI_1.Properties;

namespace labGUI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            items c = new items
            {
                number = txt_Number.Text,
                inventory = txt_Inventory.Text,
                objectname = txt_object.Text,
                count = txt_Count.Text,
                price = txt_Price.Text,
            };
            MessageBox.Show("saved");

        }

        private void txt_Inventory_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_object_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

