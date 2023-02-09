using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Enum.GetNames(typeof(Gender));

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //int[] values =(int[]) Enum.GetValues(typeof(Gender));

            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine(values[i]);
            //}

            //to get type of enum vairbales
            //Type t= Enum.GetUnderlyingType(typeof(Gender));
            //Console.WriteLine(t.Name);

            //Student s1 = new Student()
            //{
            //    RollNo = 1,
            //    StudentName = "Arihant",
            //    //Gender = 1
            //    Gender = Gender.Male // For Enum type
            //};
            //Console.WriteLine("Roll Number = {0} Name = {1} Gender = {2} ",
            //    //s1.RollNo,s1.StudentName, GetGender(s1.Gender));
            //    s1.RollNo, s1.StudentName, s1.Gender);
            Console.ReadLine();
        }

        static string GetGender(int g)  //method to assign gender to numbers
        {
            switch (g)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "UnKnown";
            }
        }
    }

    // Male -- 1
    // Female -- 2
    class Student
    {
        public int RollNo { get; set; }

        public string StudentName { get; set; }

        /*public int Gender { get; set; }*/ // type of gender we take as int // Intergal Constant

        public Gender Gender { get; set; }
    }

    // defining enum for integral constant
    enum Gender // Customize Type
    {
       Male,
       Female,
       Unknown
    }
}
