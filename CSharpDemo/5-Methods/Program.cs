using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Methods
{
    class Program
    {
        //calling mathod
        static void Main(string[] args)
        {

            //int[] numbers = new int[] {1,2,3,4,5 };

            //Add(numbers);

            Add(new int[] { 1, 2, 3, 4, 5 }); //WE CAN DIRECTLY PASS ARRAY

            Add(10, 20, 30, 40);
            Add();
            Add(null);
            //int n = 10;
            //changeValue(ref n);
            //Console.WriteLine(n);

            //Console.WriteLine("Please Enter First Name: ");
            //string fname = Console.ReadLine();

            //Console.WriteLine("Please Enter Last Name: ");
            //string lname = Console.ReadLine();

            //string input = "B0$$";
            //string s1= GetWelcomeText(fname,lname);
            //GetWelcomeText(fname, lname); //method arguments
            //Console.WriteLine(s1);

            Console.ReadLine();
        }

        //called method
        //static string GetWelcomeText(string name)
        //static string GetWelcomeText(string fn,string ln)


        //static void GetWelcomeText(string fn, string ln) //method paramters
        //{
        //    // return "Welcome, " + fn +" "+ ln;

        //    Console.WriteLine("Welcome, " + fn + " " + ln);
            
        //}

        //static void changeValue(ref int a)
        //{
        //    a = 100;
        //}
        
        static void Add(params int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine("Addition of numbers = {0}",sum);
            }
            else
            {
                Console.WriteLine("There are no elements in the array");
            }
        }
    }
}
