using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public delegate bool PromoteDelegate(Employee emp);
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
    }

    public class Company
    {
        Employee[] employees;

        public Company(Employee[] emps) // Company Constructor
        {
            employees = emps;
        }

        public void PromoteEmployees(PromoteDelegate del)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                //if(employees[i].Experience > 2)
                //{
                //    Console.WriteLine("{0} is promoted",employees[i].Name);
                //}

                if (del(employees[i]))
                {
                    Console.WriteLine("{0} is promoted", employees[i].Name);
                }
            }
        }
    }
}
