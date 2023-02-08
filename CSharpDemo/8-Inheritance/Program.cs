using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                FirstName="Sadhana",
                LastName="Karad"
            };

            e1.PrintFullName();

            Employee e2 = new FullTimeEmployee()
            {
                FirstName = "Sadhana",
                LastName = "Karad"
            };

            e2.PrintFullName();

            //FullTimeEmployee fte1 = new FullTimeEmployee()
            //{
            //    FirstName = "Arihant",
            //    LastName = "Phad",
            //    YearlySalary = 100000

            //};

            //fte1.PrintFullName();

            //PartTimeEmployee pte1 = new PartTimeEmployee()
            //{
            //    FirstName = "Akshay",
            //    LastName = "Somvanshi"
            //};
            //pte1.PrintFullName();

            Console.ReadLine();
        }

        // Parent Class or base class
        class Employee
        {
            public int Id;
            public string FirstName;
            public string LastName;

            public void PrintFullName()
            {
                Console.WriteLine("FullName = {0} {1} ", FirstName, LastName);
            }

        }

        //Child Class or Derived Class
        class FullTimeEmployee : Employee
        {
            public int YearlySalary;

            public void PrintFullName()
            {
                Console.WriteLine("FullName = {0} {1} - FullTime", FirstName, LastName);
            }
        }

        class PartTimeEmployee : Employee
        {
            public int HourlyWages;          
        }
    }
}
