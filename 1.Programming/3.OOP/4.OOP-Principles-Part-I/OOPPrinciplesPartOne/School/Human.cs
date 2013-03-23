public class Human
{
    //Fields
    private string name;

    //Properties
    /// <summary>
    /// Gets or sets the name of a human
    /// </summary>
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    //Constructors
    /// <summary>
    /// Create new human
    /// </summary>
    /// <param name="name">The name of the human</param>
    public Human(string name)
    {
        this.Name = name;
    }
}

