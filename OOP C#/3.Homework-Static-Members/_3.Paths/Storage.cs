namespace _3.Paths
{
    using _1.Point3D;
    using System;
    using System.IO;
    using System.Linq;

    public static class Storage
    {
        public static void SavePath(Path3D path, string filename)
        {
            using (var writer = new StreamWriter(filename))
            {
                foreach (var point in path.Path)
                {
                    writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
        }

        public static Path3D LoadPath(string filename)
        {
            Path3D loadedPath = new Path3D();
            using (var reader = new StreamReader(filename))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] coordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToArray();
                    loadedPath.Path.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    line = reader.ReadLine();
                }
            }

            return loadedPath;
        }
    }
}
