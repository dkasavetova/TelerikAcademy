using System;
using System.Collections.Generic;

class EvalExpression
{
    static void Main()
    {
        string exp = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";

        Console.WriteLine(exp);
        List<string> rpn =  ExpressionEvaluator.RPN(exp);
        foreach (var item in rpn)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(ExpressionEvaluator.Evaluate(exp));
    }
}
