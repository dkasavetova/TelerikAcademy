using System;
using System.Text;

class TestApp
{
    static void Main()
    {
        StringBuilder strBuilder = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            strBuilder.Append(i);
        }

        //strBuilder = 0123456789 -> substring(2,5) = 23456

        StringBuilder substr = strBuilder.Substring(2, 5);

        Console.WriteLine(substr.ToString()); 
    }
}

