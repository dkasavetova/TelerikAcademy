using System;

public class InvalidRangeException<T> : ApplicationException
{
    //Fields
    private T rangeStart;
    private T rangeEnd;

    //Properties
    public T RangeStart 
    { 
        get 
        {
            return this.rangeStart; 
        } 
    }

    public T RangeEnd
    {
        get
        {
            return this.rangeEnd;
        }
    }

    //Constructors
    public InvalidRangeException(T rangeStart, T rangeEnd, string message, Exception innerException = null)
        :base(message, innerException)
    {
        this.rangeStart = rangeStart;
        this.rangeEnd = rangeEnd;
    }

    //Methods
    public override string Message
    {
        get
        {
            string message = string.Format("{0} [{1}, {2}]",
                base.Message, this.rangeStart, this.rangeEnd);
            return message;
        }
    }
}

