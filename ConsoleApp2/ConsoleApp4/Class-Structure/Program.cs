using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Structure
{
    public struct student
    {
        public string Name;
        public int RollNo;
        public int Marks;
        public student(int RNO, string NOS, int MOS)
        {
            RollNo = RNO;
            Name = NOS;
            Marks = MOS;
        }
        public void display()
        {
            Console.WriteLine("Roll No of Student :-" +  RollNo);
            Console.WriteLine("Name of Student :-"  + Name);
            Console.WriteLine("Marks of Student :-"  + Marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s = new student(221, "Himanshu Bijwar", 80);
            s.display();
        }
    }

}

   
   
