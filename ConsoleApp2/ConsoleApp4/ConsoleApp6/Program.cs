using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void paramsmethod(params int[]numbers)
        {
            Console.WriteLine("There are {0} element", numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[]args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            paramsmethod();
            paramsmethod(numbers);

        }
    }
}
