using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];//Declaration of 2d Array
            arr[0, 0] = 1;    //Initialization
            arr[1, 1] = 1;
            arr[2, 2] = 1;
            for(int i=0;i<3;i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
