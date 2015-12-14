namespace _1.Shapes.Models
{
    using System;
    using _1.Shapes.Interfaces;

    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
            : base(width, height)
        {                        
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return Math.Sqrt(this.Width * this.Width + this.Height * this.Height) * 2;
        }
    }
}
