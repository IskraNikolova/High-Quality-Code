namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericSubstringSequence<T>
    {
        public static T[] SubstringSequence<T>(T[] sequence, int startIndex, int count)
        {
            if (sequence == null || sequence.Length == 0)
            {
                throw new ArgumentNullException("Sequence is null. Cannot generates substring.");
            }

            IList<T> result = new List<T>();
            int length = startIndex + count;
            for (int currentIndex = startIndex; currentIndex < length; currentIndex++)
            {
                result.Add(sequence[currentIndex]);
            }

            return result.ToArray();
        }

    }
}
