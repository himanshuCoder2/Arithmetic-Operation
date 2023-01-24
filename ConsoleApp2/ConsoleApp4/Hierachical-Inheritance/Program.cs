using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierachical_Inheritance
{
    class College
    {
        public string name;
        public int aadhar_id;
        public int age;

        public void Person(int aadhar_id,int age, string name)
        {
            this.aadhar_id = aadhar_id;
            this.name = name;
            this.age = age;
        }
    }
    class teaching : College
    {
        public int teacher_salary;
        public string name_ts;
        public int age_ts;

        public void display( int aadharid,int salary,string name, int age)
        {
            aadhar_id = aadharid;
            teacher_salary = salary;
            name_ts = name;
            age_ts = age;
        }
        public void TeacherDetails()
        {
            Console.WriteLine("teacher ID:  " + aadhar_id);
            Console.WriteLine("teacher Name:  " + name_ts);
            Console.WriteLine("teacher Salary:  " + teacher_salary);
            Console.WriteLine("teacher age:  " + age_ts);
        }
    }
    class nonteaching : College
    {
        public int nonteaching_salary;
        public string name_nts;
        public int age_nts;
         public void display2(int aadharid, int salary, string name, int age)
        {
            aadhar_id = aadharid;
            nonteaching_salary = salary;
            name_nts = name;
            age_nts = age;
        }
        public void NonTeachingDetails()
        {
            Console.WriteLine("non-teaching ID:  " + aadhar_id);
            Console.WriteLine("non-teaching Name:  " + name_nts);
            Console.WriteLine("non-teaching Salary:  " +nonteaching_salary);
            Console.WriteLine("non-teaching Age:  " + age_nts);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hierachical Inheritance ");
            Console.WriteLine("------------------------------------------- ");
            Console.WriteLine(" TEACHING AND NON-TEACHING INFORMATION ");
            Console.WriteLine("------------------------------------------- ");
            teaching t = new teaching();
            nonteaching nt = new nonteaching();
            t.display(101, 25000, "Himanshu",18);
            t.TeacherDetails();
            Console.WriteLine("------------------------------------------- ");
            nt.display2(502, 25000, "xyz", 35);
            nt.NonTeachingDetails();
        }
    }
}
