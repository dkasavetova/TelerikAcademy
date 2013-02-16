using System;

class QuotationMarks
{
    static void Main()
    {
        string normalString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(normalString);
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedString);
    }
}

