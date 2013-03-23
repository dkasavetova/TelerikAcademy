public class Kitten : Cat
{
    public override Gender Gender
    {
        get
        {
            return base.Gender;
        }
    }

    public Kitten(string name, int age)
        :base(name, age, Gender.Female)
    {
    }
}

