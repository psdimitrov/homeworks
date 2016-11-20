namespace _1.Shapes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(5.6, 13.3),
                new Circle(1.6),
                new Rhombus(45, 48),
                new Circle(16.2),
                new Rectangle(3, 6.7),
                new Circle(96),   
                new Rhombus(12, 8)                                      
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0,-10} Area: {1,8:F2}  Perimiter: {2,-10:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
