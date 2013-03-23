public class Student : Human
{
    //Properties
    public int Grade { get; set; }

    //Constructors
    public Student(string firstName, string lastName, int grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    //Methods
    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Grade;
    }
}

