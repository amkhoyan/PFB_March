using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR

            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine($"{i} Hello");
            //}

            //for (; ;)
            //{
            //    Console.WriteLine($"Hello");
            //}

            // break and continue

            //for (int i = 1; i <= 25; i++)
            //{
            //    if (i==10||i==15)
            //    {
            //        continue;
            //    }
            //    else if(i==22)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            // with continue
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Jazz & Rock");
            //        continue;
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Rock");
            //        continue;
            //    }
            //    else if (i % 3 == 0 )
            //    {
            //        Console.WriteLine("Jazz ");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            //without continue
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine("Jazz & Rock");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Rock");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Jazz ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum = sum + i;
            //    sum += i;
            //}

            // WHILE

            int i = 0;
            while (i<12)
            {
                Console.WriteLine("hello");
                i++;
            }

            // DO WHILE
            do
            {

            } while (i>8);
            
            Console.ReadLine();
        }
    }
}
