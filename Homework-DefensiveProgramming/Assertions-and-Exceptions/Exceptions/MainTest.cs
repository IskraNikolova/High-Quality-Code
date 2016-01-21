namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using Methods;

    public class MainTest
    {
        public static void Main()
        {
            try
            {
                var substringOfCharCollection = GenericSubstringSequence<char>.SubstringSequence(
                    "Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substringOfCharCollection);

                var substringOfIntCollection = GenericSubstringSequence<char>.SubstringSequence(
                    new int[] {-1, 3, 2, 1}, 0, 2);
                Console.WriteLine(String.Join(" ", substringOfIntCollection));

                var allCollection = GenericSubstringSequence<char>.SubstringSequence(new int[] {-1, 3, 2, 1}, 0, 4);
                Console.WriteLine(String.Join(" ", allCollection));

                var emptyCollection = GenericSubstringSequence<char>.SubstringSequence(new int[] {-1, 3, 2, 1}, 0, 0);
                Console.WriteLine(String.Join(" ", emptyCollection));

                Console.WriteLine(ExtractorEnds.ExtractEndingOfString("I love C#", 2));
                Console.WriteLine(ExtractorEnds.ExtractEndingOfString("Nakov", 4));
                Console.WriteLine(ExtractorEnds.ExtractEndingOfString("beer", 4));
                //Console.WriteLine(ExtractEnding("Hi", 100)); // Invalid Count!

                List<int> numbersForCheck = new List<int>() {23, 33};
                numbersForCheck.ForEach(PrintIsPrime);

                List<IExam> peterExams = new List<IExam>()
                {
                    new SimpleMathExam(2),
                    new CSharpExam(55),
                    new CSharpExam(100),
                    new SimpleMathExam(1),
                    new CSharpExam(0),
                };

                //Student invalidName = new Student("9898Peter", "Petrov", peterExams);
                //Console.WriteLine(invalidName);

                Student peter = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peter.CalcAverageExamResultInPercents();

                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }

        private static void PrintIsPrime(int numberForCheck)
        {
            bool isPrime = CheckerIsPrime.CheckPrime(numberForCheck);
            string primeOrNot = isPrime ? "prime" : "not prime";

            Console.WriteLine($"{numberForCheck} is {primeOrNot}.");
        }
    }
}
