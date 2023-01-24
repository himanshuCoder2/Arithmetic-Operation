using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum, sub, mul;
            float div;
            Console.WriteLine("enter 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            sub = a + b;
            mul = a + b;
            div = (float)a / b;
            Console.WriteLine("Addition:" + sum);
            Console.WriteLine("Subtraction:" + sub);
            Console.WriteLine("Multiplication:" + mul);
            Console.WriteLine("Division:" + div);
            Console.ReadKey();
        }
    }
}
