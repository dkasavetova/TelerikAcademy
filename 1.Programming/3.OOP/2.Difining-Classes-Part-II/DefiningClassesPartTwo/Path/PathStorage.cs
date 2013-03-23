using System;
using System.IO;

/// <summary>
/// Contains methods for saving and loading Paths from files
/// </summary>
public static class PathStorage
{
    /// <summary>
    /// Saves path of points in three-dimensional space to a file
    /// </summary>
    /// <param name="path">The path of points</param>
    /// <param name="toFile">The file where the path will be saved</param>
    public static void Save(Path path, string toFile)
    {
        using (StreamWriter sw = new StreamWriter(toFile))
        {
            for (int i = 0; i < path.Length; i++)
            {
                sw.WriteLine(path[i]);
            }
        }
    }

    /// <summary>
    /// Loads path of points in three-dimensional space from a file
    /// </summary>
    /// <param name="fromFile">The file from where the path will be read</param>
    /// <returns>The path of points</returns>
    public static Path Load(string fromFile)
    {
        Path path = new Path();

        using (StreamReader sr = new StreamReader(fromFile))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Point3D point = ParsePoint3D(line);
                path.Add(point);
            }
        }

        return path;
    }

    /// <summary>
    /// Parses Point3D
    /// </summary>
    /// <param name="str">The string to parse</param>
    /// <returns>The parsed point</returns>
    private static Point3D ParsePoint3D(string str)
    {
        string[] splitted = str.Split(new char[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double pointX = double.Parse(splitted[0]);
        double pointY = double.Parse(splitted[1]);
        double pointZ = double.Parse(splitted[2]);

        Point3D point = new Point3D(pointX, pointY, pointZ);

        return point;
    }
}

