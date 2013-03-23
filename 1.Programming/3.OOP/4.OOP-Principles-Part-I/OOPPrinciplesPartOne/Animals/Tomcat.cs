public class Tomcat : Cat
{
    public override Gender Gender
    {
        get
        {
            return base.Gender;
        }
    }

    public Tomcat(string name, int age)
        :base(name, age, Gender.Male)
    {
    }
}
