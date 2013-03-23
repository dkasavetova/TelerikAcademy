using System;

public class Battery
{
    //Fields
    /* 1 */
    private string model; 
    private ushort? idleHours; 
    private ushort? talkHours; 
    private BatteryType? batteryType; /* 3 */

    //Properties
    /* 5 */
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public ushort? IdleHours
    {
        get
        {
            return this.idleHours;
        }
        set
        {
            if (value < 0)
            {
                 throw new ArgumentOutOfRangeException("idleHours", "idleHours must be a greater than zero");
            }
            this.idleHours = value;
        }
    }

    public ushort? TalkHours
    {
        get
        {
            return this.talkHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("talkHours", "talkHours must be a greater than zero");
            }
            this.talkHours = value;
        }
    }

    public BatteryType? BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            this.batteryType = value;
        }
    }

    //Constructors
    /* 2 */
    public Battery(string model, ushort? idleHours, ushort? talkHours, BatteryType? batteryType)
    {
        this.Model = model;
        this.IdleHours = idleHours;
        this.TalkHours = talkHours;
        this.BatteryType = batteryType;
    }

    public Battery(string model) 
        : this(model, null, null, null)
    {
    }

    //Methods
    /* 4 */
    public override string ToString()
    {
        return string.Format("Model: {0}, IdleHours: {1}, TalkHours: {2}, BatteryType: {3}",
            Model == null ? "null" : Model.ToString(),
            IdleHours == null ? "null" : IdleHours.ToString() + "h",
            TalkHours == null ? "null" : TalkHours.ToString() + "h",
            BatteryType == null ? "null" : BatteryType.ToString());
    }
}
