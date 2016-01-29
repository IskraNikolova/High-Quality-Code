namespace RotatingWalkInMatrix
{
    using System;

    public class RotatingWalkInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(number);
            Console.WriteLine(matrix);
        }
    }
}
