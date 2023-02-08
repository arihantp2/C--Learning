using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10, 20, 30);
            Console.ReadLine();
        }

        static void Add(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        static void Add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

    }
}
