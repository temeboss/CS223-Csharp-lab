using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_8
{
    internal class Class1
    {
        private static List<Class1> product = new List<Class1>();

        public string idtext { get; set; }
        public string fntext { get; set; }
        public string lntext { get; set; }
        public string addresstext { get; set; }
        public string datetext { get; set; }
        public string gendertext { get; set; }



        public void save()
        {
            product.Add(this);
           

            // Console.WriteLine("saved");
        }
        public static List<Class1> getall()
        {
            return product;
            // we exe select statement
        }
       
    }
}
