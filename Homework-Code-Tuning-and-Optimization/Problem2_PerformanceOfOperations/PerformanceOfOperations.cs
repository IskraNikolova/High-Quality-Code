namespace Problem2_PerformanceOfOperations
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using System.Diagnostics;

    public class PerformanceOfOperations
    {
        static int N = 500;
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            int a = 1;
            long longNumber = 1;
            float floatNumber = 1f;
            double doubleNumber = 1;
            decimal decimalNumber = 1m;

            //compare the performance of add, subtract, increment, multiply, divide for int, long, float, double and decimal values.
            TimeSpan timeSpansAvarageAddInt = CalculateAverageAddOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (+) operator which type is int  - {timeSpansAvarageAddInt}");

            TimeSpan timeSpansAvarageAddLong = CalculateAverageAddOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (+) operator which type is long  - {timeSpansAvarageAddLong}");

            TimeSpan timeSpansAvarageAddFloat = CalculateAverageAddOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (+) operator which type is float  - {timeSpansAvarageAddFloat}");

            TimeSpan timeSpansAvarageAddDouble = CalculateAverageAddOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (+) operator which type is double  - {timeSpansAvarageAddDouble}");

            TimeSpan timeSpansAvarageAddDecimal = CalculateAverageAddOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (+) operator which type is decimal  - {timeSpansAvarageAddDecimal}");

            Console.WriteLine();
            TimeSpan timeSpansAvarageSubstractInt = CalculateAverageSubstractOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (-) operator which type is int  - {timeSpansAvarageSubstractInt}");

            TimeSpan timeSpansAvarageSubstractLong = CalculateAverageSubstractOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (-) operator which type is long  - {timeSpansAvarageSubstractLong}");

            TimeSpan timeSpansAvarageSubstractFloat = CalculateAverageSubstractOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (-) operator which type is float  - {timeSpansAvarageSubstractFloat}");

            TimeSpan timeSpansAvarageSubstractDouble = CalculateAverageSubstractOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (-) operator which type is double  - {timeSpansAvarageSubstractDouble}");

            TimeSpan timeSpansAvarageSubstractDecimal = CalculateAverageSubstractOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (-) operator which type is decimal  - {timeSpansAvarageSubstractDecimal}");
            Console.WriteLine();

            TimeSpan timeSpansPrefixAverageInt = CalculateAveragePrefixOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (++(prefix)) operator which type is int  - {timeSpansPrefixAverageInt}");

            TimeSpan timeSpansPrefixAverageLong = CalculateAveragePrefixOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (++(prefix)) operator which type is long  - {timeSpansPrefixAverageLong}");

            TimeSpan timeSpansPrefixAverageFloat = CalculateAveragePrefixOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (++(prefix)) operator which type is float  - {timeSpansPrefixAverageFloat}");

            TimeSpan timeSpansPrefixAverageDouble = CalculateAveragePrefixOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (++(prefix)) operator which type is double  - {timeSpansPrefixAverageDouble}");

            TimeSpan timeSpansPrefixAverageDecimal = CalculateAveragePrefixOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (++(prefix)) operator which type is decimal  - {timeSpansPrefixAverageDecimal}");
            Console.WriteLine();

            TimeSpan timeSpansPostfixAverageInt = CalculateAveragePostfixOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for ((postfix)++) operator which type is int  - {timeSpansPostfixAverageInt}");

            TimeSpan timeSpansPostfixAverageLong = CalculateAveragePostfixOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for ((postfix)++) operator which type is long  - {timeSpansPostfixAverageLong}");

            TimeSpan timeSpansPostfixAverageFloat = CalculateAveragePostfixOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for ((postfix)++) operator which type is float  - {timeSpansPostfixAverageFloat}");

            TimeSpan timeSpansPostfixAverageDouble = CalculateAveragePostfixOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for ((postfix)++) operator which type is double  - {timeSpansPostfixAverageDouble}");

            TimeSpan timeSpansPostfixAverageDecimal = CalculateAveragePostfixOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for ((postfix)++) operator which type is decimal  - {timeSpansPostfixAverageDecimal}");
            Console.WriteLine();

            TimeSpan timeSpansPostfixAddAverageInt = CalculateAveragePostfixAddOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (+=1) operator which type is int  - {timeSpansPostfixAddAverageInt}");

            TimeSpan timeSpansPostfixAddAverageLong = CalculateAveragePostfixAddOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (+=1) operator which type is long  - {timeSpansPostfixAddAverageLong}");

            TimeSpan timeSpansPostfixAddAverageFloat = CalculateAveragePostfixAddOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (+=1) operator which type is float  - {timeSpansPostfixAddAverageFloat}");

            TimeSpan timeSpansPostfixAddAverageDouble = CalculateAveragePostfixAddOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (+=1) operator which type is double  - {timeSpansPostfixAddAverageDouble}");

            TimeSpan timeSpansPostfixAddAverageDecimal = CalculateAveragePostfixAddOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (+=1) operator which type is decimal  - {timeSpansPostfixAddAverageDecimal}");
            Console.WriteLine();

            TimeSpan timeSpansMultiplyAverageInt = CalculateAverageMultiplyOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (*) operator which type is int  - {timeSpansMultiplyAverageInt}");

            TimeSpan timeSpansMultiplyAverageLong = CalculateAverageMultiplyOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (*) operator which type is long  - {timeSpansMultiplyAverageLong}");

            TimeSpan timeSpansMultiplyAverageFloat = CalculateAverageMultiplyOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (*) operator which type is float  - {timeSpansMultiplyAverageFloat}");

            TimeSpan timeSpansMultiplyAverageDouble = CalculateAverageMultiplyOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (*) operator which type is double  - {timeSpansMultiplyAverageDouble}");

            TimeSpan timeSpansMultiplyAverageDecimal = CalculateAverageMultiplyOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (*) operator which type is decimal  - {timeSpansMultiplyAverageDecimal}");
            Console.WriteLine();

            TimeSpan timeSpansDivideAverageInt = CalculateAverageDivideOperationTimeSpan(a, stopwatch);
            Console.WriteLine($"Avarage for (/) operator which type is int  - {timeSpansDivideAverageInt}");

            TimeSpan timeSpansDivideAverageLong = CalculateAverageDivideOperationTimeSpan(longNumber, stopwatch);
            Console.WriteLine($"Avarage for (/) operator which type is long  - {timeSpansDivideAverageLong}");

            TimeSpan timeSpansDivideAverageFloat = CalculateAverageDivideOperationTimeSpan(floatNumber, stopwatch);
            Console.WriteLine($"Avarage for (/) operator which type is float  - {timeSpansDivideAverageFloat}");

            TimeSpan timeSpansDivideAverageDouble = CalculateAverageDivideOperationTimeSpan(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage for (/) operator which type is double  - {timeSpansDivideAverageDouble}");

            TimeSpan timeSpansDivideAverageDecimal = CalculateAverageDivideOperationTimeSpan(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage for (/) operator which type is decimal  - {timeSpansDivideAverageDecimal}");
            Console.WriteLine();

            //compare the performance of square root, natural logarithm, sine for float, double and decimal values.
            TimeSpan timespanAverageMathSqrtFloat = CalculateTimeForPerformanceOfSquareRoot(floatNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of square root of type float - {timespanAverageMathSqrtFloat}");

            TimeSpan timespanAverageMathSqrtDouble = CalculateTimeForPerformanceOfSquareRoot(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of square root of type double - {timespanAverageMathSqrtDouble}");

            TimeSpan timespanAverageMathSqrtDecimal = CalculateTimeForPerformanceOfSquareRoot(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of square root of type decimal - {timespanAverageMathSqrtDecimal}");
            Console.WriteLine();

            TimeSpan timespanAverageNaturalLogarithmFloat = CalculateTimeForPerformanceNaturalLogarithm(floatNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of natural logarithm of type float - {timespanAverageNaturalLogarithmFloat}");

            TimeSpan timespanAverageNaturalLogarithmtDouble = CalculateTimeForPerformanceNaturalLogarithm(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of natural logarithm of type double - {timespanAverageNaturalLogarithmtDouble}");

            TimeSpan timespanAverageNaturalLogarithmDecimal = CalculateTimeForPerformanceNaturalLogarithm(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of natural logarithm of type decimal - {timespanAverageNaturalLogarithmDecimal}");
            Console.WriteLine();

            TimeSpan timespanAverageSineFloat = CalculateTimeForPerformanceSine(floatNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of sine of type float - {timespanAverageSineFloat}");

            TimeSpan timespanAverageSineDouble = CalculateTimeForPerformanceSine(doubleNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of sine of type double - {timespanAverageSineDouble}");

            TimeSpan timespanAverageSineDecimal = CalculateTimeForPerformanceSine(decimalNumber, stopwatch);
            Console.WriteLine($"Avarage of performance of sine of type decimal - {timespanAverageSineDecimal}");
        }

        public static TimeSpan CalculateAverageAddOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = 100 + 100;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }  
                     
            double averageAdd = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageAddOperation = new TimeSpan(Convert.ToInt64(averageAdd));

            return averageAddOperation;
        }

        public static TimeSpan CalculateAverageSubstractOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = 100 - 100;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averageSubstract = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageSubstractOperation = new TimeSpan(Convert.ToInt64(averageSubstract));

            return averageSubstractOperation;
        }

        public static TimeSpan CalculateAveragePrefixOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        { 
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            value = 100;
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                ++value;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averagePrefix = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averagePrefixOperation = new TimeSpan(Convert.ToInt64(averagePrefix));

            return averagePrefixOperation;
        }

        public static TimeSpan CalculateAveragePostfixOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            value = 100;
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value++;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }
          
            double averagePostfix = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averagePostfixOperation = new TimeSpan(Convert.ToInt64(averagePostfix));

            return averagePostfixOperation;
        }

        public static TimeSpan CalculateAveragePostfixAddOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value += 100;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averagePostfixAdd = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averagePostfixAddOperation = new TimeSpan(Convert.ToInt64(averagePostfixAdd));

            return averagePostfixAddOperation;
        }

        public static TimeSpan CalculateAverageMultiplyOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();

            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = 100 * 100;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }
           
            double averageMultiply = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageMultiplyOperation = new TimeSpan(Convert.ToInt64(averageMultiply));

            return averageMultiplyOperation;
        }

        public static TimeSpan CalculateAverageDivideOperationTimeSpan(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = 100 / 100;

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averageDivide = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageDivideOperation = new TimeSpan(Convert.ToInt64(averageDivide));

            return averageDivideOperation;
        }

        public static TimeSpan CalculateTimeForPerformanceOfSquareRoot(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = Math.Sqrt(100);

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averageTimeSpanForSqrt = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageTimeSpanForSqrtResult = new TimeSpan(Convert.ToInt64(averageTimeSpanForSqrt));

            return averageTimeSpanForSqrtResult;
        }


        public static TimeSpan CalculateTimeForPerformanceNaturalLogarithm(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = Math.Log(100);

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averageTimeSpanNatLog = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageTimeSpanNatLogResult = new TimeSpan(Convert.ToInt64(averageTimeSpanNatLog));

            return averageTimeSpanNatLogResult;
        }

        public static TimeSpan CalculateTimeForPerformanceSine(dynamic value, Stopwatch stopwatch)
        {
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 1; i < N; i++)
            {
                stopwatch.Start();

                value = Math.Sin(100);

                stopwatch.Stop();
                timeSpans.Add(stopwatch.Elapsed);
                stopwatch.Restart();
            }

            double averageTimeSpanSine = timeSpans.Average(timeSpan => timeSpan.Ticks);
            TimeSpan averageTimeSpanSineResult = new TimeSpan(Convert.ToInt64(averageTimeSpanSine));

            return averageTimeSpanSineResult;
        }
    }
}
