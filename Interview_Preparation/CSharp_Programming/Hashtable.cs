using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class TestHashtable
    {
        public static void TestHbl()
        {
            Hashtable htbl = new Hashtable();
            htbl.Add("1", "value1");
            htbl.Add("1", "value2");

            Console.WriteLine(htbl["1"]);
        }
    }
}
