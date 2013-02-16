using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class PHPVariables
{
    static void Main()
    {
        StringBuilder code = new StringBuilder();
        bool inComment = false;
        bool inMultilineComment = false;
        bool inSingleString = false;
        bool inDoubleString = false;
        bool inVariable = false;


        string l;
        StringBuilder currentVariable = new StringBuilder();
        SortedSet<string> variables = new SortedSet<string>();
        while ((l = Console.ReadLine()) != "?>")
        {
           // code.AppendLine(l);
            
            for (int i = 0; i < l.Length; i++)
            {
                if (inComment)
                {
                    //if (l[i] == '\r' && i + 1 < l.Length && l[i + 1] == '\n')
                    //{
                    //    inComment = false;
                    //    i++;
                    //}
                    if (i == l.Length -1)
                    {
                        inComment = false;
                    }
                }
                else if (inMultilineComment)
                {
                    if (l[i] == '*' && i+1 <l.Length && l[i+1] == '/')
                    {
                        inMultilineComment = false;
                        i++;
                    }
                }
                else if (inVariable)
                {
                    if (IsValidVariableChar(l[i]))
                    {
                        currentVariable.Append(l[i]);
                    }
                    else
                    {
                        variables.Add(currentVariable.ToString());
                        currentVariable.Clear();
                        inVariable = false;

                        if (inSingleString)
                        {
                            if (l[i] == '\'')
                            {
                                inSingleString = false;
                            }
                        }
                        else if (inDoubleString)
                        {
                            if (l[i] == '\"')
                            {
                                inDoubleString = false;
                            }
                        }
                    }
                }
                //else if (inSingleString)
                //{
                //    //i tuka barah
                //    if (l[i] == '\"')
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inDoubleString = true;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inDoubleString = true;
                //        }
                //    }
                //    else if (inDoubleString)
                //    {
                //        if (l[i] == '$')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i -2 >= 0 && l[i-2] == '\\')
                //            {
                //                 inVariable = true;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inVariable = true;
                //            }
                //        }
                //        else if (l[i] == '\"')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //            {
                //                inDoubleString = false;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inDoubleString = false;
                //            }
                //        }
                //        else if (l[i] == '\'')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //            {
                //                inSingleString = false;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inSingleString = false;
                //            }
                //        }
                //    }
                //    else if (l[i] == '$')
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inVariable = true;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inVariable = true;
                //        }

                //    }
                //    else if (l[i] == '\'') 
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inSingleString = false;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inSingleString = false;
                //        }
                //    }
                //}
                //else if (inDoubleString)
                //{
                //    //barah tuka
                //    if (l[i] == '\'') 
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inSingleString = true;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inSingleString = true;
                //        }
                //    }
                //    else if (inSingleString)
                //    {
                //        if (l[i] == '$')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //            {
                //                inVariable = true;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inVariable = true;
                //            }
                //        }
                //        else if (l[i] == '\'')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //            {
                //                inSingleString = false;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inSingleString = false;
                //            }
                //        }
                //        else if (l[i] == '\"')
                //        {
                //            if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //            {
                //                inDoubleString = false;
                //            }
                //            else if (i - 1 >= 0 && l[i - 1] != '\\')
                //            {
                //                inDoubleString = false;
                //            }
                //        }
                //    }
                //    else if (l[i] == '$')
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inVariable = true;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inVariable = true;
                //        }

                //    }
                //    else if (l[i] == '\"')
                //    {
                //        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                //        {
                //            inDoubleString = false;
                //        }
                //        else if (i - 1 >= 0 && l[i - 1] != '\\')
                //        {
                //            inDoubleString = false;
                //        }
                //    }
                //}
                else
                {
                    if (l[i] == '/' && i + 1 < l.Length && l[i + 1] == '/')
                    {
                        inComment = true;
                        i++;
                    }
                    else if (l[i] == '#')
                    {
                        inComment = true;
                    }
                    else if (l[i] == '/' && i + 1 < l.Length && l[i + 1] == '*')
                    {
                        inMultilineComment = true;
                        i++;
                    }
                    else if (l[i] == '$')
                    {

                        if (i - 1 >= 0 && l[i - 1] == '\\' && i - 2 >= 0 && l[i - 2] == '\\')
                        {
                            inVariable = true;
                        }
                        else if (i - 1 >= 0 && l[i - 1] != '\\')
                        {
                            inVariable = true;
                        }
                        else if (i == 0)
                        {
                            inVariable = true;
                        }
                    }
                    //else if (l[i] == '\'')
                    //{
                    //    inSingleString = true;
                    //}
                    //else if (l[i] == '\"')
                    //{
                    //    inDoubleString = true;
                    //}
                }
            }

        }
        code.AppendLine("?>");

        //SortedSet<string> variables = new SortedSet<string>();
        //int chCode;
        //while ((chCode = Console.Read()) != -1)
        //{
        //    code.Append((char)(chCode));
        //}
        //Console.Write(code.ToString());

        //SortedSet<string> sortedSet  = new SortedSet<string>();
        //MatchCollection mc = Regex.Matches(code.ToString(), @"\$[A-Za-z0-9_]+");
        //foreach (var item in mc)
        //{
        //    sortedSet.Add(item.ToString());
        //}

        List<string> sortedVariables = variables.ToList();
        sortedVariables.Sort(string.CompareOrdinal);
        Console.WriteLine(sortedVariables.Count);
        foreach (var item in sortedVariables)
        {
            Console.WriteLine(item);
        }

    }

    static bool IsValidVariableChar(char ch)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            return true;
        }
        if (ch >= 'a' && ch <= 'z')
        {
            return true;
        }
        if (ch >= '0' && ch <= '9')
        {
            return true;
        }
        if (ch == '_')
        {
            return true;
        }
        return false;
    }
}

