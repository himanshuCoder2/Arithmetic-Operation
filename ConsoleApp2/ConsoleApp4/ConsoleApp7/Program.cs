using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void calculate(int FN,int SN,out int sub, out int division)
        {
            sub = FN - SN;
            division = FN / SN;
        }
        static void Main(string[] args) 
        {
            int total = 0;
            int division = 0;
            calculate(10, 20, out total, out division);
            Console.WriteLine("sub={0} && division={1}",total, division);
            Console.ReadLine();
        }
    }
}
