using System;

class TestApp
{
    static void Main()
    {
        Student stud1 = new Student("Mario", 1);
        Student stud2 = new Student("Batman", 4);
        Student stud3 = new Student("Optimus  Prime", 3);
        Student[] students = new Student[] { stud1, stud2, stud3};

        Discipline disp1 = new Discipline("OOP", 40, 40);

        Teacher teach1 = new Teacher("Morgan Freeman", new Discipline[] { disp1 });
        Teacher[] teachers = new Teacher[] {teach1};

        Class class1 = new Class(students, teachers, "12A");

        Console.Write("The name of the first discipline of the first teacher of the first class: ");
        Console.WriteLine(class1.Teachers[0].Disciplines[0].Name);


        stud1.AddComment("ninja");
        Console.Write("The first comment for the first studdent: ");
        Console.WriteLine(stud1.Comments[0]);
    }
}

