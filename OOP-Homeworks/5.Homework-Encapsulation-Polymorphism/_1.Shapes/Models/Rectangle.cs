﻿namespace _1.Shapes.Models
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width + this.Height) * 2;
        }
    }
}
