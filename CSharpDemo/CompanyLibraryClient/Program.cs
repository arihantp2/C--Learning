using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyLibrary;

namespace CompanyLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[]
            {
                new Employee() {id= 1,Name="Arihant",Gender="Male",Experience=3 },
                new Employee() {id= 2,Name="Sadhana",Gender="Female",Experience=1 },
                new Employee() {id= 3,Name="Krushna",Gender="Male",Experience=2 },
                new Employee() {id= 4,Name="Akshay",Gender="Male",Experience=4 },

            };

            Company Infobeans = new Company(employees);

            // Infobeans.PromoteEmployees(); // before implementing delegates

            // PromoteDelegate del = PromoteLogic;

            // using anonymous method

            PromoteDelegate del = delegate (Employee emp)
            {

                return emp.Experience == 2 || emp.Experience == 3;
            };

            Infobeans.PromoteEmployees(del);

            Console.ReadLine();
        }

        static bool PromoteLogic(Employee emp)
        {
            // return emp.Gender.Equals("Female");
            //return emp.Name.StartsWith("K");
            return true; //for all results
        }
    }
}
