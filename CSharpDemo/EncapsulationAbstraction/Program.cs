using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Arihant", "Phad");
            if (c1.ValidateCustomerData())
            {
                c1.InsertCustomerToDb();
            }
            Console.ReadLine();
        }
    }

    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string fn, string ln)
        {
             _firstName = fn;
            _lastName = ln;
        }
        

        public bool ValidateCustomerData()
        {
            //logic to validate customer details
            return true;
        }

        public void InsertCustomerToDb()
        {
            if (ValidateCustomerData())
            {
                // code to insert customer details into the database
                Console.WriteLine("Customer Data Inserted to DataBase...");
            }
            else
            {
                Console.WriteLine("Error in saving Customer Data to DataBase");
            }
            
        }
    }

    

}
