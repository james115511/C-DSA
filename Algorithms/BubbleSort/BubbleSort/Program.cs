using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using the Bubble Sort Algorithm to sort an array.

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,13,-3,55,601,2,33 };
            int temp;
            //outputing original array
            Console.WriteLine("Original array");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //Sorting Array
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            //outputting sorted array
            Console.WriteLine("sorted array");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}
