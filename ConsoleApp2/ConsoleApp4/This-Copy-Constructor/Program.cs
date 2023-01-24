using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Copy_Constructor
{
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)//Declaring Copy Constructor
        {
            name = emp.name;
            age = emp.age;

        }
        public employee(string name, int age)//Instance Constructor
        {
            this.name = name;
            this.age = age;
        }
        public string Details
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }

        }
    }
    class empDetails
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee("Himanshu Bijwar", 18);
            employee emp2 = new employee(emp1);
            Console.WriteLine(emp2.Details);
          
        }
    }
}
