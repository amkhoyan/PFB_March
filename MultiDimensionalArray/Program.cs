using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr = new int[6, 6];

            //intArr[2, 2] = 11;

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int y = 0; y < 6; y++)
            //    {
            //        Console.Write($"{intArr[i, y]} ");
            //    }
            //    Console.WriteLine();
            //}


            //char[,] charArr =
            //    {
            //    {' ','*',' ',' ' },
            //    {' ','*',' ',' ' },
            //    {' ','*','*',' ' },
            //    {' ',' ','*',' ' },
            //    };



            //for (int i = 0; i < 4; i++)
            //{
            //    for (int y = 0; y < 4; y++)
            //    {
            //        Console.Write($"{charArr[i, y]} ");
            //    }
            //    Console.WriteLine();
            //}



            //int[][] jaggedArray = new int[3][];

            //jaggedArray[1] = new int[9];
            //jaggedArray[0] = new int[7];
            //jaggedArray[2] = new int[4];
            //jaggedArray[0][2] = 8;


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int y = 0; y < jaggedArray[i].Length; y++)
            //    {
            //        Console.Write(jaggedArray[i][y] + "\t");
            //    }
            //    Console.WriteLine();
            //}



            //int[,] array = new int[9, 9];
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int y= 0; y < 9; y++)
            //    {
            //        Console.Write((i+1) * (y+1) + "\t" );
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("nermucel m tivy: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, m];
            
            int count = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("nermucel k tivy: ");
            int k = int.Parse(Console.ReadLine());

            for (int y = 0; y < m; y++)
            {
                for (int r = 0; r < y; r++)
                {
                    if (arr[y, r] % k == 0) {
                        count++;
                    }
                }
            }
            Console.Write($"{count}");
            Console.ReadLine();
        }
    }
}
