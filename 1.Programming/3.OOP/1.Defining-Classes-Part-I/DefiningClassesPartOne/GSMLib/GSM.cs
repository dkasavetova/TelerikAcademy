using System;
using System.Collections.Generic;
using System.Linq;

public class GSM
{
    //Fields
    /* 1 */
    private string model; 
    private string manufacturer; 
    private decimal? price; 
    private string owner; 
    private Battery battery; 
    private Display display;

    //Properties
    /* 9 */
    public List<Call> CallHistory { get; set; } 

    /* 6 */
    public static GSM IPhone4S
    {
        get
        {
            return new GSM(
                "iPhone 4S", "Apple", 579.99M, "Hipster",
                new Battery("iBattery", 200, 14, BatteryType.LiPo),
                new Display(3.5, 16000000));
        }
        private set { }
    }

    /* 5 */
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value != null && value.Length < 3)
            {
                throw new ArgumentException("value must be at least 3 characters long", "model");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value != null && value.Length < 3)
            {
                throw new ArgumentException("value must be at least 3 characters long", "manufacturer");
            }
            this.manufacturer = value;
        }
    }

    public decimal? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("price", "value must be a positive");
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value != null && value.Length < 3)
            {
                throw new ArgumentException("value must be at least 3 characters long", "owner");
            }
            this.owner = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public Display Display
    {
        get
        {
            return this.display;
        }
        set
        {
            this.display = value;
        }
    }

    //Constructors
    /* 2 */
    public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;

        this.CallHistory = new List<Call>();
    }

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price)
        : this(model, manufacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    {
    }

    //Methods
    public override string ToString()
    {
       
        return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, Battery: [{4}], Display: [{5}]",
            Model == null ? "null" : Model.ToString(),
            Manufacturer == null ? "null" : Manufacturer.ToString(),
            Price == null ? "null" : "$" + Price.ToString(),
            Owner == null ? "null" : Owner.ToString(),
            Battery == null ? "null" : Battery.ToString(),
            Display == null ? "null" : Display.ToString());
    }

    /* 10 */
    public void AddCall(Call call)
    {
        this.CallHistory.Add(call);
    }

    public void RemoveCall(Call call)
    {
        this.CallHistory.Remove(call);
    }

    public void ClearCallHistory() 
    {
        this.CallHistory.Clear();
    }

    /* 11 */
    public decimal CalculateCallsPrice(decimal pricePerMinute)
    {
        long totalCallsDuration = this.CallHistory.Sum(x => x.Duration);
        decimal totalCallsPrice = (totalCallsDuration / 60.0M) * pricePerMinute;
        return totalCallsPrice;
    }
  
}

