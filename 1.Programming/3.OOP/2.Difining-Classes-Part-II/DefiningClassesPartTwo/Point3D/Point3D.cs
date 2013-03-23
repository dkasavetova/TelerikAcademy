/// <summary>
/// Point in three-dimensional space
/// </summary>
public struct Point3D
{
    //Fields 
    private static readonly Point3D origin;

    //Properties 
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public static Point3D Origin
    {
        get
        {
            return origin;
        }
    }

    //Constructors
    static Point3D()
    {
        origin = new Point3D(0, 0, 0);
    }

    public Point3D(double x, double y, double z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    //Methods
    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
    }
}
