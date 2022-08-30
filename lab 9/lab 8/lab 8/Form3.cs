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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source= DESKTOP\OJ5AJOP; Initial Catalog=Csharp integrated security=true ";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show(" worked");
                string query = "select * from ACCOUNTING";
                SqlCommand can = new SqlCommand(query, con);
                //var result = can.ExecuteReader();
                var rowsaffected = can.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected.ToString());

                while (result.Read)
                   
                {
               
                    string c.name = result[0].ToString();
                    string c.

                }

                //var rowsaffected = can.excutescalar();
            }
            catch
            {
                MessageBox.Show("its working");
            };

        }
    }
}
