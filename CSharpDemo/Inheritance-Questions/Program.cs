using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //B b1 = new B();
            //b1.Print();

            //A a1 = new A();
            //a1.Print();

            //A ab1 = new B();
            //ab1.Print();

            //B ba1 = new A();
            //ba1.Print();

           // A a1 = new A();
            B b1 = new B("Sample");
            Console.ReadLine();
        }
    }
    class A
    {
        //public void Print()
        //{
        //    Console.WriteLine("Class A Print Method");
        //}

        //public void PrintA()
        //{
        //    Console.WriteLine("Class A Print A Method");
        //}

        //public A()
        //{
        //    Console.WriteLine("Class A Constructor");
        //}

        public A(string name)
        {
            Console.WriteLine("Class A Paramterized Constructor");
        }

        public A(string name,string gender)
        {
            Console.WriteLine("Class A Paramterized Constructor version 1");
        }
    }
    class B:A
    {
        //public new void Print()
        //{
        //   // PrintA();
        //    //base.Print();
        //    base.PrintA();
        //    //Console.WriteLine("B");
        //}

        //public void PrintA()
        //{
        //    Console.WriteLine("Class B Print A Method");
        //}


        public B() : base("Sample")
        {
            Console.WriteLine("Class B Constructor");
        }

        //public B(string name) : base(name)
        //{
        //    Console.WriteLine("Class B Paramterized Constructor");
        //}

        public B(string name) : base(name,"Male")
        {
            Console.WriteLine("Class B Paramterized Constructor");
        }
    }
}
