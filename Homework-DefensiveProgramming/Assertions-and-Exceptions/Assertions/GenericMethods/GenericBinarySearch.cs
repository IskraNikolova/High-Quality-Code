namespace Assertions_Homework.GenericMethods
{
    using System;

    public class GenericBinarySearch<T>
    {
        public static int BinarySearch<T>(T[] collection, T soughtValue)
            where T : IComparable<T>
        {
            if (collection == null || collection.Length == 0)
            {
                throw new ArgumentNullException("value", "Collection is empty. Can not be sorted missing collection.");
            }

            return BinarySearch(collection, soughtValue, 0, collection.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
