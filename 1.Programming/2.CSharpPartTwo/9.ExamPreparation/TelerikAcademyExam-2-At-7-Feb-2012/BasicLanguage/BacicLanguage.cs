using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BacicLanguage
{
    static StringBuilder screenBuffer = new StringBuilder();

    static void Main()
    {
        StringBuilder buffer = new StringBuilder();

        bool inBrackets = false;
       

        while (true)
        {
            int chCode = Console.Read();
            if (chCode == -1)
            {
                break;
            }
            char ch = (char)chCode;
            if (ch == '(')
            {
                inBrackets = true;
            }
            else if (ch == ')')
            {
                inBrackets = false;
            }

            if (ch == ';' && !inBrackets)
            {
                string exp = buffer.ToString();
                if (exp.EndsWith("EXIT"))
                {
                    Console.Write(screenBuffer.ToString());
                    return;
                }
                ExecExp(exp);
                buffer.Clear();
            }
            else
            {
                buffer.Append(ch);
            }
        }     
    }

    private static void ExecExp(string exp)
    {
        long cnt = 1;
        string[] expSplitted = exp.Split(new char[]{')'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < expSplitted.Length; i++)
        {
            expSplitted[i] = expSplitted[i].TrimStart();
            if (expSplitted[i][0] != 'P')
            {
                expSplitted[i] = expSplitted[i].TrimEnd();
            }
        }

        if (expSplitted[0][0] == 'F')
        {
            for (int i = 0; i < expSplitted.Length; i++)
            {
                int openBrackedIndex = expSplitted[i].IndexOf('(');
                if (expSplitted[i].StartsWith("FOR"))
                {
                    int commaIndex = expSplitted[i].IndexOf(',');
                    if (commaIndex < 0) // 1 param
                    {
                        string timesStr = expSplitted[i].Substring(openBrackedIndex+1).Trim();
                        cnt *= int.Parse(timesStr);
                    }
                    else // 2param
                    {
                        string startStr = expSplitted[i].Substring(openBrackedIndex + 1, commaIndex - openBrackedIndex-1).Trim();
                        string endStr = expSplitted[i].Substring(commaIndex + 1).Trim();
                        cnt *= int.Parse(endStr) - int.Parse(startStr) + 1;
                    }
                }
                else
                {
                    string toPrint = expSplitted[i].Substring(openBrackedIndex +1);
                    ExecPrint(toPrint, cnt);
                }   
            }
        }
        else if (expSplitted[0][0] == 'P')
        {
            int openBrackedIndex = expSplitted[0].IndexOf('(');
            string toPrint = expSplitted[0].Substring(openBrackedIndex + 1);
            ExecPrint(toPrint, cnt);
        }
        else
        {
            return;
        } 
    }

    private static void ExecPrint(string toPrint, long cnt)
    {
        if (cnt == 1)
        {
            screenBuffer.Append(toPrint);
        }
        else
        {
            for (int i = 0; i < cnt; i++)
            {
                screenBuffer.Append(toPrint);
            } 
        }
    }



    
}

