using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Add
    {
        public int a, b;
        public int p, q, r;
        public Add(int x,int y)
        {
            a = x;
            b = y;
        }
        public Add(int x, int y,int z)
        {
            p = x;
            q = y;
            r = z;
        }
        public void display()
        {
            Console.WriteLine(" 1st Constructor (int + int): {0}", (a + b));
        }
        public void display1()
        {
            Console.WriteLine(" 2nd Constructor (int + int + int): {0}", (p + q + r));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Add a1 = new Add(20, 40);
            a1.display();
            Add a2 = new Add(30, 50, 70);
            a2.display1();
        }
    }
}
