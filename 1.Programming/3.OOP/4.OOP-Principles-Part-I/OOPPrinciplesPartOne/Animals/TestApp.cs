using System;
using System.Collections.Generic;

class TestApp
{
    static void Main()
    {
        Dog[] dogs = new Dog[] 
        {
            new Dog("Sharo", 5, Gender.Male),
            new Dog("Rex", 8, Gender.Male)
        };

        Frog[] frogs = new Frog[] 
        {
            new Frog("Grogo", 1, Gender.Male),
            new Frog("Frogina", 3, Gender.Female)
        };

        Kitten[] kittens = new Kitten[]
        {
            new Kitten("Fluffy", 5),
            new Kitten("Patrisha", 2)
        };

        Tomcat[] tomcats = new Tomcat[] 
        {
            new Tomcat("Tom", 3),
            new Tomcat("Johnny", 5)
        };

        List<Animal[]> animals = new List<Animal[]>();
        animals.Add(dogs);
        animals.Add(frogs);
        animals.Add(kittens);
        animals.Add(tomcats);

        Console.WriteLine("Average age by animal type:");
        foreach (var animalArray in animals)
        {
            Console.WriteLine("{0}:\t{1};", 
                animalArray[0].GetType(), //assumes non-empty arrays
                GetAverageAge(animalArray));
        }
    }

    
    static double GetAverageAge(Animal[] animals)
    {
        double sumAge = 0;
        foreach (var animal in animals)
        {
            sumAge += animal.Age;
        }
        double averageAge = sumAge / animals.Length;
        return averageAge;
    }



}


