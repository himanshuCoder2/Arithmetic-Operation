using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double phy, che, math, total, rl;
            double per;
            String name, div;
            Console.WriteLine("calculate the total, percentage and divison of three subjects:");
            Console.WriteLine("...............");
            Console.WriteLine("enter the roll no of students ");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name of student :");
            name = Console.ReadLine();

            Console.WriteLine("enter the marks of phy");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of  chemistry");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of math");
            math = Convert.ToInt32(Console.ReadLine());

            total = phy + math + che;
            per = total / 3.0;

            if (per >= 60)
                div = "first";
            else
                if (per < 60 && per >= 48)
                div = "second";
            else
                if (per < 48 && per >= 36)
                div = "pass";
            else
                div = "fail";

            Console.Write("Roll No:{0}\n Name Of Student :{1}\n:", rl, name);
            Console.Write("Marks in Physics:{0}\n Marks in Chemistry:{1}\nMarks in Math:{2}\n", phy, che, math);
            Console.Write("Total marks={0}\npercentage={1}\nDivison={2}\n", total, per, div);


        }
    }
}
