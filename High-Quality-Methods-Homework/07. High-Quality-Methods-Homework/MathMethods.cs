using System;

namespace Methods
{
    public class MathMethods
    {
        /// <summary>
        /// Convert digit in notes of words.
        /// </summary>
        /// <param name="number">digit to convert</param>
        /// <returns>name of digit</returns>
        public static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new FormatException("Invalid number!");
            }
        }

        /// <summary>
        /// Search max value in collection.
        /// </summary>
        /// <param name="elements">Numbers that we search.</param>
        /// <returns>Max number</returns>
        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("value", "Missing arguments");
            }

            int maxValue = Int32.MinValue;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Check is horizontal two sides.
        /// </summary>
        /// <param name="y">y - coordinate of first side</param>
        /// <param name="y1"> y - coordinate of second side</param>
        /// <returns>return bool result</returns>
        public static bool IsHorizontal(double y, double y1)
        {
            bool isHorizonta = (y == y1);

            return isHorizonta;
        }

        /// <summary>
        /// Check is vertical two sides.
        /// </summary>
        /// <param name="x">x - coordinate of first side</param>
        /// <param name="x1">y - coordinate of second side</param>
        /// <returns>return bool result</returns>
        public static bool IsVertical(double x, double x1)
        {
            bool isVertical = (x == x1);

            return isVertical;
        }
    }
}
