using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BasicBASIC
{
    static Dictionary<char, int> vars = new Dictionary<char, int>(5);
    static List<string[]> lines = new List<string[]>(10000);
    static Dictionary<string, int> linesDict = new Dictionary<string, int>(10000);
    static StringBuilder screenBuffer = new StringBuilder(20000);
    static int lineNumber = 0;
    static bool isStopped = false;
   

    static void Main()
    {
        Init();

        for (lineNumber = 0; lineNumber < lines.Count; lineNumber++)
        {
            if (isStopped)
            {
                break;
            }
            ExecuteExpression(lines[lineNumber][1]);
        }

            Console.WriteLine(screenBuffer.ToString());
       
    }

    static void ExecuteExpression(string exp)
    {
        if (vars.ContainsKey(exp[0])) //Variable Asignment
        {
            int equalsIndex = exp.IndexOf('=');
            vars[exp[0]] = ArithmeticExpression(exp.Substring(equalsIndex + 1));
            //Console.WriteLine("--- " + line[0] + " = " + vars[line[0]]);
        }
        else if (exp[0] == 'I') //Conditional Expression
        {
            int conditionStartIndex = 2;
            int conditionEndIndex = exp.IndexOf("THEN") - 1;
            int conditionLength = conditionEndIndex - conditionStartIndex + 1;
            string condition = exp.Substring(conditionStartIndex, conditionLength);

            int commandStartIndex = conditionEndIndex + 5;
            string command = exp.Substring(commandStartIndex);

            if (BooleandExpression(condition))
            {
                ExecuteExpression(command);
            }
        }
        else if (exp[0] == 'G') // GOTO
        {
            int bla = int.Parse(exp.Substring(4));
            int djv = linesDict[bla.ToString()];
            lineNumber = djv - 1;//-1 cos of lineNumber++ int the for loop
        }
        else if (exp[0] == 'P')
        {
            screenBuffer.Append(ArithmeticExpression(exp.Substring(5)));
            screenBuffer.Append("\r\n");
        }
        else if (exp[0] == 'C')
        {
            screenBuffer.Clear();
        }
        else if (exp[0] == 'S')
        {
            isStopped = true;
            return;
        }

    }

    static bool BooleandExpression(string exp)
    {
        int arg0 = 0, arg1 = 0;
        //string[] splitExp = Regex.Split(exp, @"((?<=[<>=])|(?=[<>=]))").Where(x => x != "").ToArray();

        List<string> splitExp = exp.Split(new char[] { '<', '>', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        int equalsIndex = exp.IndexOf('=');
        if (equalsIndex >= 0)
        {
            splitExp.Insert(1, "=");
        }
        else
        {
            int lessThanIndex = exp.IndexOf('<');
            if (lessThanIndex >= 0)
            {
                splitExp.Insert(1, "<");
            }
            else
            {
                int greaterThanIndex = exp.IndexOf('>');
                if (greaterThanIndex >= 0)
                {
                    splitExp.Insert(1, ">");
                }
            }
        }


        if (vars.ContainsKey(splitExp[0][0]))
        {
            if (vars.ContainsKey(splitExp[2][0]))
            {
                arg0 = vars[splitExp[0][0]];
                arg1 = vars[splitExp[2][0]];
            }
            else 
            {
                arg0 = vars[splitExp[0][0]];
                arg1 = int.Parse(splitExp[2]);
            }  
        }
        else
        {
            if (vars.ContainsKey(splitExp[2][0]))
            {
                arg0 = int.Parse(splitExp[0]);
                arg1 = vars[splitExp[2][0]];
            }
            else
            {
                arg0 = int.Parse(splitExp[0]);
                arg1 = int.Parse(splitExp[2]);
            }
        }

        switch (splitExp[1])
        {
            case "=":
                return arg0 == arg1;
            case "<":
                return arg0 < arg1;
            case ">":
                return arg0 > arg1;
            default:
                return false;
        }
    }

    static int ArithmeticExpression(string exp)
    {
        int val = 0;
        int index = 0;
        List<string> splitExp = exp.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        int plusIndex = exp.IndexOf('+');
        if (plusIndex >= 0)
        {
            splitExp.Insert(1, "+");
        }
        else
        {
            int minusIndex = exp.IndexOf('-');
            if (minusIndex == 0)
            {
                splitExp.Insert(0, "-");
            }
            else if (minusIndex > 0)
            {
                splitExp.Insert(1, "-");
            }
        }


        if (splitExp.Count == 1)
        {
            if (vars.ContainsKey(splitExp[0][0]))
            {
                return vars[splitExp[0][0]];
            }
            return int.Parse(splitExp[0]);
        }
      
        if (vars.ContainsKey(splitExp[0][0])) // first elem is variable
        {
            index = 1;
            val += vars[splitExp[0][0]];
        }
        else if (splitExp[0] == "-")//there is prefix - before the first elem
        {
            index = 2;
            if (vars.ContainsKey(splitExp[1][0])) //the first elem is variable
            {
                val -= vars[splitExp[1][0]];
            }
            else
            {
                val -= int.Parse(splitExp[1]); //the first elem is value
            }
        }
        else  //first elem is value
        {
            index = 1;
            val += int.Parse(splitExp[0]);
           
        }

        if (splitExp.Count > 2) // there is a second term
        {
            if (splitExp[index] == "-") //-
            {
                if (vars.ContainsKey(splitExp[index+1][0])) 
                {
                    val -= vars[splitExp[index + 1][0]];
                }
                else
                {
                    val -= int.Parse(splitExp[index + 1]); 
                }
            }
            else //+
            {
                if (vars.ContainsKey(splitExp[index + 1][0]))
                {
                    val += vars[splitExp[index + 1][0]];
                }
                else
                {
                    val += int.Parse(splitExp[index + 1]);
                }
            }
        }
        return val;
    }

    static void Init()
    {
        string line = Console.ReadLine();
        int l = 0;
        while (line != "RUN")
        { 
            string[] splittedLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < splittedLine.Length; i++)
            {
                sb.Append(splittedLine[i]);
            }

            lines.Add(new string[] {splittedLine[0], sb.ToString()});

            linesDict.Add(splittedLine[0], l++);
            
            line = Console.ReadLine();
        }

        for (int i = 'V'; i <= 'Z'; i++)
        {
            vars.Add((char)i, 0);
        }
    }

}

