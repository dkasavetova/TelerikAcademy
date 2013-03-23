using System.Collections.Generic;

public class Student : Human, ICommentable
{
    //Fields
    private int numberInClass;
    private List<string> comments;

    //Properties
    /// <summary>
    /// Gets or sets the number in class of a student
    /// </summary>
    public int NumberInClass
    {
        get
        {
            return this.numberInClass;
        }
        set
        {
            this.numberInClass = value;
        }
    }

    /// <summary>
    /// Get the comments for a student
    /// </summary>
    public string[] Comments
    {
        get
        {
            return this.comments.ToArray();
        }
    }

    //Constuctors
    /// <summary>
    /// Create new students
    /// </summary>
    /// <param name="name">Name of the student</param>
    /// <param name="numberInClass">The number in class</param>
    public Student(string name, int numberInClass)
        : base(name)
    {
        this.NumberInClass = numberInClass;
        this.comments = new List<string>();
    }

    //Methods
    /// <summary>
    /// Add comment
    /// </summary>
    public void AddComment(string comment)
    {
        this.comments.Add(comment);
    }
}

