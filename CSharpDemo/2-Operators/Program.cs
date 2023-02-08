using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //string companyName1 = "InfoBeans Technologies Ltd";
            //string companyName2 = "\"InfoBeans Technologies Ltd\"";
            //string companyName3 = "'InfoBeans Technologies Ltd'";

            //String EName = "\\ Arihant \\";

            //string companyName4 = "InfoBeans \n Technologies \n Ltd";

            //Console.WriteLine(companyName1);
            //Console.WriteLine(companyName2);
            //Console.WriteLine(companyName3);
            //Console.WriteLine(companyName4);

            //Console.WriteLine(EName);


            string fname = "Arihant";
            string lname = "Phad";

            Console.WriteLine(fname + " " +lname);  // General method to print full name

            Console.WriteLine("Fullname : {0} {1}", fname, lname); // with placeholder



            //Console.WriteLine("Write your first name ");
            //string first = Console.ReadLine();

            //Console.WriteLine("Write your last name");
            //string last = Console.ReadLine();

            //Console.WriteLine("Full Name is : {0} {1}", first, last);

            //Two no addition

            Console.WriteLine("Please Enter a Number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter a second number");
            int b = Convert.ToInt32(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;

            Console.WriteLine("Addition       :" + add);
            Console.WriteLine("Subtraction    :" + sub);
            Console.WriteLine("Multiplication :" + mul);
            Console.WriteLine("Division       :" + div);

            

            //string input = Console.ReadLine();
            //int n1;
            //bool isConversionSuccessfull= int.TryParse(input, out n1);

            //Console.WriteLine(isConversionSuccessfull);
            //Console.WriteLine(n1);

            Console.ReadLine();
        }
    }
}
