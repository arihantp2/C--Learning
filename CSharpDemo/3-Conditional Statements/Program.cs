using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            //<----------------------  if - else ---------------------->

            Console.WriteLine("Please Enter a Number");

            int i = int.Parse(Console.ReadLine());
            //int i = 10;

            //bool b1 = i == 10; 

            //if (i == 10)
            //{
            //    Console.WriteLine("TEN");
            //}
            //else
            //{
            //    Console.WriteLine("NOT TEN");
            //}

            //<------------------ if ladder ----------------------->

            //if (i == 10)
            //{
            //    Console.WriteLine("TEN");
            //}
            //if (i == 20)
            //{
            //    Console.WriteLine("TWENTY");
            //}
            //if (i == 30)
            //{
            //    Console.WriteLine("THIRTY");
            //}

            //<------------------ if - else if - else ----------------------->

            //if (i == 10)
            //{
            //    Console.WriteLine("TEN");
            //}
            //else if (i == 20)
            //{
            //    Console.WriteLine("TWENTY");
            //}
            //else if (i == 30)
            //{
            //    Console.WriteLine("THIRTY");
            //}
            //else 
            //{
            //    Console.WriteLine("NOT 10 20 or 30");
            //}


            // <------------------------------ Ternary ---------------------------------->

            //string result= (i == 10) ? "TEN" : "NOT TEN";
            // Console.WriteLine(result);

            #region switch
            // <------------------------------ Switch ---------------------------------->
            //switch (i)
            //{
            //    case 10:
            //        Console.WriteLine("TEN");
            //        break;
            //    case 20:
            //        Console.WriteLine("Twenty");
            //        break;
            //    case 30:
            //        Console.WriteLine("Thirty");
            //        break;
            //    default:
            //        Console.WriteLine("Not 10 20 or 30");
            //        break;
            //}

            #endregion

       ///
       /// <summary></summary>
       /// 
            Console.ReadLine();
        }
    }
}
