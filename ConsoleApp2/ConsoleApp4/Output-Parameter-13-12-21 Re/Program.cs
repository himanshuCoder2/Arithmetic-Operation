using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Parameter_13_12_21_Re
{
    class Program
    {
        static void calculate(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
        static void Main(string[] args)
        {
            int total = 0;
            int product = 0;
            calculate(39, 73, out total, out product);
            Console.WriteLine("sum={0} && product={1}", total, product);
            Console.WriteLine();
        }
    }
}
