using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 5;
            int x, y;
            try
            {
                x = a / (b - c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Divison by zero");
            }
            y = a / (b + c);
            Console.WriteLine("y=" + y);
        }
    }
}
