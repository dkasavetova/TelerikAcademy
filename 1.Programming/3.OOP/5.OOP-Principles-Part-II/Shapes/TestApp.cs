using System;

class TestApp
{
    static void Main()
    {
        Shape[] shapes = new Shape[] 
        {
            new Rectangle(3, 5),
            new Triangle(3, 5),
            new Circle(3)
        };

        foreach (var shape in shapes)
        {
            string shapeType = shape.GetType().Name;
            double shapeSurface = shape.CalculateSurface();

            Console.WriteLine("{0}: {1:F2}", shapeType, shapeSurface);
        }
    }
}

