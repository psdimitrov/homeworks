﻿namespace _2.DistanceCalculator
{
    using System;
    using _1.Point3D;
    
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
