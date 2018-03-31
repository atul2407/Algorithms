using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class TestEquals
    {
        public static void TestEqls()
        {
            // == checks the reference equality.
            // Equals checks the string value equality.
            object name = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            object myName = new string(values);

            Console.WriteLine("hashcode of name is {0} and hashcode of myName is {1}", name.GetHashCode(), myName.GetHashCode());
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));


            object obj1 = new object();
            object obj2 = new object();
            Console.WriteLine("hashcode of obj1 is {0} and hashcode of obj2 is {1}", obj1.GetHashCode(), obj2.GetHashCode());
            Console.WriteLine("== operator result on object is {0}", obj1 == obj2);
            Console.WriteLine("Equals method result on object is {0}", obj1.Equals(obj2));


            string a = "Test";
            string b = "Test";

            TestClass t1 = new TestClass();
            TestClass t2 = new TestClass();
            //t1 = t2;


            Console.WriteLine((a == b));
            Console.WriteLine((t1 == t2));
            Console.WriteLine((a.Equals(b)));
            Console.WriteLine((t1.Equals(t2)));

            t1 = t2;
            Console.WriteLine((t1 == t2));
            Console.WriteLine((t1.Equals(t2)));



        }

        class TestClass
        { 
            
        }
    }
}
