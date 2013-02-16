using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main()
    {
        string text = "blabla bla ivan@yahoo.com bla bla admin@gmail.com";

        string[] emails = ExtractEmails(text);

        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }

    static string[] ExtractEmails(string text)
    {
        const string MatchEmailPattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" +
           @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." +
           @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" +
           @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

        Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        MatchCollection matches = rx.Matches(text);

        string[] results = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
		{
			results[i] = matches[i].Value.ToString();
		}

        return results;
    }
}

