using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int , int> d = delegate(int a,int b)
            {
                return a + b;
            };

            int res = d(10,10);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
