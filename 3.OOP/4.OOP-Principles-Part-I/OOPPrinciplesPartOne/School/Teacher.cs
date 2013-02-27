using System.Collections.Generic;

public class Teacher : Human, ICommentable
{
    //Fields
    private List<Discipline> disciplines;
    private List<string> comments;

    //Properties
    /// <summary>
    /// Gets an array of the disciplines a given teacher teaches
    /// </summary>
    public Discipline[] Disciplines
    {
        get
        {
            return this.disciplines.ToArray();
        }
        private set 
        {
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
    /// Create new teacher
    /// </summary>
    /// <param name="name">The name of the teacher</param>
    /// <param name="disciplines">Array of the disciplines the teacher can teach</param>
    public Teacher(string name, Discipline[] disciplines)
        :base(name)
    {
        this.disciplines = new List<Discipline>(disciplines);
        this.comments = new List<string>();
    }

    //Methods
    /// <summary>
    /// Add new discipline that given teacher can teach
    /// </summary>
    public void AddDiscipline(Discipline discipline) 
    {
        this.disciplines.Add(discipline);
    }

    /// <summary>
    /// Removes a discipline from a teachers list
    /// </summary>
    /// <param name="discipline"></param>
    public void RemoveDiscipline(Discipline discipline)
    {
        this.disciplines.Remove(discipline);
    }

    /// <summary>
    /// Add comment
    /// </summary>
    public void AddComment(string comment)
    {
        this.comments.Add(comment);
    }
}

