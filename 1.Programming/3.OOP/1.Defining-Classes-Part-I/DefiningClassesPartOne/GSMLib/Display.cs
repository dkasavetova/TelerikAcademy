using System;

public class Display
{
    //Fields
    /* 1 */
    private double? size;
    private int? colorsCount;

    //Properties
    /* 5 */
    public double? Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("size", "value must be a positive number.");
            }
            this.size = value;
        }
    }

    public int? ColorsCount
    {
        get
        {
            return this.colorsCount;
        }
        set
        {
            if (value <= 0) 
            {
                throw new ArgumentOutOfRangeException("colorsCount", "value must be a positive integer");
            }
            this.colorsCount = value;
        }
    }

    //Constructors
    /* 2 */
    public Display(double? size, int? colorsCount)
    {
        this.Size = size;
        this.ColorsCount = colorsCount;
    }

    public Display(int? size)
        :this(size, null)
    {
    }

    //Methods
    /* 4 */
    public override string ToString()
    {
        return string.Format("Size: {0}, ColorsCount: {1}",
            Size == null ? "null" : Size.ToString() + " inch",
            ColorsCount == null ? "null" : ColorsCount.ToString());
    }
}

