using System;

public class GeometryLibrary
{
    public static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double TriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
