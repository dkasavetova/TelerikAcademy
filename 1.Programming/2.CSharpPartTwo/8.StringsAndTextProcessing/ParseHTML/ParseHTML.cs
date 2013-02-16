using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ParseHTML
{
    static void Main()
    {
        string html =
        @"<html> " +
          @"<head><title>News</title></head> " +
          @"<body><p><a href=""http://academy.telerik.com"">Telerik " +
            @"Academy</a>aims to provide free real-world practical " +
            @"training for young people who want to turn into " +
            @"skillful .NET software engineers.</p></body> " +
        @"</html >";

        Console.WriteLine(GetBodyAndTitleTextFromHTML(html));
    }

    static string GetBodyAndTitleTextFromHTML(string html)
    {
        return Regex.Replace(html, "<.*?>", "");
    }
}

