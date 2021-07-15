using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sorting an array using Selection Sort Algorithm

namespace SelectionSort
{
    class Program
    {

        static void sort(int[] arr)
        {
            //finding minimum element in the unsorted array         
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //swapping element with the first element.
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            //creating and outputting unsorted array
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Unsorted Array");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            //sorting array and outputting results
            sort(arr);

            Console.WriteLine("\n \n Sorted Array");
            foreach (var item in arr)
            {          
                Console.Write(item + " ");
            }
        }
    }
}
