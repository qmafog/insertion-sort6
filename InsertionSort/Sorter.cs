using System;

// ReSharper disable InconsistentNaming
namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RecursiveInsertionSort(array, array.Length);
        }

        public static void RecursiveInsertionSort(this int[]? array, int length)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (length <= 1)
            {
                return;
            }

            RecursiveInsertionSort(array, length - 1);

            int lastElement = array[length - 1];
            int j = length - 2;

            while (j >= 0 && array[j].CompareTo(lastElement) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = lastElement;
        }
    }
}
