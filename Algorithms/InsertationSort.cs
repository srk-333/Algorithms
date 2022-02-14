using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T> where T : IComparable
    {
        /// <summary>
        /// sort the string by insertion sort
        /// </summary>
        /// <param name="arr"></param>
        public void InsertionSorting(T[] arr)
        {
            T max;
            for (int i = 1; i < arr.Length; i++)
            {
                max = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].CompareTo(max) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = max;
            }
        }
        /// <summary>
        /// display string in sorted order
        /// </summary>
        /// <param name="arr"></param>
        public void Display(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}