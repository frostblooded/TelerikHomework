using System;
using System.Collections.Generic;
using System.IO;

namespace PointsIn3DSpace
{
    public static class PathStorage
    {
        public static void Save(List<Path> paths, string saveFileName)
        {
            using (StreamWriter writer = new StreamWriter(saveFileName))
            {
                foreach (var path in paths)
                {
                    for (int i = 0; i < path.Count; i++)
                    {
                        writer.Write("{0} {1} {2} ", path[i].X, path[i].Y, path[i].Z);
                    }

                    writer.WriteLine();
                }
            }
        }

        public static List<Path> Load(string loadFileName)
        {
            List<Path> returnedPaths = new List<Path>();

            using (StreamReader reader = new StreamReader(loadFileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Queue<string> coordinatesAsString = new Queue<string>(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    Queue<int> coordinates = ParseQueue(coordinatesAsString);
                    List<Point3D> points = GetPoints(coordinates);
                    returnedPaths.Add(FillPath(points));
                }
            }

            return returnedPaths;
        }

        private static List<Point3D> GetPoints(Queue<int> coordinates)
        {
            List<Point3D> points = new List<Point3D>();

            while (coordinates.Count > 0)
            {
                Point3D newPoint = new Point3D(coordinates.Dequeue(), coordinates.Dequeue(), coordinates.Dequeue());
                points.Add(newPoint);
            }

            return points;
        }

        private static Queue<int> ParseQueue(Queue<string> parsedQueue)
        {
            Queue<int> resultingQueue = new Queue<int>();

            foreach (var coordinate in parsedQueue)
            {
                resultingQueue.Enqueue(int.Parse(coordinate));
            }

            return resultingQueue;
        }

        private static Path FillPath(List<Point3D> points)
        {
            Path returnedPath = new Path();

            foreach (var point in points)
            {
                returnedPath.AddPoint(point);
            }

            return returnedPath;
        }
    }
}
