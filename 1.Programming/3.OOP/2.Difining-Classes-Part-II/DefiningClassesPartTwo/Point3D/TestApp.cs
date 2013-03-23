using System;

/// <summary>
/// Test app for the Point3D and Math3D classs
/// </summary>
class TestApp
{
    static void Main()
    {
        //Create some points
        Point3D pointA = new Point3D(0, 0, 5);
        Point3D pointB = new Point3D(0, 5, 5);

        //Print them
        Console.WriteLine("Point O: " + Point3D.Origin);
        Console.WriteLine("Point A: " + pointA);
        Console.WriteLine("Point B: " + pointB);

        //Calculate distances and print them
        double distanceAB = Math3D.Distance(pointA, pointB);
        Console.WriteLine("Distance(A, B): " + distanceAB);

        double distanceOA = Math3D.Distance(Point3D.Origin, pointA);
        Console.WriteLine("Distance(O, A): " + distanceOA);
    }
}

