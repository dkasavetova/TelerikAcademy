using System;
using System.Text.RegularExpressions;

class ReplaceTagWithBBCode
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com\"">our site</a> " +
            @"to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        Console.WriteLine(RepaceATag(text));
    }

    static string RepaceATag(string text)
    {
        string pattern = @"<a href=""(?<url>[^\]]*?)"">(?<content>(.|\s)*?)</a>";
        string newPattern = @"[URL=""${url}""]${content}[/URL]";
        string result = Regex.Replace(text, pattern, newPattern);
        return result;
    }
}

