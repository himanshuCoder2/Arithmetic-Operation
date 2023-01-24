using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_Variable_21_12_2021
{
    class StudentMarks
    {
        //instance variables
        int markMaths;
        int markPhysics;
         public static void Main(string[] args)
        {
            StudentMarks obj1 = new StudentMarks(); //object creation1
            obj1.markMaths = 89;
            obj1.markPhysics = 95;
            StudentMarks obj2 = new StudentMarks();
            obj2.markMaths = 90;
            obj2.markPhysics = 90;
            Console.WriteLine("Marks obtained from first object:");
            Console.WriteLine("obj1.markMaths");
            Console.WriteLine("obj1.markPhysics");
            Console.WriteLine("Marks obtained from Second object:");
            Console.WriteLine("obj2.markMaths");
            Console.WriteLine("obj2.markPhysics");
          
        }
    }
}
