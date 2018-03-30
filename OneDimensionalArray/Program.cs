using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArray1 = new string[8];
            //int[] intArray1 = new int[9];

            //strArray1[2] = "Hello World";
            //strArray1[5] = "John Smith";

            //for (int i = 0; i < strArray1.Length; i++)
            //{
            //    Console.WriteLine(strArray1[i]);
            //}
            //Console.WriteLine("/////////////////////");

            //strArray1[2] = "Changed Value";
            //strArray1[5] = "Smith Johnovich";

            //for (int i = 0; i < strArray1.Length; i++)
            //{
            //    Console.WriteLine(strArray1[i]);
            //}
            
            //string[] strArray2 = new string[] { "One", "Two", "Three", "Four" };

            //string[] strArray3 = { "Five", "Six" };


            int[] intArray = { 1, 2, 3, 6, 4, 6, 7, 9 };

            int count = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i]%2==1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


            Console.ReadLine();
        }
    }
}