public class Rectangle : Shape
{
    //Constructors
    public Rectangle(double width, double height)
        :base(width, height)
    {
    }

    //Methods
    public override double CalculateSurface()
    {
        double surface = this.width * this.height;
        return surface;
    }
}

