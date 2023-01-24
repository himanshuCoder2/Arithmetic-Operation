using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 3;
            switch(input)
            {
                case 1:
                    Console.WriteLine("input for case1 is :" + input);
                    break;
                case 2:
                    Console.WriteLine("input for case2 is :" + input);
                    break;
                default:
                    Console.WriteLine("no match case");
                    break;
                    
            }
        }
    }
}
