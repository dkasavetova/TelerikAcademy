using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Path of points in three-dimensional space
/// </summary>
public class Path
{
    //Fields
    private List<Point3D> path;

    //Properties
    public Point3D this[int index]
    {
        get
        {
            return path[index];
        }
        set
        {
            path[index] = value;
        }
    }

    public int Length
    {
        get
        {
            return this.path.Count;
        }
        private set { }
    }
    

    //Constructors
    public Path()
    {
        this.path = new List<Point3D>();
    }

    //Methods
    public void Add(Point3D point)
    {
        this.path.Add(point);
    }

    public void RemoveAt(int index)
    {
        this.path.RemoveAt(index);
    }
}

