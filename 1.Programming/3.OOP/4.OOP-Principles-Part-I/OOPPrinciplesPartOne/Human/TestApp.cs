using System;
using System.Collections.Generic;
using System.Linq;

class TestApp
{
    static void Main()
    {
        Student[] students = new Student[]
        {
            new Student("Jim", "Raynor", 10),
            new Student("Sarah", "Kerrigan", 10),
            new Student("Arcturus", "Mengsk", 8),
            new Student("Valerian", "Mengsk", 12),
            new Student("Kate ", "Lockwell", 3),
            new Student("Edmund ", "Duke", 7),
            new Student("Samir", "Duran", 1),
            new Student("Alexei", "Stukov", 11),
            new Student("Tychus", "Findlay", 2),
            new Student("Nova", "Terra", 9),
        };

        Student[] sortedStudents = students.OrderBy(x => x.Grade).ToArray();

        Console.WriteLine("Students sorted by grade:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();


        Worker[] workers = new Worker[]
        {
            new Worker("Michael", "Charles", 200M, 2),
            new Worker("James", "Gray", 430M, 8),
            new Worker("Ronald", "Frank", 500M, 6),
            new Worker("Harry", "Tyler", 320M, 4),
            new Worker("Steven", "Clarke", 800M, 12),
            new Worker("Mary", "Carter", 500M, 4),
            new Worker("Emily", "Richard", 800M, 8),
            new Worker("Linda", "Williams", 400M, 6),
            new Worker("Ashley", "Rose", 10M, 1),
            new Worker("Lisa", "Mark", 540M, 12),
        };

        Worker[] sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToArray();

        Console.WriteLine("Workers sorted by money per hour:");
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker);
        }
        Console.WriteLine();

        List<Human> humans = new List<Human>(students);
        humans.AddRange(workers);
        List<Human> sortedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

        Console.WriteLine("Humans sorted by name:");
        foreach (var human in sortedHumans)
        {
            Console.WriteLine(human);
        }
        Console.WriteLine();
    }
}

