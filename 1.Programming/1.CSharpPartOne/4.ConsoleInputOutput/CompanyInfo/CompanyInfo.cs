using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company information\n");

        Console.Write("Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Fax: ");
        string companyFax = Console.ReadLine();

        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("\nEnter manager information\n");

        Console.Write("First name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.Write("Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(
            "Company:\n" +
                "Name: {0}\n" +
                "Address: {1}\n" +
                "Fax: {2}\n" +
                "Web Site: {3}\n" +
                "Manager:\n" +
                "First Name: {4}\n" +
                "Last Name: {5}\n" +
                "Age: {6}\n" +
                "Phone: {7}",
            companyName, companyAddress, companyFax, companyWebSite,
            managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

