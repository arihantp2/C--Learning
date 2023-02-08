using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_StaticKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a1 = new A();
            //A a2 = new A();
            //A a3 = new A();
            //A.Print();
            //Console.WriteLine(A.Id);


            Student.Print(); //Static Method calling

            Student s1 = new Student();
            s1.PrintA(); //non static method calling
            Console.ReadLine();
        }

        //public class A
        //{
        //    public static string message = "Message from class A";
            
        //    public A() //static constructors are by default public
        //    {
        //        Console.WriteLine("Public Constructor Called");

        //    }
        //    static A() //static constructors are by default public
        //    {
        //        Console.WriteLine("Static Constructor Called");

        //    }
           
        //}

        //static class

        //public static class A
        //{
        //    public static int Id=10;

        //    public static void Print()
        //    {
        //        Console.WriteLine("Arihant");
        //    }
        //}

        public class Student
        {
            public Student() { }
            public static void Print()
            {
                Console.WriteLine("Print Method");
            }
            public void PrintA()
            {
                Console.WriteLine("Print A Method");
            }
        }

    }
}
