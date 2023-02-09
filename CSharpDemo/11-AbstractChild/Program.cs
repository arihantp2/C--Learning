using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11_AbstractParent;


namespace _11_AbstractChild
{
    class AbstractChild : AbstractParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main(string[] args)
        {
            AbstractChild abs = new AbstractChild();
            abs.Add(10, 10);
            abs.Mul(4, 4);
            abs.Sub(7, 5);
            abs.Div(10, 5);

            Console.ReadLine();
        }

        
    }
}
