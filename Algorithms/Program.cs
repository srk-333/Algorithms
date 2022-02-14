using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems");
            InvokeClass();
            Console.ReadKey();
        }
        /// <summary>
        /// invoke all the classes from here!
        /// </summary>
        static void InvokeClass()
        {
            string filePath = @"E:\RfaBatch\Algorithms\Algorithms\Data.txt";
            string text = File.ReadAllText(filePath);
            string[] textArray = text.Split();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1: ArrayPermutation");
                Console.WriteLine("2: BinarySearchWord");
                Console.WriteLine("3. Insertion Sort");
                Console.WriteLine("4. Bubble Sort");
                Console.WriteLine("5. Merge Sort");
                Console.WriteLine("6. Prime Number");
                Console.WriteLine("7. Prime: Palindrome");
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int factIterative = ArrayPermutation.IterativeFactorial(5);
                        Console.WriteLine("Factorial of a number by iteration method:" + factIterative);
                        int factRecursive = ArrayPermutation.RecursiveFactorial(5);
                        Console.WriteLine("Factorial of a number by recursive method:" + factRecursive);
                        break;
                    case 2:
                        BinarySearch<string> search = new BinarySearch<string>(textArray);
                        Console.WriteLine("Enter the word to search");
                        string searchElement = Console.ReadLine();
                        int found = search.BinarySearchWord(textArray, searchElement);
                        if (found == -1)
                        {
                            Console.WriteLine("Sorry! Word is not present.");
                        }
                        else
                        {
                            Console.WriteLine("{0} is present in the file", searchElement);
                        }
                        break;
                    case 3:
                        InsertionSort<string> insertionSort = new InsertionSort<string>();
                        insertionSort.InsertionSorting(textArray);
                        insertionSort.Display(textArray);
                        break;
                    case 4:
                        int[] arr = { 70, 10, 20, 5, 60, 30 };
                        BubbleSort<int> bubbleSort = new BubbleSort<int>();
                        bubbleSort.BubbleSorting(arr);
                        bubbleSort.Display(arr);
                        break;
                    case 5:
                        int start = 0;
                        int end = textArray.Length;
                        MergeSort<string> mergeSort = new MergeSort<string>();
                        mergeSort.MergeSorting(textArray, start, end - 1);
                        mergeSort.Display(textArray);
                        break;
                    case 6:
                        Console.WriteLine("Prime Numbers");
                        PrimeNumber.PrintPrime();
                        break;
                    case 7:
                        PalindromePrime.PrintPrime();
                        PalindromePrime.PrintPalindrome();
                        break;
                    default:
                        CONTINUE = false;
                        break;

                }
            }
        }
    }
}