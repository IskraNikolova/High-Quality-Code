namespace Assertions_Homework.GenericMethods
{
    using System;

    public class GenericSelectionSort<T>
    {
        public static void SelectionSort<T>(T[] sortedCollection)
        where T : IComparable<T>
        {
            if (sortedCollection == null || sortedCollection.Length == 0)
            {
                throw new ArgumentNullException("value", "Collection is empty. Can not be sorted missing collection.");
            }
            else if (sortedCollection.Length == 1)
            {
                throw new ArgumentException("Collection is not enav large for sort. Please enter more data!");
            }

            for (int index = 0; index < sortedCollection.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(sortedCollection, index, sortedCollection.Length - 1);
                Swap(ref sortedCollection[index], ref sortedCollection[minElementIndex]);
            }
        }

        private static void Swap<T>(ref T presentValue, ref T minValue)
        {
            T oldValue = presentValue;
            presentValue = minValue;
            minValue = oldValue;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }
    }
}
