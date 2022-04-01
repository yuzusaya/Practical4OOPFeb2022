using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public class ClassA
    {
        public virtual void PrintMethod()
        {
            Console.WriteLine("Print from Class A");
        }

        public void SecondPrintMethod()
        {
            Console.WriteLine("Second print from Class A");
        }

        //method overloading with optional parameter
        public void PrintMethod(string name,int id=0)
        {

        }
    }

    public class ClassB : ClassA
    {
        //overriding
        public override void PrintMethod()
        {
            Console.WriteLine("Print from Class B");
        }

        //shadowing
        public new void SecondPrintMethod()
        {
            Console.WriteLine("Second Print from Class B");
        }
    }

}
