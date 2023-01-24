using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void MyMethod()
        {
            //block of code will executed
            Console.WriteLine("Hello,How are you..");
        }
        static void Main(string[]args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }
    }
}
