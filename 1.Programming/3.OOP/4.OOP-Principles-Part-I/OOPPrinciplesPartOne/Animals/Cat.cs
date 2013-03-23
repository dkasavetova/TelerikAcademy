public abstract class Cat : Animal
{
    public Cat(string name, int age, Gender gender)
        : base(name, age, gender)
    {
    }

    public override string MakeSound()
    {
        return "Mew";
    }
}

