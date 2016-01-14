using System;

namespace Methods
{
    public class Formatter
    {
        /// <summary>
        /// Formatting numbers.
        /// </summary>
        /// <param name="number">number for formatting.</param>
        /// <param name="format">formatted result</param>
        public static void PrintFormattingNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("|{0:f2}|", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("|{0:p0}|", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("|{0,8}|", number);
            }
            else
            {
                throw new FormatException("value");
            }
        }
    }
}
