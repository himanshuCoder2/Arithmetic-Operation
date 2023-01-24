using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public void GetAge()
        {
            int customer_age = 0; //local variable
            customer_age = customer_age + 28;
            Console.WriteLine("Customer_age:" + customer_age);
        }
        static void Main(string[] args)
        {
            Program customerObj = new Program();
            customerObj.GetAge();
        }
    }
}
