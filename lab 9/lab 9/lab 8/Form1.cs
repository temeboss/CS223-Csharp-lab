using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lec_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            

            bool b1 = male.Checked;
           

            Class1 c = new Class1
                {
                    idtext = idtext.Text,
                    fntext = fntext.Text,
                    lntext = lntext.Text,
                    addresstext = addresstext.Text,
                    datetext = datetext.Text,
                    gendertext = b1 ? "male": "female",
                };

                c.save();
                

            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);

            foreach (Control item in flowLayoutPanel1.Controls.OfType<card>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(item);
            }
            foreach (var item in Class1.getall())
            {

                
                card card = new card();
               
                    card.Id = item.idtext;
                    card.First = item.fntext;
                    card.last = item.lntext;
                    card.address = item.addresstext;
                    card.date = item.datetext;
                    card.gender = item.gendertext;

                    card.Show();
                    flowLayoutPanel1.Controls.Add(card);

                //MessageBox.Show(card.Id);
                //MessageBox.Show(card.First = item.fntext);

                card.Click += (object o, EventArgs E) =>
                {

                };

                

            }
           



        }

       

        private void card1_Load(object sender, EventArgs e)
        {

        }



        private void idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void card1_Load_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void card1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
