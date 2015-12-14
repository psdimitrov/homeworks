namespace _1.Shapes.Models
{
    using System;
    using _1.Shapes.Interfaces;

    public abstract class BasicShape : IShape
    {
        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; }

        public double Height { get; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();       
    }
}
