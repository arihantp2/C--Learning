using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //object o = new object();
            //o = i; // int -> obj == BOXING
            //Console.WriteLine(o);

            //int j = (int)o; // obj -> int == UNBOXING
            //Console.WriteLine(j);

            //float f = 10f;
            //int i1 = (int)f; //neither boxing nor unboxing because both are value types

            //Console.ReadLine();


            //Student s1 = new Student(); //object or instance of the class
            //s1.RollNo = 1;
            //s1.FirstName = "Arihant";
            //s1.LastName = "Phad";

            //s1.PrintFullName();

            //Student s2 = new Student() //array initializer type syntax
            //{
            //    RollNo = 1,
            //    FirstName = "Akshay",
            //    LastName="Somvanshi"
            //};

            //s2.PrintFullName();

            Student s3 = new Student("Sadhana","Karad");  //for parameterized constructor
            s3.PrintFullName();

            Student s4 = new Student(s3);  //for copy constructor
            s3.PrintFullName();


            //Console.WriteLine(s3.RollNo);
            Console.ReadLine();
        }

        public class Student
        {
            public int RollNo;
            public string FirstName;
            public string LastName;

            //all these theree are fields

            //default constructor
            //public Student()
            //{
            //    RollNo = 10;
            //    FirstName = "Shivani";
            //   LastName = "Ausarkar";
            //}

            //parameterized Constructor
            public Student(string fn, string ln)
            {
                RollNo =3;
                FirstName = fn;
                LastName = ln;

            }

            //copy constructor
            public Student(Student s)
            {
                RollNo = s.RollNo;
                FirstName = s.FirstName;
                LastName = s.LastName;
            }

            //below is method to print full name

            public void PrintFullName()
            {
                Console.WriteLine("Fullname = {0} {1}",FirstName,LastName);
            }
        }
    }
}
