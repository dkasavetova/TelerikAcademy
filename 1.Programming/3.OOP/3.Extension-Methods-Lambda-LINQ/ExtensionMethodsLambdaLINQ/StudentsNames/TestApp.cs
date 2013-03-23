using System;
using System.Linq;

class TestApp
{
    static void Main()
    {
        Student[] students = new Student[] 
        {
            new Student() { FirstName = "Aa", LastName = "Cc", Age = 30 },
            new Student() { FirstName = "Aa", LastName = "Bb", Age = 26 },
            new Student() { FirstName = "Cc", LastName = "Aa", Age = 19 },
            new Student() { FirstName = "Ee", LastName = "Ff", Age = 21 }
        };

        Console.WriteLine("All students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();


        //03
        Student[] selected = Student.GetStudents(students);

        Console.WriteLine("Students whose first name is before its last name alphabetically:");
        foreach (var student in selected)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();


        //04
        var studentsBetween18And24 =
            from stud in students
            where stud.Age >= 18 && stud.Age <= 24
            select new {FirstName = stud.FirstName, LastName = stud.LastName};

        Console.WriteLine("The first name and last name of all students with age between 18 and 24:");
        foreach (var item in studentsBetween18And24)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        //05 - extension methods
        var sortedStudents = 
            students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

        Console.WriteLine("Sorted students by first name and last name in descending order:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        //05 - LINQ
        var sortedStudentsLinq =
            from stud in students
            orderby stud.FirstName descending, stud.LastName descending
            select stud;

        Console.WriteLine("Sorted students by first name and last name in descending order:");
        foreach (var student in sortedStudentsLinq)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();
    }
}

