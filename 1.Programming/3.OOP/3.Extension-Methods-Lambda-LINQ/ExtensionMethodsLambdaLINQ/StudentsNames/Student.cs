using System.Linq;

public class Student
{
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //Methods
    /// <summary>
    /// Gets the students whose first name is before its last name alphabetically.
    /// </summary>
    public static Student[] GetStudents(Student[] arr) //03
    {
        //var students = arr.Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToArray();
        //return students;

        var students =
            from stud in arr
            where stud.FirstName.CompareTo(stud.LastName) < 0
            select stud;
        return students.ToArray();
    }

    
    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Age;
    }
}

