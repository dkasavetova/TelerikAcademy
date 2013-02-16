using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractDate
{
    static void Main()
    {
        string text = "12.34.3333 dfdf 12.01.2002";

        string[] dates = ExtractDates(text);

        for (int i = 0; i < dates.Length; i++)
        {
            //TODO: Do it with DateTime.TryParseExact
            try
            {
                string[] d = dates[i].Split('.');
                DateTime dt = new DateTime(int.Parse(d[2]), int.Parse(d[1]), int.Parse(d[0]));
                Console.WriteLine("{0:yyyy-MM-dd}", dt);
            }
            catch (ArgumentOutOfRangeException)
            {
                //Keep Calm And Don't Print dt
            }

        }
    }

    static string[] ExtractDates(string text)
    {
        const string MatchEmailPattern = @"\d\d.\d\d.\d\d\d\d";

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

