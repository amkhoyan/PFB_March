using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // ints

            //int myInt1;
            //myInt1 = 0;

            //int myInt2 = 12;

            //Console.WriteLine($"myInt2:{myInt2}");
            //myInt2 = 369;
            //Console.WriteLine($"myInt2:{myInt2}");

            //// foating point
            //double myDouble = 87.9;
            //Console.WriteLine(myDouble);
            //myDouble = 56397.78;
            //Console.WriteLine(myDouble);


            //// strings and chars
            //string myString = "Hello\nworld!";
            //Console.WriteLine(myString);
            //myString = "nworld!";
            //Console.WriteLine(myString);
            
            //char myChar = 'o';
            //Console.WriteLine();

            // string concatenation
            //Console.Write("Surname:");
            //string surname = Console.ReadLine();
            //int money = 10000;
            //Console.Write("Currency:");
            //string currency = Console.ReadLine();

            //string letter = $"Dear Mr./Mrs. {surname} we will be happy to take your {money} {currency}"+
            //                                                " and give you some meaningless papers";
            //Console.WriteLine(letter);
            //Console.WriteLine();


            // boolean
            bool myBool = false;
            Console.WriteLine(myBool);

            // constants
            const int myInt3 = 12;
            const double mydouble3 = 12.6;
            const string myString3 = "Some text";
            const bool myBool2 = false;


            // strong type
            int myInt4 = 54;
            // myInt4 = "Hello"; Error!


            // conversions
            int t1 = 15;
            double d1 = t1;

            double d2 = 12.6;
            int t2 = (int)d2;
            Console.WriteLine(t2);

            string num = "165";

            int t3 = int.Parse(num);
            t3 = t3 + 1;

            double d3 = double.Parse("1638.654");

            // var
            var myT1 = "test";
            var myT2 = 159;
            var myT3 = false;

            // input/output
            Console.Write("mi ban gri ");
            string input = Console.ReadLine();
            int intInput = int.Parse(input);
            //int intInput = Convert.ToInt32(input); //alternative
            intInput = intInput + 5;
            Console.WriteLine(intInput);

            Console.ReadLine();
        }
    }
}
