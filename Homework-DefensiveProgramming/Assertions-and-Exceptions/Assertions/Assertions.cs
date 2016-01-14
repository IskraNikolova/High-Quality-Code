using Assertions_Homework.GenericMethods;

namespace Assertions_Homework
{
    using System;

    public class Assertions
    {
        public static void Main()
        {
            try
            {
                int[] arr = new int[] {3, -1, 15, 4, 17, 2, 33, 0};
                Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
                GenericSelectionSort<int>.SelectionSort(arr);
                Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

                // GenericSelectionSort<int>.SelectionSort(new int[0]); // Test sorting empty array
                // GenericSelectionSort<int>.SelectionSort(new int[1]); // Test sorting single element array

                Console.WriteLine(GenericBinarySearch<int>.BinarySearch(arr, -1000));
                Console.WriteLine(GenericBinarySearch<int>.BinarySearch(arr, 0));
                Console.WriteLine(GenericBinarySearch<int>.BinarySearch(arr, 17));
                Console.WriteLine(GenericBinarySearch<int>.BinarySearch(arr, 10));
                Console.WriteLine(GenericBinarySearch<int>.BinarySearch(arr, 1000));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
