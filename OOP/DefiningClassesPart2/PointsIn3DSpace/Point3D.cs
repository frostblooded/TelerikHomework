using System;

namespace PointsIn3DSpace
{
    public struct Point3D
    {
        static readonly Point3D coordinateSystemStart = new Point3D();

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D CoordinateSystemStart
        {
            get
            {
                return coordinateSystemStart;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            return String.Format("Point Coordinates: X: {0}; Y: {1}, Z: {2}", X, Y, Z);
        }
    }
}
