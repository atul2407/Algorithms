using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    partial class PartialFunction
    {
        //Partial methods are indicated by the partial modifier.
        //Partial methods must be private.
        //Partial methods must return void.
        //Partial methods must only be declared within partial classes.
        //Partial methods do not always have an implementation. 
        //Partial methods can be static and generic.
        //Partial methods can have arguments including ref but not out. 
        //You cannot make a delegate to a partial method.
        int a = 10;
        partial void Test();
        //{
        //    //Console.WriteLine(a);
        //}
    }

    partial class PartialFunction
    {
        partial void Test()
        {
            Console.WriteLine(a++);
        }
    }
}
