using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_Constructor
{
    class Program
    {
        public int a;
        int b;
        int c;
        public Program(int x,int y,int z)
        {
            a = x;
            b = y;
            c = z;
         
        }
        static void Main(string[] args)
        {
            Program num = new Program(10, 20, 30);
            Console.WriteLine("value of a=" + num.a);
            Console.WriteLine("value of b=" + num.b);
            Console.WriteLine("value of c=" + num.c);
            Console.WriteLine();
        }
    }
}
