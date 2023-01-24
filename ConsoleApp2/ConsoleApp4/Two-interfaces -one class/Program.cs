using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_interfaces__one_class
{
    interface inter1
    {
        //method declaration
        void mymethod();
    }
    interface inter2
    {
        //method declaration
        void mymethod();
    }
    //class A implement both
    //inter1 & inter2 interface
    class A : inter1 , inter2
    {
        //here method belongs to
        //inter1 interface
        void inter1.mymethod()
        {
            Console.WriteLine("first interface of class A");
        }
        //here method belong to 
        //G2 interface
        void inter2.mymethod()
        {
            Console.WriteLine("second interface of class A");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            inter1 obj = new A();    //creating object of class A of inter1 interface
            obj.mymethod();          //calling inter1 interface method
            inter2 obj2 = new A();   //creating object of class A of inter2 interface
            obj2.mymethod();         //calling inter2 interface method
        }
    }
}
