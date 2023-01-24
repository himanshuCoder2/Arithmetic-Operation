using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_String_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Book = new string[5];
            Book[0] = "C";
            Book[1] = "C++";
            Book[2] = "C#";
            Book[3] = "Java";
            Book[4] = "Python";
            Console.WriteLine("All the elements of book array is:\n\n");
            int i = 0;
            Console.WriteLine("\t0\t1\t2\t3\t4\t5\n\n");
            for(i=0; i<5; i++)
            {
                Console.Write( "{0}\t", Book[i] +"");
            }
            Console.WriteLine();
        }
    }
}
