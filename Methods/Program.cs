using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());

            int[] intArr = new int[length];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }

//            int[] intArr = { 10, 11, 12, 14 };

            bool tr = PrintRange(intArr, 11);
            Console.WriteLine(tr);
            AddVoid(2, 5);
        }

        static bool PrintRange(int[] a, int k)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == k) {
                    return true;
                }
            }
            return false;
        }

        static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static void AddVoid(int x, int y)
        {
            if (x == 2)
            {
                return;
            }

            Console.WriteLine(x + y);
        }

        static int AddParameterless()
        {
            return 7;
        }

        void AddVoidVoid()
        {
            Console.WriteLine("Void Void Void");
        }
    }
}
