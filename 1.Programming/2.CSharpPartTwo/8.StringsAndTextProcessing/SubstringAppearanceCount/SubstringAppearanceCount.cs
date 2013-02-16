using System;

class SubstringAppearanceCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        string substring = Console.ReadLine();

        Console.WriteLine(SubstringCount(substring, text));
    }

    static int SubstringCount(string substring, string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            int j = text.IndexOf(substring, i, 
                StringComparison.InvariantCultureIgnoreCase);
            if (j >= 0)
            {
                count++;
                i = j + substring.Length - 1;
            }
        }

        return count;
    }
}

