public abstract class Shape
{
    //Fields
    protected double width;
    protected double height;

    //Constructors
    protected Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    //Methods
    public abstract double CalculateSurface();
}

