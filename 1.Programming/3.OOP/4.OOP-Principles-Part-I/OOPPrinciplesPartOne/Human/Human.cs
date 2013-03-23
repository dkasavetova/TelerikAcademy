public abstract class Human
{
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Constructors
    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}

