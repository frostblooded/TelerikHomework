using System;
using System.Collections.Generic;

namespace PointsIn3DSpace
{
    public class PointsIn3DSpace
    {
        static void Main()
        {
            const string fileName = "pathsSave.txt";

            List<Path> paths = new List<Path>();

            Path path = new Path();
            path.AddPoint(new Point3D());
            path.AddPoint(new Point3D(1, 2, 3));
            paths.Add(path);

            path = new Path();
            path.AddPoint(new Point3D(4, 5, 6));
            path.AddPoint(new Point3D(7, 8, 9));
            path.AddPoint(new Point3D(10, 11, 12));
            paths.Add(path);

            PathStorage.Save(paths, fileName);
            paths = PathStorage.Load(fileName);

            foreach (var item in paths)
            {
                Console.WriteLine(item);
            }
        }
    }
}
