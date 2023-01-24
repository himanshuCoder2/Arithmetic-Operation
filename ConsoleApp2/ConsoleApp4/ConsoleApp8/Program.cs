using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
         public static  int add(int x,int y )
        {
            return x + y;
        }
         public static double add(double x, double y)
        {
            return x + y;  
        }
        static void Main (string[]args)
        {
            int myNum1 = add(8, 5);
            double myNum2 = add(4, 6.26);
            Console.WriteLine("Int:" + myNum1);
            Console.WriteLine("Double:" + myNum2);
        }



    }
}
