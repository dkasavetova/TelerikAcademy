public class Worker
    :Human
{
    //Fields
    private decimal weekSalary;
    private int workHoursPerDay;

    //Properties
    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            this.workHoursPerDay = value;
        }
    }

    //Constructors
    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    

    //Methods
    public decimal MoneyPerHour()
    {
        int workingDaysPerWeek = 5;
        return weekSalary / (workHoursPerDay * workingDaysPerWeek);
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " " + MoneyPerHour().ToString("C");
    }
}

