using System;
using System.Collections.Generic;

class CheckBracketCorrectness
{
    static void Main()
    {
        string expression = Console.ReadLine();

        Console.WriteLine(CheckBrackets(expression));
    }

    static bool CheckBrackets(string expression)
    {
        Stack<bool> stack = new Stack<bool>();

        foreach (var ch in expression)
        {
            if (ch == '(')
            {
                stack.Push(true);
            }
            else if (ch == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        if (stack.Count != 0)
        {
            return false;
        }

        return true;
    }
}

