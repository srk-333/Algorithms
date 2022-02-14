using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort<T> where T : IComparable
    {
        /// <summary>
        /// sort the array by bubble sort
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] BubbleSorting(T[] arr)
        {
            T temp;
            for (int i = 0; i < arr.Length; i++)
            {              
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// display the sorted array
        /// </summary>
        /// <param name="arr"></param>
        public void Display(T[] arr)
        {
            foreach (T sort in arr)
            {
                Console.Write(sort + " ");
            }
            Console.WriteLine();
        }
    }
}