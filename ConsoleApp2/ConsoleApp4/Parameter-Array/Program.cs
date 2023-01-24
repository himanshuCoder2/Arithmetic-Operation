using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Array
{
    class Program
    {
       public static void paramsmethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} element", numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 141;
            numbers[1] = 241;
            numbers[2] = 341;
            paramsmethod();
            paramsmethod(numbers);
        }
    }
}
