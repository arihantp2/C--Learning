﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractParent
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    
    public abstract class AbstractParent
    {
        public void Add(int x,int y)
        {
            Console.WriteLine(x + y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public abstract void Mul(int x, int y);

        public abstract void Div(int x, int y);

    }
}
