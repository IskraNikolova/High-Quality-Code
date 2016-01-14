namespace Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double triangleArea = triangle.CalcTriangleArea();
            Console.WriteLine($"Area of triangle is {triangleArea} cm.");
            Console.WriteLine();

            int numberToConvert = 5;
            string wordOfDigit = MathMethods.DigitToWord(numberToConvert);
            Console.WriteLine($"Digit \"{numberToConvert}\" write - {wordOfDigit}.");
            Console.WriteLine();

            int[] numbersForComparison = {5, -1, 3, 2, 14, 2, 3};
            int maxNumber = MathMethods.FindMaxNumber(numbersForComparison);
            Console.WriteLine($"Max number is: {maxNumber}");
            Console.WriteLine();

            Console.WriteLine("Formatted number:");
            Formatter.PrintFormattingNumber(1.3, "f");
            Formatter.PrintFormattingNumber(0.75, "%");
            Formatter.PrintFormattingNumber(2.30, "r");
            Console.WriteLine();

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            Point firstPoint = new Point(x1, y1);
            Point secondPoint = new Point(x2, y2);
            double distance = firstPoint.CalculateDistanceBetweenTwoPoints(secondPoint);
            Console.WriteLine($"Distance between point A{firstPoint} and point B{secondPoint} is: {distance}");
            Console.WriteLine();

            bool isTwoPointsHorizontal = MathMethods.IsHorizontal(y1, y2);
            bool isTwoPointsVertical = MathMethods.IsVertical(x1, x2);
            Console.WriteLine($"Is y of point A is horizontal of y of point B? {isTwoPointsHorizontal}");
            Console.WriteLine($"Is x of point A is vertical of x of point B? {isTwoPointsVertical}");
            Console.WriteLine();

            string peterOtherInfo = "From Sofia, born at 17.03.1992";
            Student peter = new Student("Peter", "Ivanov", peterOtherInfo);
            
            string stellaOtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            Student stella = new Student("Stella", "Markova", stellaOtherInfo);

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
