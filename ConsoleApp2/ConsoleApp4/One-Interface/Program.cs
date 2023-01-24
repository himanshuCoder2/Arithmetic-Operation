using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Interface
{
   interface inter1
    {
        void display();
    }
    class A :inter1
    {
        public void display()
        {
            Console.WriteLine("inter1 Interafce-class-A!!!!!!!");
        }
    }
    class B : inter1
    {
      public void display()
        {
            Console.WriteLine("inter1 Interafce-class-B!!!!!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.display();
            B obj2 = new B();
            obj2.display();
        }
    }
}
