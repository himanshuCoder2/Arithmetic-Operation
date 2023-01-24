using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       public static void Main(string[] args)
        {
            int a;
            int b;
            int sum, sub, mul;
            float div;
            Console.WriteLine("enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = (float)a / b;
            Console.WriteLine("addition:" + sum);
            Console.WriteLine("subtraction:" + sub);
            Console.WriteLine("multiplication:" + mul);
            Console.WriteLine("division:" + div);
            Console.ReadLine();

        }
    }
}
