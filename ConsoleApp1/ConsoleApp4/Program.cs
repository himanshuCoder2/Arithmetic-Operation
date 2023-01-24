using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            Object obj = num;
            int i = (int)obj;

            Console.WriteLine("Value of ob object is:" + obj);
            Console.WriteLine("Value of i is:" + num);

        }
    }
}
