using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Excersises1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 2 մնացորդ։
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i= 1; i <= 999; i++)
            //{
            //    if (i % n == 3) { 
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();


            //Տպել ամենափոքր քառանիշ թիվը, որը 26-ով բազմապատկելիս դառնում է բնական թվի քառակուսի։


            //int n;
            //for (int i = 1000; i < 10000; i++)
            //{
            //    n = i * 26;
            //    if (Math.Sqrt(n)%1==0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }


            //  *                *
            //  **              **
            //  ***            ***
            //  ****          ****
            //  *****        *****
            //  ******      ******

            //  ****
            //  *  *
            //  *  *
            //  ****

            // N>1, 3^K>N



            //Console.Write("Input A = ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= a; i++)
            //{
            //    for (int n = 0; n < i; n++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();



            //int n;
            //Console.Write("n=");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 0; ; i++)
            //{
            //    if (n < Math.Pow(i , 3))
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //}

            //Console.ReadLine();

            //int avand = 30000;
            //int n;
            //for (int i = 1; i > 0; i++) 
            //{
            //    n = avand * 10 / 100;
            //    avand = avand + n;
            //    if (avand >= 100000)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //}
            //Console.Read();


            double b,p;

            Console.WriteLine("a=");
            p = int.Parse(Console.ReadLine());
            b = (1 + p / 100);
            for (int i = 0; ; i++)
            {
                double sam = 30000 * Math.Pow(b, i);
                if(sam>100000)
                {
                    Console.WriteLine(i);
                    break;
                }
              
            

            }
            Console.ReadLine();
        }
    }
}
