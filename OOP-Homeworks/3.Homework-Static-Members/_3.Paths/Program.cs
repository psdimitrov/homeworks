namespace _3.Paths
{
    using System;
    using _1.Point3D;

    class Program
    {
        private const string filename = "../../pathfile.txt";
        static void Main(string[] args)
        {            
            Path3D path = new Path3D(new Point3D(4.6, 7.3, 5),
                new Point3D(1.4, 2.65, 4.5),
                new Point3D(10.45, 3.3, 5.9),
                new Point3D(2.6, 16.4, 20.5));

            Storage.SavePath(path, filename);
            Path3D pathFromFile = Storage.LoadPath(filename);
            foreach (var point in pathFromFile.Path)
            {
                Console.WriteLine(point);
            }
        }
    }
}
