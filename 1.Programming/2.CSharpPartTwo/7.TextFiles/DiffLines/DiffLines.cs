using System;
using System.IO;

class DiffLines
{
    static void Main()
    {
        string firstFile = "test.000.0.in.txt";
        string secondFile = "test.000.1.in.txt";

        int sameCnt = 0;
        int diffCnt = 0;

        using (StreamReader firstReader = new StreamReader(firstFile))
        {
            using (StreamReader secondReader = new StreamReader(secondFile))
            {
                string lineFromFirst, lineFromSecond;

                while ((lineFromFirst = firstReader.ReadLine()) != null)
                {
                    lineFromSecond = secondReader.ReadLine();

                    if (lineFromFirst == lineFromSecond)
                    {
                        sameCnt++;
                    }
                    else
                    {
                        diffCnt++;
                    }
                }
                
            }
        }

        Console.WriteLine("Same: " + sameCnt);
        Console.WriteLine("Diff: " + diffCnt);
    }
}

