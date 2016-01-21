namespace Exceptions_Homework.Methods
{
    using System;
    using System.Text;

    public class ExtractorEnds
    {
        public static string ExtractEndingOfString(string substring, int countOfSubstring)
        {
            if (countOfSubstring > substring.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid count!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = substring.Length - countOfSubstring; i < substring.Length; i++)
            {
                result.Append(substring[i]);
            }

            return result.ToString();
        }
    }
}
