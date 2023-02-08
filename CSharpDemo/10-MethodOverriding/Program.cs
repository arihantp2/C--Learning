using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 1;

            var number2 = number1;

            number2++;

            Console.WriteLine(number1);

            Console.ReadLine();
        }
    }
}
