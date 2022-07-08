using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGUI_1.Properties
{
    internal class items 
    {

        public string number { get; set; }
        public string inventory { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }

        public void save()
        {
            Console.WriteLine("saved");
        }

       

    }
}
