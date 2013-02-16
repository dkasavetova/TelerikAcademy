using System;
using System.Text;

class UppercaseTag
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(ToUppercaseByTag(text));
    }

    static string ToUppercaseByTag(string text)
    {
        StringBuilder sb = new StringBuilder(text.Length);

        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        for (int i = 0; i < text.Length; i++)
        {
            //find the start index of the substring witch will be made uppercase
            int j = text.IndexOf(openTag, i);
            if (j >= 0)
            {
                sb.Append(text.Substring(i, j - i));

                j += openTag.Length;

                //find the end index of the substring witch will be made uppercase
                int k = text.IndexOf(closeTag, j);
                if (k >= 0)
                {
                    //make the substing [j, k] to uppercase
                    sb.Append(text.Substring(j, k - j).ToUpper());
                    //start the search for next opening tag from the position of the end of the 
                    //last found closing tag -1 because it will be incremented in the for loop
                    i = k + closeTag.Length - 1;
                }
            }
            else
            {
                //no opening tags left
                sb.Append(text.Substring(i, text.Length - i));
                break;
            }
        }
        return sb.ToString();
    }
}

