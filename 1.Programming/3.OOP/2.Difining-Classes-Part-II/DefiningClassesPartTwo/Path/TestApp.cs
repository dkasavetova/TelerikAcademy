using System;

/// <summary>
/// Test app for Path and PathStorage classes
/// </summary>
class TestApp
{
    static void Main()
    {
        //Create some path
        Path path = new Path();
        path.Add(Point3D.Origin);
        path.Add(new Point3D(0, 0, 5));
        path.Add(new Point3D(0, 0, 10));
        path.Add(new Point3D(5, 5, 10));

        //Save it to a file
        string file = "../../path.txt";
        PathStorage.Save(path, file);

        //Read it from the file
        Path pathFromFile = PathStorage.Load(file);

        //Check if the initial path and the one that we read from file are same
        bool areTheSame = true;
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i].X != pathFromFile[i].X || path[i].Y != pathFromFile[i].Y || path[i].Z != pathFromFile[i].Z)
            {
                areTheSame = false;
                break;
            }
        }
        Console.WriteLine(areTheSame);
    }
}

