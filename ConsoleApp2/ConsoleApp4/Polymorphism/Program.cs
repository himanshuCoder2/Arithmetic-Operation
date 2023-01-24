using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class parent
    {
        public virtual void cry()              //virtual it defines the virtual method 
        {
            Console.WriteLine("parent doesn't cry");
        }
    }
    class child1 : parent
    {
        public override void cry()
        {
            Console.WriteLine("child1 is crying low volume");
        }
    }
    class child2 : parent
    {
        public override void cry()
        {
            Console.WriteLine("child2 is crying medium volume");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p = new child1();             //  Upcasting
            p.cry();
            p = new child2();
            p.cry();
        }
    }
}
