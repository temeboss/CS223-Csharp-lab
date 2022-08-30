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
                String connectionstring = @"Data Source=HP\SQLEXPRESS; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show("Connected");
                string query = "select fname,lname from student";//"insert into student values ('ss' ,'ddd');";
                SqlCommand com = new SqlCommand(query,con);
                var result = com.ExecuteReader(); // or execute scalar() - return single element
                                                  // var rowsaffected = com.ExecuteNonQuery(); //-rows affected
                                                  // MessageBox.Show(rowsaffected.ToString());
                /*
                while(result.read){
                string name=result[0];
                            result["name"] // can access it with its attribute
                messagebox.show("[id]+[name]")

                }
                 */
                while (result.Read())
                {
                    string fname = result["fname"].ToString();
                    string lname =result["lname"].ToString();
                    MessageBox.Show(fname+lname);
                }


            }
            catch
            {
                MessageBox.Show("error");
            };
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
