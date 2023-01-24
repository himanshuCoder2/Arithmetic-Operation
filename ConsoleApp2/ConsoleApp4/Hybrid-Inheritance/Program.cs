using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid_Inheritance
{
    class GrandFather
    {
        public void land()
        {
            Console.WriteLine("GrandFather's land");
        }

    }
        class Father : GrandFather
        {
            public void home()
            {
                Console.WriteLine("Father's home");

            }
            public void car()
            {
                Console.WriteLine("Father's car");

            }
        }
        class Son : Father   //son constructor
        {
          public Son()
            {
                Console.WriteLine("Son...");
            }
            public void moblie()
            {
                Console.WriteLine("Son's moblie");
            }
        }
        class Daughter : Father
        {
            public Daughter()
            {
                Console.WriteLine("Daughter");
            }
            public void purse()
            {
                Console.WriteLine("Daughter's purse");
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HYBRID INHERITANCE USING TWO INHERITANCE MULTILEVEL & HIERARCHICAL INHERITANCE");
            Console.WriteLine("--------------------------------------------------------------------");
            //Son object
            Son s = new Son();
            s.land();
            s.home();
            s.car();
            s.moblie();
            Daughter d = new Daughter();
            d.land();
            d.home();
            d.car();
            d.purse();
        }
    }
}
