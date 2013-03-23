using System.Collections.Generic;

public class Discipline : ICommentable
{
    //Fields
    private string name;
    private int lecturesCount;
    private int exercisesCount;
    private List<string> comments;

    //Properties
    /// <summary>
    /// Gets or sets the name of a discipline
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

    /// <summary>
    /// Gets or sets the number of lectures for discipine
    /// </summary>
    public int LecturesCount
    {
        get
        {
            return this.lecturesCount;
        }
        set
        {
            this.lecturesCount = value;
        }
    }

    /// <summary>
    /// Gets or sets the number of exercises for discipline
    /// </summary>
    public int ExercisesCount
    {
        get
        {
            return this.exercisesCount;
        }
        set
        {
            this.exercisesCount = value;
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

    //Constructors
    /// <summary>
    /// Create new discipline
    /// </summary>
    /// <param name="name">Discipline's name</param>
    /// <param name="lecturesCount">Number of lectures</param>
    /// <param name="exercisesCount">Number of exercises</param>
    public Discipline(string name, int lecturesCount, int exercisesCount)
    {
        this.Name = name;
        this.LecturesCount = lecturesCount;
        this.ExercisesCount = exercisesCount;
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

