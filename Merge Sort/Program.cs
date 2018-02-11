using System;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

            DisplayArray(numbersArray);

            Console.WriteLine("MergeSort By Recursive Method");
            MergeSort(numbersArray, 0, numbersArray.Length - 1);

            DisplayArray(numbersArray);
        }

        private static void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
        }

        public static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (high + low) / 2;
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low, right = middle + 1; ;
            int tmpIndex = 0;

            int[] tmp = new int[(high - low) + 1];

            // Merging between two arrays.
            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                    tmp[tmpIndex++] = input[left++];
                else
                    tmp[tmpIndex++] = input[right++];
            }

            // Checking whether we have something remain in left array to insert.
            while (left <= middle)
                tmp[tmpIndex++] = input[left++];

            // Checking whether we have something remain in right array to insert.
            while (right <= high)
                tmp[tmpIndex++] = input[right++];

            // Replacing new temporarily array to original array.
            for (int i = 0; i < tmp.Length; i++)
                input[low + i] = tmp[i];
        }
    }
}
