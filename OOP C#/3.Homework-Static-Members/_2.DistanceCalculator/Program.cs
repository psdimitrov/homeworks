namespace _2.DistanceCalculator
{
    using System;
    using _1.Point3D;

    class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(-10.3, -6.5, 8.6);
            Point3D point2 = new Point3D(16, 6.6, 2.5);

            Console.WriteLine(DistanceCalculator.CalculateDistance(point1, point2));
        }
    }
}
