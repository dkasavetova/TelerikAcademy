using System;

/// <summary>
/// Contains methods for calculations in three-dimensional space
/// </summary>
public static class Math3D
{
    /// <summary>
    /// Calculates the Euclidean distance between two points.
    /// </summary>
    /// <param name="firstPoint">The first point</param>
    /// <param name="secondPoint">The second point</param>
    /// <returns>The distance between the two points</returns>
    public static double Distance(Point3D firstPoint, Point3D secondPoint) 
    {
        double deltaX = firstPoint.X - secondPoint.X;
        double deltaY = firstPoint.Y - secondPoint.Y;
        double deltaZ = firstPoint.Z - secondPoint.Z;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

        return distance;
    }
}

