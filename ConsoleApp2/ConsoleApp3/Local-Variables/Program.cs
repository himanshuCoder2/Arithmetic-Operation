using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Variables
{
    class CustomerEntry
    {
        public void GetAge()
        {
            int customer_age = 0;  //local variable
            customer_age = customer_age + 28;
            Console.WriteLine("Customer Age:" + customer_age);
        }
        public  static void Main(string[] args)
        {
            CustomerEntry _customerObj = new CustomerEntry();
            _customerObj.GetAge();
        }
    }
}
