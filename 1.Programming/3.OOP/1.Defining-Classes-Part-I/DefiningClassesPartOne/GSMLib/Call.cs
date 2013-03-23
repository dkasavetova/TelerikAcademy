using System;

public class Call
{
    /* 8 */
    //Properties
    public DateTime DateTime { get; set; }
    public string DailedNumber  { get; set; }
    public uint Duration { get; set; }

    //Constructors
    public Call(DateTime dateTime, string dailedNumber, uint duration)
    {
        this.DateTime = dateTime;
        this.DailedNumber = dailedNumber;
        this.Duration = duration;
    }

    //Methods
    public override string ToString()
    {
        return string.Format("DateTime: {0}, DailedNumber: {1}, Duration: {2}",
            this.DateTime, this.DailedNumber, this.Duration + " s");
    }
}

