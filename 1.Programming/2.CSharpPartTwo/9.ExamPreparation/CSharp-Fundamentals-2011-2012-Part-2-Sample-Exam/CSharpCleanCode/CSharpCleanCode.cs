using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class CSharpCleanCode
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        StringBuilder code = new StringBuilder();

        bool inComment = false;
        bool inString = false;
        bool inMultilineComment = false;
        bool inMultilineString = false;
        bool inXMLDoc = false;

        for (int i = 0; i < n; i++)
        {
            string l = Console.ReadLine();

            for (int j = 0; j < l.Length; j++)
            {

                if (inComment)
                {
                    if (j == l.Length - 1)
                    {
                        inComment = false;
                    }
                }
                else if (inString)
                {
                    if (l[j] == '\"' && j - 1 >= 0 && l[j - 1] != '\\')
                    {
                        inString = false;
                    }
                    code.Append(l[j]);
                }
                else if (inMultilineComment)
                {
                    if (l[j] == '*' && j + 1 < l.Length && l[j + 1] == '/')
                    {
                        inMultilineComment = false;
                        j++;
                    }
                }
                else if (inMultilineString)
                {
                    if (l[j] == '\"' && j + 1 < l.Length && l[j + 1] != '\"')
                    {
                        inMultilineString = false;
                        code.Append(l[j]);
                        j++;
                        code.Append(l[j]);
                    }
                    else if (l[j] == '\"' && j + 1 < l.Length && l[j + 1] == '\"')
                    {
                        code.Append(l[j]);
                        j++;
                        code.Append(l[j]);
                    }
                    else
                    {
                        code.Append(l[j]);
                    }
                }
                else if (inXMLDoc)
                {
                    code.Append(l[j]);
                    if (j == l.Length - 1)
                    {
                        inXMLDoc = false;
                    }
                }
                else
                {
                    // //-yes but ///-no
                    if (l[j] == '/' && j + 1 < l.Length && l[j + 1] == '/' && j + 2 < l.Length && l[j + 2] == '/')
                    {
                        inXMLDoc = true;
                        code.Append(l[j]);
                    }
                    else if (l[j] == '/' && j + 1 < l.Length && l[j + 1] == '/')
                    {
                        inComment = true;
                    }
                    else if (l[j] == '/' && j + 1 < l.Length && l[j + 1] == '*')
                    {
                        inMultilineComment = true;
                        j++;
                    }
                    else if (l[j] == '\"' && j-1 >=0 && l[j-1] != '\\')
                    {
                        inString = true;
                        code.Append(l[j]);
                    }
                    else if (l[j] == '@')
                    {
                        inMultilineString = true;
                        code.Append(l[j]);
                        if (j + 1 < l.Length)
                        {
                            code.Append(l[j + 1]);
                        }
                        j++;
                    }
                    else
                    {
                        code.Append(l[j]);
                    }
                }

                if (j == l.Length - 1 && !inMultilineComment)
                {
                    code.AppendLine();
                }
            }
        }

        string[] lines = code.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in lines)
        {
            if (!string.IsNullOrWhiteSpace(item))
            {
                Console.WriteLine(item);
            }
            
        }
    }
        
}


