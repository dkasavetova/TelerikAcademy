using System;

public abstract class Animal : ISound
{
    //Fields
    private string name;
    private int age;

    //Properties
    public virtual Gender Gender { get; set; }

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
                throw new ArgumentNullException("name");
            }
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentOutOfRangeException("name must be between 3 and 30 symbols long"); 
            }

            this.name = value;
        }
    }
    
    public int Age 
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("age must be a positive integer or zero"); 
            }

            this.age = value;
        }
    }

    //Constructors
    public Animal(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    //Methods
    public abstract string MakeSound();
}

