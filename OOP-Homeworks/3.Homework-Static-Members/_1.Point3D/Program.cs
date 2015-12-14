namespace _1.Point3D
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Point3D point = new Point3D(3.6, 4.4, 10.5);
            Console.WriteLine(point);

            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
