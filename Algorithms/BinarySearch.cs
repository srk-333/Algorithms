using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch<T> where T : IComparable
    {
        readonly T[] array;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="array"></param>
        public BinarySearch(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
        /// <summary>
        /// search word
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public int BinarySearchWord(T[] array, T element)
        {
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int key = element.CompareTo(array[mid]);
                if (key == 0)
                    return mid;
                if (key > 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}