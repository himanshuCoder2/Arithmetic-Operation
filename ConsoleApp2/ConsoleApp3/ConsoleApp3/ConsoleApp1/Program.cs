﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[3] = 20;
            arr[4] = 30;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array" + "" + arr[i]);
            }
        }
    }
}
