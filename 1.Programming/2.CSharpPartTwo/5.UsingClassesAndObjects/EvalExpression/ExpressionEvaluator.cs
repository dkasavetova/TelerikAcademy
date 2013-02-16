using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExpressionEvaluator
{
    public static List<string> RPN(string expression)
    {
        TokenizeExpression(expression);
        MinimizeExpression(tokenizedExp);
        EncodeOperators(tokenizedExp);
        EncodeFunctions(tokenizedExp);
        List<string> postfixExp = ShuntingYardRPN(tokenizedExp);
        DecodeOperators(postfixExp);
        DecodeFunctions(postfixExp);
        return postfixExp;
    }

    public static double Evaluate(string expression)
    {
        TokenizeExpression(expression);
        MinimizeExpression(tokenizedExp);
        EncodeOperators(tokenizedExp);
        EncodeFunctions(tokenizedExp);
        double result = ShuntingYardEval(tokenizedExp);
        return result;
    }



    static List<string> tokenizedExp = new List<string>();

    static void PrintTokenizedExpression()
    {
        foreach (var item in tokenizedExp)
        {
            Console.WriteLine(item);
        }
    }

    static Operator[] operators = 
    {
        new Operator(0, "(", 1000, Associaivity.Left),
        new Operator(1, ")", 1000, Associaivity.Left),
        new Operator(2, "-", 900, Associaivity.Right, Arity.Unary),
        new Operator(3, "*", 500, Associaivity.Left),
        new Operator(4, "/", 500, Associaivity.Left),
        new Operator(5, "+", 400, Associaivity.Left),
        new Operator(6, "-", 400, Associaivity.Left),
        new Operator(7, ",", 0, Associaivity.Left),
    };

    static Function[] functions = 
    {
        new Function(0, "pow", 2),
        new Function(1, "ln", 1),
        new Function(2, "sqrt", 1),
    };

    static bool IsOperator(string symbol)
    {
        //TODO: Make it BinarySearch
        foreach (var op in operators)
        {
            if (op.Symbol == symbol || ("$" + op.ID) == symbol)
            {
                return true;
            }
        }
        return false;
    }

    static bool IsFunction(string symbol)
    {
        //TODO: Make it BinarySearch
        foreach (var fn in functions)
        {
            if (fn.Name == symbol || ("$$" + fn.ID) == symbol)
            {
                return true;
            }
        }
        return false;
    }

    static bool IsNumber(string symbol, out double number)
    {
        return double.TryParse(symbol, out number);
    }

    static bool IsFuncionArgumentSeparator(string symbol)
    {
        if ("," == symbol || "$7" == symbol)
        {
            return true;
        }
        return false;
    }

    static bool IsLeftParenthesis(string symbol)
    {
        if ("(" == symbol || "$0" == symbol)
        {
            return true;
        }
        return false;
    }

    static bool IsRightParenthesis(string symbol)
    {
        if (")" == symbol || "$1" == symbol)
        {
            return true;
        }
        return false;
    }

    static Associaivity GetAssociativity(string opStr)
    {
        //only change sign operator is right associative
        if (opStr == "$2")
        {
            return Associaivity.Right;
        }
        else
        {
            return Associaivity.Left;
        }
    }

    static Operator GetOperator(string opEncStr)
    {
        foreach (var op in operators)
        {
            if ("$" + op.ID == opEncStr)
            {
                return op;
            }
        }
        return null;
    }

    static Function GetFunction(string fnEncStr)
    {
        foreach (var fn in functions)
        {
            if ("$$" + fn.ID == fnEncStr)
            {
                return fn;
            }
        }
        return null;
    }

    static int GetPrecedence(string opStr) 
    {
        int opId = int.Parse(opStr.Substring(1));

        return operators[opId].Priority;
    }


    static List<string> ShuntingYardRPN(List<string> tokenizedExp)
    {
        Queue<string> valQueue = new Queue<string>();
        Stack<string> opStack = new Stack<string>();

        for (int i = 0; i < tokenizedExp.Count; i++) //While there are tokens to be read:
        {
            string token = tokenizedExp[i];
            double value;
            if (double.TryParse(token, out value))
            {
                valQueue.Enqueue(token);
            }
            else if (IsFunction(token))
            {
                opStack.Push(token);
            }
            else if(IsFuncionArgumentSeparator(token))
            {
                while (!IsLeftParenthesis(opStack.Peek()))
                {
                    valQueue.Enqueue(opStack.Pop());
                }
            }
            else if (IsOperator(token))
            {
                if (IsLeftParenthesis(token))
                {
                    opStack.Push(token);
                }
                else if (IsRightParenthesis(token))
                {
                    
                    while (opStack.Count > 0 && !IsLeftParenthesis(opStack.Peek()))
                    {
                        valQueue.Enqueue(opStack.Pop());
                    }
                    opStack.Pop();
                    if (opStack.Count > 0 && IsFunction(opStack.Peek()))
                    {
                         valQueue.Enqueue(opStack.Pop());
                    }
                }
                else
                {
                    if ((opStack.Count == 0 || GetPrecedence(token) > GetPrecedence(opStack.Peek())))
                    {
                        opStack.Push(token);
                    }
                    else
                    {
                        while (opStack.Count > 0 &&  !IsLeftParenthesis(opStack.Peek()) && 
                            !IsRightParenthesis(opStack.Peek()) && 
                            GetPrecedence(token) <= GetPrecedence(opStack.Peek()))
                        {
                            valQueue.Enqueue(opStack.Pop());
                        }
                        opStack.Push(token);
                    }
                }
            }
        }
        while (opStack.Count > 0)
        {
            valQueue.Enqueue(opStack.Pop());
        }
        return valQueue.ToList();
    }

    static double ShuntingYardEval(List<string> tokenizedExp)
    {
        Stack<double> valStack = new Stack<double>();
        Stack<string> opStack = new Stack<string>();

        for (int i = 0; i < tokenizedExp.Count; i++) //While there are tokens to be read:
        {
            string token = tokenizedExp[i];
            double value;
            if (double.TryParse(token, out value))
            {
                valStack.Push(value);
            }
            else if (IsFunction(token))
            {
                opStack.Push(token);
            }
            else if (IsFuncionArgumentSeparator(token))
            {
                while (!IsLeftParenthesis(opStack.Peek()))
                {
                    string top = opStack.Pop();
                    if (IsOperator(top))
                    {
                        OperatorCalc(valStack, top);
                    }
                    else
                    {
                        FunctionCalc(valStack, top);
                    }
                    
                    //valStack.Enqueue(opStack.Pop());
                }
            }
            else if (IsOperator(token))
            {
                if (IsLeftParenthesis(token))
                {
                    opStack.Push(token);
                }
                else if (IsRightParenthesis(token))
                {

                    while (opStack.Count > 0 && !IsLeftParenthesis(opStack.Peek()))
                    {
                        string top = opStack.Pop();
                        if (IsOperator(top))
                        {
                            OperatorCalc(valStack, top);
                        }
                        else
                        {
                            FunctionCalc(valStack, top);
                        }
                    }
                    opStack.Pop();
                    if (opStack.Count > 0 && IsFunction(opStack.Peek()))
                    {
                        string top = opStack.Pop();
                        if (IsOperator(top))
                        {
                            OperatorCalc(valStack, top);
                        }
                        else
                        {
                            FunctionCalc(valStack, top);
                        }
                        //should it be only FuncCalc???
                    }
                }
                else
                {
                    if ((opStack.Count == 0 || GetPrecedence(token) > GetPrecedence(opStack.Peek())))
                    {
                        opStack.Push(token);
                    }
                    else
                    {
                        while ((opStack.Count > 0 && !IsLeftParenthesis(opStack.Peek()) && !IsRightParenthesis(opStack.Peek()) && GetPrecedence(token) <= GetPrecedence(opStack.Peek())))
                        {
                            string top = opStack.Pop();

                            OperatorCalc(valStack, top);
                        }
                        opStack.Push(token);
                    }
                }
            }
        }
        while (opStack.Count > 0)
        {
            string top = opStack.Pop();
            if (IsOperator(top))
            {
                OperatorCalc(valStack, top);

            }
            else
            {
                FunctionCalc(valStack, top);
            }
        }
        return valStack.Pop();
    }

    static void OperatorCalc(Stack<double> vals, string opStr)
    {
        Operator op = GetOperator(opStr);

        double arg0 = -1, arg1 = -1;
        if (op.Arity == Arity.Unary)
        {
		    arg0 = vals.Pop();
        }
        else 
        {
		    arg0 = vals.Pop();
            arg1 = vals.Pop();
        }

        switch (op.ID)
        {
            case 2:
                vals.Push(-arg0);
                break;
            case 3:
                vals.Push(arg0 * arg1);
                break;
            case 4:
                vals.Push(arg1 / arg0);
                break;
            case 5:
                vals.Push(arg0 + arg1);
                break;
            case 6:
                vals.Push(arg1 - arg0); 
                break;
            default:
                Console.WriteLine("Error!!! Invalid operator reached!");
                break;
        }
    }

    static void FunctionCalc(Stack<double> vals, string fnStr)
    {
        Function fn = GetFunction(fnStr);

        double arg0 = -1, arg1 = -1;
        if (fn.ParametersCount == 1)
        {
            arg0 = vals.Pop();
        }
        else
        {
            arg0 = vals.Pop();
            arg1 = vals.Pop();
        }

        switch (fn.ID)
        {
            case 0:
                vals.Push(Math.Pow(arg1, arg0)); 
                break;
            case 1:
                vals.Push(Math.Log(arg0));
                break;
            case 2:
                vals.Push(Math.Sqrt(arg0));
                break;
            default:
                Console.WriteLine("Error!!! Invalid operator reached!");
                break;
        }
    }

    static string DecodeOperator(string op)
    {
        for (int j = 0; j < operators.Length; j++)
        {
            if ("$" + operators[j].ID == op)
            {
                return operators[j].Symbol;
            }
        }
        return null;
    }

    static void EncodeOperators(List<string> tokenizedExp)
    {
        for (int i = 0; i < tokenizedExp.Count; i++)
        {
            for (int j = 0; j < operators.Length; j++)
            {
                if (operators[j].Symbol == tokenizedExp[i])
                {
                    if (tokenizedExp[i] == "-")
                    {
                        if ((i - 1 >= 0 && IsOperator(tokenizedExp[i - 1]) && !IsRightParenthesis(tokenizedExp[i -1])) || i == 0)
                        {
                            tokenizedExp[i] = "$2";
                        }
                        else
                        {
                            tokenizedExp[i] = "$6";
                        }
                    }
                    else
                    {
                        tokenizedExp[i] = "$" + operators[j].ID;
                    }
                }
            }
        }
    }

    static void DecodeOperators(List<string> postfixExp)
    {
        for (int i = 0; i < postfixExp.Count; i++)
        {
            for (int j = 0; j < operators.Length; j++)
            {
                if ("$" + operators[j].ID == postfixExp[i])
                {
                    postfixExp[i] = operators[j].Symbol;
                }
            }
        }
    }

    static void EncodeFunctions(List<string> tokenizedExp)
    {
        for (int i = 0; i < tokenizedExp.Count; i++)
        {
            for (int j = 0; j < functions.Length; j++)
            {
                if (functions[j].Name == tokenizedExp[i])
                {
                    tokenizedExp[i] = "$$" + functions[j].ID;
                }
            }
        }
    }

    static void DecodeFunctions(List<string> postfixExp)
    {
        for (int i = 0; i < postfixExp.Count; i++)
        {
            for (int j = 0; j < functions.Length; j++)
            {
                if ("$$" + functions[j].ID == postfixExp[i])
                {
                    postfixExp[i] = functions[j].Name;
                }
            }
        }
    }

    static void TokenizeExpression(string exp)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < exp.Length; i++)
        {
            if (IsOperator(exp[i].ToString()))
            {
                sb.Append(" ");
                sb.Append(exp[i]);
                sb.Append(" ");
            }
            else
            {
                sb.Append(exp[i]);
            }

        }
        //sprit the elements of the expression
        tokenizedExp = sb.ToString().Split(
            new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    static void MinimizeExpression(List<string> tokenizedExp)
    {
        //remove extra + and -
        for (int i = 0; i < tokenizedExp.Count; i++)
        {
            if (tokenizedExp[i] == "+")
            {
                if (tokenizedExp[i + 1] == "+")
                {
                    tokenizedExp.RemoveAt(i + 1);
                    i--;
                }
                else if (tokenizedExp[i + 1] == "-")
                {
                    tokenizedExp.RemoveAt(i);
                    i--;
                }
            }
            else if (tokenizedExp[i] == "-")
            {
                if (tokenizedExp[i + 1] == "+")
                {
                    tokenizedExp.RemoveAt(i + 1);
                    i--;
                }
                else if (tokenizedExp[i + 1] == "-")
                {
                    tokenizedExp[i] = "+";
                    tokenizedExp.RemoveAt(i + 1);
                    i--;
                }
            }
        }
    }

    
}

class OperatorComparer : IComparer<Operator>
{
    public int Compare(Operator x, Operator y)
    {
        return string.Compare(x.Symbol, y.Symbol);
    }
}

class FunctionComparer : IComparer<Function>
{

    public int Compare(Function x, Function y)
    {
        return string.Compare(x.Name, y.Name);
    }
}


enum Associaivity
{
    Left = 0,
    Right = 1
}

enum Arity
{
    Unary = 1,
    Binary = 2
}

class Operator
{
    public int ID { get; private set; }
    public string Symbol { get; private set; }
    public int Priority { get; private set; }
    public Associaivity Associativity { get; private set; }
    public Arity Arity { get; private set; }

    public Operator(int id, string sym, int prio, Associaivity assoc, Arity ari = Arity.Binary)
    {
        ID = id;
        Symbol = sym;
        Priority = prio;
        Associativity = assoc;
        Arity = ari;
    }
}

class Function
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public int ParametersCount { get; private set; }

    public Function(int id, string name, int paramCnt)
    {
        ID = id;
        Name = name;
        ParametersCount = paramCnt;
    }
}