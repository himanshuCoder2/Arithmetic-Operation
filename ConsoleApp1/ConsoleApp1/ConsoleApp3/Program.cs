using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       public static void Main(string[] args)
        {
            int p;
            int r;
            int t;
            int SI;
            Console.WriteLine("enter principal");

            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate");

            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter time");

            t = Convert.ToInt32(Console.ReadLine());
            SI = p * r * t;
            Console.WriteLine("SI=" + SI);
            Console.Read();
        }
    }
}
