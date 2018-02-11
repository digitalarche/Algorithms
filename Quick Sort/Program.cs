using System;

namespace MosheBinieli.Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

            DisplayArray(numbersArray);

            Console.WriteLine("MergeSort By Recursive Method");
            QuickSort(numbersArray, 0, numbersArray.Length - 1);

            DisplayArray(numbersArray);
        }

        private static void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
        }

        public static void QuickSort(int[] myArray, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
                return;

            int index = Partition(myArray, left, right);

            if (index != -1)
            {
                QuickSort(myArray, left, index - 1);
                QuickSort(myArray, index + 1, right);
            }
        }

        private static int Partition(int[] myArray, int left, int right)
        {
            if (left > right)
                return -1;

            int end = left;

            int pivot = myArray[right];

            for (int i = left; i < right; i++)
                if (myArray[i] < pivot)
                    Swap(myArray, i, end++);

            Swap(myArray, end, right);

            return end;
        }

        private static void Swap(int[] myArray, int left, int right)
        {
            int tempValue = myArray[left];
            myArray[left] = myArray[right];
            myArray[right] = tempValue;
        }
    }
}
