using System;
using System.Text;

class EncriptionXOR
{
    static void Main()
    {
        string text = "blablabla";
        string key = "1337";

        string encoded = Encode(text, key);
        string decoded = Decode(encoded, key);

        Console.WriteLine(text);
        Console.WriteLine(encoded);
        Console.WriteLine(decoded);
    }

    static string Encode(string text, string key)
    {
        StringBuilder sb = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            sb.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return sb.ToString();
    }

    static string Decode(string encodedText, string key) 
    {
        return Encode(encodedText, key);
    }
}

