using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int day = 6;
            switch(day)
            {
                case 1:
                    Console.WriteLine("case 1 is :monday");
                    break;
                case 2:
                    Console.WriteLine("case 2 is :tuesday");
                    break;
                case 3:
                    Console.WriteLine("case 3 is :wednesday");
                    break;
                case 4:
                    Console.WriteLine("case 4 is :thursday");
                    break;
                case 5:
                    Console.WriteLine("case 5 is :friday");
                    break;
                default:
                    Console.WriteLine("no match case found");
                    break;

            }
        }
    }
}
