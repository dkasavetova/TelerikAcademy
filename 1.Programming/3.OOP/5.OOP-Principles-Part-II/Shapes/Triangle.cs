public class Triangle : Shape
{
    //Constructors
    public Triangle(double width, double height)
        :base(width, height)
    {
    }

    //Methods
    public override double CalculateSurface()
    {
        double surface = (this.width * this.height) / 2.0;
        return surface;
    }
}

