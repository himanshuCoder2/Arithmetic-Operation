using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringvalue = new string[8];
            stringvalue[0] = "C";
            stringvalue[1] = "C++";
            stringvalue[2] = "C#";
            stringvalue[3] = "HTML";
            stringvalue[4] = "CSS";
            stringvalue[5] = "JAVA";
            stringvalue[6] = "PYTHON";
            stringvalue[7] = "JAVA-SCRIPT";
            for(int i=0;i<stringvalue.Length;i++)
            {
                Console.Write(" " + stringvalue [i]);
            }
            Console.ReadLine();
        }
    }
}
