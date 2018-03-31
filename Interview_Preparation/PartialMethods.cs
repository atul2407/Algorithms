using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    partial class A
    {
        partial void OnSomethingHappened(string s);
        //{
        //    Console.WriteLine("Something happened - first : {0}", s);
        //}
    }

    // This part can be in a separate file.
    partial class A
    {
        // Comment out this method and the program
        // will still compile.
        partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }

        public void TestPartialMethod()
        {
            this.OnSomethingHappened("test");
        }
    }
}
