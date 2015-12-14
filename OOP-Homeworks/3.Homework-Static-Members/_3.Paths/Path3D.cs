namespace _3.Paths
{
    using _1.Point3D;
    using System.Collections.Generic;

    public class Path3D
    {
        public Path3D(params Point3D[] points)
        {
            this.Path = new List<Point3D>();
            this.AddPoints(points);
        }

        public List<Point3D> Path { get; set; }

        private void AddPoints(params Point3D[] points)
        {
            foreach (var point in points)
            {
                this.Path.Add(point);
            }
        }
    }
}
