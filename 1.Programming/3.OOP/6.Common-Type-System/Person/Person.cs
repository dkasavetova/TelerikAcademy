using System;

public class Person
{
    //Fields
    private string name;
    public int? Age { get; set; }

    //Properties
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("name", "value must not be null");
            }
            this.name = value;
        }
    }

    //Constructors
    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    //Methods
    public override string ToString()
    {
        return string.Format(
            "Name: {0}; Age: {1}",  
            this.name, 
            (this.Age.HasValue == true) ? this.Age.Value.ToString() : "[unknown]");
    }
}

