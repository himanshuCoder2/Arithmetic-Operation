using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simptmatic_pogram8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int b = 16;
            int c = 64;
            x /= c /= b;
            Console.WriteLine(x + "" + b + "" + c);
            Console.ReadLine();
        }
    }
}
