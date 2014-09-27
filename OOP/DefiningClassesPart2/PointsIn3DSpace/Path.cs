using System;
using System.Collections.Generic;
using System.Text;

namespace PointsIn3DSpace
{
    public class Path
    {
        public Path()
        {
            Points = new List<Point3D>();
        }

        private List<Point3D> Points { get; set; }

        public void AddPoint(Point3D addedPoint)
        {
            Points.Add(addedPoint);
        }

        public int Count
        {
            get
            {
                return Points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return Points[index];
            }
            set
            {
                Points[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Points.Count; i++)
            {
                result.AppendLine(String.Format("{0} - {1}", i + 1, Points[i].ToString()));
            }

            return result.ToString();
        }
    }
}
