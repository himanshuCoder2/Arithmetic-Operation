using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Object
{
    class Bikes
    {
        String name = "Suzuki";
        String parts = "Frontcase";
        String color = "Red";
        static void Main(string[] args)
        {
            Bikes obj = new Bikes();
            Bikes obj1 = new Bikes();
            Bikes obj2 = new Bikes();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj1.parts);
            Console.WriteLine(obj2.color);
        }
    }
}
