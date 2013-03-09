using System;

class TestApp
{
    static void Main()
    {
        Person withAge = new Person("First", 20);
        Person withoutAge = new Person("Second");

        Console.WriteLine(withAge);

        Console.WriteLine(withoutAge);
    }
}

