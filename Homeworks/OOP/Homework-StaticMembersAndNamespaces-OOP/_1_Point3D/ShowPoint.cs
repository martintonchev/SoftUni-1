namespace Point3D
{
    using System;

    public class ShowPoint
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D(3, 5, 9);
            Point3D secondPoint = new Point3D(4, 5, 19);
            double distance = DistanceCalculator.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:F2}", distance);
        }
    }
}
