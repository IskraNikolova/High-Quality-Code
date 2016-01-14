using System;
using CohesionAndCoupling;

public class CoordinateSystem
{
    public static double CalcDistanceBetweenTwoPointsIn2D(IPoint firstPoint, IPoint secondPoint)
    {
        double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) + 
                                    (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y));

        return distance;
    }

    public static double CalcDistanceBetweenTwoPointsIn3D(IPoint firstPoint, IPoint secondPoint)
    {
        double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                                    (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                                    (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));

        return distance;
    }

    public static double CalcVolume(double x, double y, double z)
    {
        double volume = x * y * z;

        return volume;
    }

    public static double CalcDiagonalIn3DSpace(double x, double y, double z)
    {
        double diagonalLength = Math.Sqrt((x * x) + (y * y) + (z * z));

        return diagonalLength;
    }

    public static double CalcDiagonalIn2DSpace(double x, double y)
    {
        double distance = Math.Sqrt((x * x) + (y * y));

        return distance;
    }
}

