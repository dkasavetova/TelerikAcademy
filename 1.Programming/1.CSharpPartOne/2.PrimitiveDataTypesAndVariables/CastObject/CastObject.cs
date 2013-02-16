using System;

class CastObject
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object concatinationObj = firstWord + " " + secondWord;
        string concatinationStr = (string)concatinationObj;
        Console.WriteLine(concatinationStr);
    }
}

