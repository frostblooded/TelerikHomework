using System;

namespace PointsIn3DSpace
{
    public static class DistanceCalculate3D
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double firstEquation = Math.Pow((secondPoint.X - firstPoint.X), 2);
            double secondEquation = Math.Pow((secondPoint.Y - firstPoint.Y), 2);
            double thirdEquation = Math.Pow((secondPoint.Z - firstPoint.Z), 2);

            return Math.Sqrt(firstEquation + secondEquation + thirdEquation);
        }
    }
}
