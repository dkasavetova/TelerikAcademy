using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Crossword
{
    static int n;
    static string[] words;
    //static string[] crossword;

    //static int[] inputSet;
    static int[] variationElements;
    static int k;

    static bool solutionFound = false;

    static void Main()
    {
        ReadInput();
        k = n;
        variationElements = new int[k];
        Var(0);
        if (!solutionFound)
        {
            Console.WriteLine("NO SOLUTION!");
        }

    }

    static void ReadInput()
    {
        n = int.Parse(Console.ReadLine());
        words = new string[2 * n];
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = Console.ReadLine();
        }
        Array.Sort(words);
        //crossword = new string[n];
    }

    static void Var(int pos)
    {
        if (solutionFound)
        {
            return;
        }
        if (pos >= k)
        {
            OnVariationReady(pos);
            return;
        }

        for (int i = 0; i < words.Length; i++)
        {
            variationElements[pos] = i;
            Var(pos + 1);
        }
    }

    //static bool IsFormingVerticalWords(int index)
    //{
    //    Console.WriteLine(index);
    //    StringBuilder[] vWordStart = new StringBuilder[n];
    //    for (int i = 0; i < n; i++)
    //    {
    //        vWordStart[i] = new StringBuilder();
    //    }
    //    //ne konstruira pravilono dumite po vertikala
    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = 0; j <= index; j++)
    //        {
    //            vWordStart[i].Append(words[variationElements[j]][i]);
    //        }
    //    }
        
    //    int flag = 0;

    //    for (int j = 0; j < n; j++)
    //    {
    //        for (int i = 0; i < words.Length; i++)
    //        {
    //            if (words[i].StartsWith(vWordStart[j].ToString()))
    //            {
    //                flag += 1 << j;
    //                break;
    //            }
    //        }
    //    }

    //    return flag == (1 << n) - 1;
    //}
   

    static void OnVariationReady(int pos)
    {
        StringBuilder[] vWord = new StringBuilder[n];
        for (int i = 0; i < n; i++)
        {
            vWord[i] = new StringBuilder();
        }

        for (int i = 0; i < pos; i++)
        {
            for (int j = 0; j < n; j++)
            {
                vWord[i].Append(words[variationElements[j]][i]);
            }
            //Console.Write(variationElements[i] + " ");
            //Console.Write(words[variationElements[i]] + " ");
        }

        for (int i = 0; i < vWord.Length; i++)
        {
            if (Array.BinarySearch(words, vWord[i].ToString()) < 0)
            {
                return;
            }
        }
        solutionFound = true;
        for (int i = 0; i < pos; i++)
        {
            Console.WriteLine(words[variationElements[i]]);
        }
    }

}

