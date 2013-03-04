using System.Text;

/// <summary>
/// Contains extension methods for the StringBuilderClass
/// </summary>
public static class StringBuilderExtensions
{
    /// <summary>
    /// Retrieves a substring from this instance.
    /// </summary>
    /// <param name="index">The starting index of the substring</param>
    /// <param name="length">The lengthe of the substring</param>
    public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length) 
    {
        StringBuilder newStrBuilder = new StringBuilder();

        for (int i = index; i < index + length; i++)
        {
            newStrBuilder.Append(strBuilder[i]);
        }

        return newStrBuilder;
    }
}

