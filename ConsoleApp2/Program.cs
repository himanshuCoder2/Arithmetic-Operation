using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter 1st number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("addition:" + c);


        }
    }
}
