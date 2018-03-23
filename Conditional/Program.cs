using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////// IF
            //  int x = 10;

            //   if (x>0&x<=10)
            //    {
            //        Console.WriteLine("1-10");\
            //    }
            //   else if (x>10&&x<=100)
            //   {
            //       Console.WriteLine("10-100");
            //   }
            //   else
            //   {
            //      Console.WriteLine("Fail");
            //   }


            // Qarakusajin Havasaraum

            //double a, b, c;
            //Console.Write("nermucel a tivy: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("nermucel b tivy: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("nermucel c tivy: ");
            //c = double.Parse(Console.ReadLine());

            //double d = Math.Pow(b, 2) - 4 * a * c;
            //if (d > 0) {
            //    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //    Console.WriteLine($"x1: {x1}, x2: {x2}");
            //}
            //else if (d == 0) {
            //    double x3 = -b / 2 * a;
            //    Console.WriteLine($"x: {x3}");
            //}
            //else {
            //    Console.WriteLine("lucum chka");
            //}
            //Console.ReadLine();

            // Zuyg te kent

            int a, b, c;
            for (int i = 0; i > -1; i++) { 
            a = int.Parse(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("zuyg");
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("kent");
            }
            else if (a == 0)
            {
                Console.WriteLine("00000");
            }
            }
            Console.Read();

            ///////// SWITCH

            DayOfWeek day = DateTimeOffset.Now.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Code Works Here!!!!!");
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
            

            string str = "Hello";

            switch (str)
            {
                case "Helloo":
                    Console.WriteLine("two os");
                    
                    break;
                case "NOO":
                    Console.WriteLine("no");
                    break;

                default:
                    Console.WriteLine("This is text from default");
                    break;
            }
        }
    }
}
