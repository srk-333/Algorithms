using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumber
    {
        const int LIMIT = 1000;
        static int flag;
        /// <summary>
        /// print prime number in range
        /// </summary>
        public static void PrintPrime()
        {
            for (int i = 2; i <= LIMIT; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}