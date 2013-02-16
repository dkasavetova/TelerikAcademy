//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class BasicLanguage
//{
//    static StringBuilder input = new StringBuilder(100000);
//    static StringBuilder output = new StringBuilder(100000);
//    static string[] lines;
//    static bool isFinished = false;

//    static void Main()
//    {
//        Init();
//        for (int i = 0; i < lines.Length; i++)
//        {
//            Exec(lines[i]);
//        }
//        Console.WriteLine(output.ToString());
//    }

//    private static void Init()
//    {
        
//        while (true)
//        {
//            string line = Console.ReadLine();
//            input.Append(line);

//            if (line.EndsWith("EXIT;"))
//            {
//                break;
//            }
//            else
//            {
//                input.Append("\r\n");
//            }
//        }

//        lines = input.ToString().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

//        bool insideBrackets = false;
       
//        for (int i = 0; i < lines.Length; i++)
//        {
//            StringBuilder trimmedLine = new StringBuilder(lines[i].Length);
//            for (int j = 0; j < lines[i].Length; j++)
//            {
//                if (lines[i][j] == '(')
//                {
//                    insideBrackets = true;
//                }
//                else if (lines[i][j] == ')')
//                {
//                    insideBrackets = false;
//                }

//                if (insideBrackets == true)
//                {
//                    trimmedLine.Append(lines[i][j]);
//                }
//                else
//                {
//                    if (lines[i][j] != ' ' && lines[i][j] != '\r' && lines[i][j] != '\n')
//                    {
//                        trimmedLine.Append(lines[i][j]);
//                    }
//                }
//            }
//            lines[i] = trimmedLine.ToString();
//        }

       

//    }

//    static void ExecPrint(int cnt, string str)
//    {
//        for (int i = 0; i < cnt; i++)
//        {
//            //output.Append(str);
//            foreach (var item in str)
//            {
//                output.Append(item);
//            }
//        }
//    }

////    static void Exec(string exp)
////    {
////        if (exp[0] == 'F')
////        {
////            //int s = 4;
////            //int e = exp.IndexOf(')');
////            //int l = e - s;
////            //string[] vals = exp.Substring(s, l).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
////            //string newExp = exp.Substring(e + 1);

////            //if (vals.Length == 1)
////            //{
////            //    int end = int.Parse(vals[0]);
////            //    for (int i = 1; i <= end; i++)
////            //    {
////            //        Exec(newExp);
////            //    }
////            //}
////            //else
////            //{
////            //    int start = int.Parse(vals[0]);
////            //    int end = int.Parse(vals[1]);

////            //    for (int i = start; i <= end; i++)
////            //    {
////            //        Exec(newExp);
////            //    }
////            //}

////            int cnt = 1;
////            int s = 0, e = -1, l = 0;
////            while (true)
////            {
////                s = exp.IndexOf("FOR(", e + 1);
////                if (s < 0)
////                {
////                    //find what to print here
////                    int ps = exp.IndexOf("PRINT(", e + 1);
////                    if (ps >= 0)
////                    {

////                        ps = ps + 6;
////                        int pe = exp.IndexOf(')', ps);
////                        int len = pe - ps;
////                        string str = exp.Substring(ps, len);
////                        ExecPrint(cnt, str);
////                    }
////                    //else no print statement

////                    break;
////                }
////                else
////                {
////                    s = s + 4;
////                    e = exp.IndexOf(')', s);
////                    l = e - s;
////                    string[] vals = exp.Substring(s, l).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
////                    if (vals.Length == 1)
////                    {
////                        int times = int.Parse(vals[0]); // what if FOR(0);??
////                        cnt *= times;
////                    }
////                    else
////                    {
////                        int start = int.Parse(vals[0]);
////                        int end = int.Parse(vals[1]);
////                        int times = end - start + 1;

////                        cnt *= times;
////                    }
////                }

////            }

////        }
////        else if (exp[0] == 'P')
////        {
////            string bla = exp.Substring(6, exp.Length - 7);
////            foreach (var item in bla)
////            {
////                output.Append(item);
////            }

            
////        }
////        else if (exp[0] == 'E')
////        {
////            isFinished = false;
////            return;
////        }
////        else
////        {
////            return;
////        }
////    }
//}

