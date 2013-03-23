using System;

public class Circle : Shape
{
    //Constructors
    public Circle(double radius)
        :base(radius, radius)
    {
    }

    //Methods
    public override double CalculateSurface()
    {
        double surface = Math.PI * this.height * this.height;
        return surface;
    }
}

