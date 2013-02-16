using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ad
{
    class Ad
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            int t = 0;
            int a = 0;

            for (int i = 0; i < 4; i++)
            {
                if (str1[i] == 'T') t++;
                else if (str1[i] == 'A') a++;

                if (str2[i] == 'T') t++;
                else if (str2[i] == 'A') a++;

                if (str3[i] == 'T') t++;
                else if (str3[i] == 'A') a++;
            }

            t /= 2;
            Console.WriteLine(Math.Min(t, a));
        }
    }
}
