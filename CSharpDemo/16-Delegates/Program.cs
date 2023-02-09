using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Delegates
{
    class Program
    {
        // 1 - Declaring Delegate
        delegate void PrintDelegate();
        
        static void Main(string[] args)
        {
            // Creating instance of delegate
            // PrintDelegate pd = new PrintDelegate(Print);
            PrintDelegate del = PrintA;
            //PrintDelegate del2 = PrintB;
            //PrintDelegate del3 = PrintC;

             del += PrintB;
            del += PrintC;

            //PrintDelegate del = del1 + del2 + del3 - del2;
            // Invoking delegate
            //pd();
            del();
            Console.ReadLine();
        }

        // Method to call using Delegate
        //static void Print()
        //{
        //    Console.WriteLine("Print Method");

        //}

        static void PrintA()
        {
            Console.WriteLine("A");
        }
        static void PrintB()
        {
            Console.WriteLine("B");
        }
        static void PrintC()
        {
            Console.WriteLine("C");
        }
    }
}
