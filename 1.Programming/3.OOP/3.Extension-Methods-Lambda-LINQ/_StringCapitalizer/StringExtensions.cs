using System.Globalization;

/// <summary>
/// Extension methods for the String class
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Captitalizes the first letters of every word of a given string;
    /// </summary>
    public static string ToTitleFormat(this string str) 
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    }
}

