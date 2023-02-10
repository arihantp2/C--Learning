using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            //C.Add(10, 10);

            Console.WriteLine("Please Enter first number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter second number");
            int n2 = int.Parse(Console.ReadLine());

            C.Add(n1, n2);

            Console.ReadLine();
        }
    }

    public class Customer
    {
        protected int id;

        void print()
        {
            Console.WriteLine(id);
        }

    }

    public class SilverCustomer : Customer
    {
       void PrintS()
        {
            Console.WriteLine(id);
        }
    }
}
