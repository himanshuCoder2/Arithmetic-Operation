using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5) 
                {
                    Console.WriteLine(i+" "+j);
                }
                i++;
            } 
        }
    }
}
