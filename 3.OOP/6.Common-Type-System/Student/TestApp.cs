using System;

class TestApp
{
    static void Main()
    {
        Student firstStud = new Student()
        {
            FirstName = "First",
            MiddleName = "Middle",
            LastName = "Last",
            SSN = 222334444,
            PermanentAddress = "Address",
            MobilePhone = "555-123",
            Email = "First.Last@domain.com",
            Course = 1,
            Specialty = Specialty.ComputerScience,
            Univercity = University.Stanford,
            Faculty = Faculty.Engineering
        };

        Student secondStud = new Student()
        {
            FirstName = "John",
            MiddleName = "",
            LastName = "Doe",
            SSN = 111223333,
            PermanentAddress = "homeless",
            MobilePhone = "555-000",
            Email = "John.Doe@domain.com",
            Course = 1,
            Specialty = Specialty.ComputationalBiology,
            Univercity = University.MIT,
            Faculty = Faculty.Engineering
        };

        Student sameAsFirstStudent = firstStud.Clone();

        // == test
        if (firstStud == secondStud)
        {
            Console.WriteLine("first == second");
        }
        else
        {
            Console.WriteLine("first != second");
        }

        if (firstStud == sameAsFirstStudent)
        {
            Console.WriteLine("first == sameAsFirst");
        }
        else
        {
            Console.WriteLine("first != sameAsFirst");
        }

        // CompareTo test
        int cmp = firstStud.CompareTo(secondStud);
        if (cmp == 0)
        {
            Console.WriteLine("first == second");
        }
        else if (cmp < 0)
        {
            Console.WriteLine("first < second");
        }
        else
        {
            Console.WriteLine("first > second");
        }

        Console.WriteLine(firstStud);
    }
}

