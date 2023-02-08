using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array Simple Program
            //Console.WriteLine("Arrays Simple Program");

            ////int i = 10;
            //int[] numbers = new int[2];

            //numbers[0] = 10;
            //numbers[1] = 20;


            //Console.WriteLine(numbers.Length);

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);

            //int[] numbers1 = new int[] { 10, 20, 30 };
            #endregion Array Simple Program


            #region sample while loop

            //<-------------------------- Using While Loop -------------------------------->
            //int start = 1;

            //while (start <= 10)
            //{
            //    Console.WriteLine(start);
            //    start = start + 1;
            //}

            #endregion sample while loop

            #region Do while Loop Sample

            //int start = 1;

            //do
            //{
            //    Console.WriteLine(start);
            //    start++;

            //} while (start <= 10);

            #endregion Do while Loop Sample

            #region for loop

            //for (int start=1;start<=10;start++)
            //{
            //    Console.WriteLine(start);
            //}

            #endregion for loop

            #region for loop with break
            //for (int start = 1; start <= 10; start++)
            //{
            //    if (start==5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(start);
            //}
            #endregion for loop with break

            #region for loop with continue
            //for (int start = 1; start <= 10; start++)
            //{
            //   // Console.WriteLine(start);
            //    if (start == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(start);

            //}


            #endregion for loop with continue

            #region for loop with patterns
            //for (int i = 1; i<=5;i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(j + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //<-------------------------------------------------------------------------->
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //<-------------------------------------------------------------------------->
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        break;
            //        Console.Write("*" + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //<--------------------------------------------------------------------------------->



            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (j==2)
            //        {
            //            break;
            //        }

            //        Console.Write("*" + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion for loop with patterns

            #region coffee size assignment

            string choice = "";
            int totalBillAmount = 0;

            do {
                Console.WriteLine("Please Enter Coffee Size");
                Console.WriteLine("1-Large 2-Medium 3-Small");

                int input;

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Large");
                            totalBillAmount += 30;
                            break;
                        case 2:
                            Console.WriteLine("Medium");
                            totalBillAmount += 20;
                            break;
                        case 3:
                            Console.WriteLine("Small");
                            totalBillAmount += 10;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Coffee Size");
                }

                Console.WriteLine("Do you want to Continue?");
                choice = Console.ReadLine();

            } while(choice.ToUpper() == "YES" || choice.ToUpper() == "Y");


            Console.WriteLine("Thank you for visiting us.....!");
            Console.WriteLine("Your Total Bill Amount is : {0}",totalBillAmount);

            #endregion coffee size assignment
            Console.ReadLine();

        }
    }
}
