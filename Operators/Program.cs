using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //int myInt1 = 1 + 2;

            //int myInt2 = 11 % 2;
            //Console.WriteLine(myInt2);
            //double myD = 12.5 % 3.4;
            //Console.WriteLine(myD);

            //int myInt3 = myInt1--;
            //Console.WriteLine($"myInt1:{myInt1}, myInt3:{myInt3}");

            //int x = 1;
            //int result = ++x + x++;
            //Console.WriteLine(result);

            //int x1 = 2 << 1;
            //int x2 = 2 >> 1;
            //Console.WriteLine($"x1: {x1}, x2: {x2}");


            //int x3 = 10;
            //int x4 = 20;

            //bool res1 = x3 > x4;
            //bool res2 = x3 == x4;
            //bool res3 = x3 != x4;

            //bool res4 = !res2;

            //Console.WriteLine($"{res1}  {res2}  {res3} {res4}");

            //int x5 = -1;
            //int y5 = 3;

            //bool res5 = x5 > 1 & ++y5 > 17;
            //Console.WriteLine($"res5: {res5}, y5: {y5}");


            //string res6 = false ? "true" : "false";


            //string str = null;

            //string resString = str ?? "datark";
            //Console.WriteLine(resString);

            //int hac = int.Parse(Console.ReadLine());

            int breadDud = 120;
            int sugarDud = 450;
            int milkDud = 420;
            int breadCity = 100;
            int sugarCity = 350;
            int milkCity = 400;

            int Dud = breadDud + sugarDud + milkDud;
            int City = milkCity + sugarCity + breadCity;

            string cheap = Dud > City ? "City is cheaper" : "Dud is cheaper";
            Console.WriteLine(cheap);
            Console.ReadLine();



        }
    }
}
