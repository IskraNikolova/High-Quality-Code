namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameParser.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileExtension("example.new.pdf"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.new.pdf"));

            IPoint firstPointIn2D = new Point(1, -2);
            IPoint secondPointIn2D = new Point(3, 4);
            double distanceIn2D = CoordinateSystem.CalcDistanceBetweenTwoPointsIn2D(firstPointIn2D, secondPointIn2D);
            Console.WriteLine($"Distance in the 2D space = {distanceIn2D:F2}cm.");

            IPoint firstPointIn3D = new Point(5, 2, -1);
            IPoint secondPointIn3D = new Point(3, -6, 4);
            double distanceIn3D = CoordinateSystem.CalcDistanceBetweenTwoPointsIn3D(firstPointIn3D, secondPointIn3D);
            Console.WriteLine($"Distance in the 3D space = {distanceIn3D:F2}cm.");
               
            double xCoordinatePlace = 3;
            double yCoordinatePlace = 4;
            double zCoordinatePlace = 5;
            double calculateVolume = CoordinateSystem.CalcVolume(xCoordinatePlace, yCoordinatePlace, zCoordinatePlace);
            double calcDiagonalIn3DSpace = CoordinateSystem.CalcDiagonalIn3DSpace(xCoordinatePlace, yCoordinatePlace, zCoordinatePlace);
            double calcDiagonalIn2DSpace = CoordinateSystem.CalcDiagonalIn2DSpace(xCoordinatePlace, yCoordinatePlace);
        
            Console.WriteLine();
            Console.WriteLine($"Volume = {calculateVolume:F2}");
            Console.WriteLine($"Diagonal XYZ = {calcDiagonalIn3DSpace:F2}cm.");
            Console.WriteLine($"Diagonal XY = {calcDiagonalIn2DSpace:F2}cm.");
            Console.WriteLine($"Diagonal XZ = {calcDiagonalIn2DSpace:F2}cm.");
            Console.WriteLine($"Diagonal YZ = {calcDiagonalIn2DSpace:F2}cm.");
        }
    }
}
