using System.Collections.Generic;

public class School
{
    //Fields
    private List<Class> classes;

    //Properties
    /// <summary>
    /// Gets an array of all classes in a school
    /// </summary>
    public Class[] Classes
    {
        get
        {
            return this.classes.ToArray();
        }
        private set 
        {
        }
    }

    //Constructors
    /// <summary>
    /// Create new School
    /// </summary>
    /// <param name="classes">Array of the classes in the school</param>
    public School(Class[] classes)
    {
        this.classes = new List<Class>(classes);
    }

    //Methods
    /// <summary>
    /// Adds a class to a school
    /// </summary>
    public void AddClass(Class @class) 
    {
        this.classes.Add(@class);
    }

    /// <summary>
    /// Removes a class from a school
    /// </summary>
    public void RemoveClass(Class @class) 
    {
        this.classes.Remove(@class);
    }
}

