using System;

class OnTheBeach
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split();
        string[] b = Console.ReadLine().Split();

        int asth = int.Parse(a[0]);
        int astm = int.Parse(a[1]);
        int aeth = int.Parse(a[2]);
        int aetm = int.Parse(a[3]);
        int bsth = int.Parse(b[0]);
        int bstm = int.Parse(b[1]);
        int beth = int.Parse(b[2]);
        int betm = int.Parse(b[3]);

        if (Compare(bsth, bstm, asth, astm) <= 0 && Compare(beth, betm, asth, astm) >= 0 && Compare(beth, betm, aeth, aetm) <= 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", asth, astm, beth, betm);
        }
        else if (Compare(bsth, bstm, asth, astm) >= 0 && Compare(bsth, bstm, aeth, aetm) <= 0 && Compare(beth, betm, aeth, aetm) >= 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", bsth, bstm, aeth, aetm);
        }
        else if (Compare(bsth, bstm, asth, astm) >= 0 && Compare(bsth, bstm, aeth, aetm) < 0 && Compare(beth, betm, aeth, aetm) <= 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", bsth, bstm, beth, betm);
        }
        else if (Compare(bsth, bstm, asth, astm) <= 0 && Compare(beth, betm, aeth, aetm) >= 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", asth, astm, aeth, aetm);
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static int Compare(int h1, int m1, int h2, int m2)
    {
        if (h1 > h2)
        {
            return 1;
        }
        else
        {
            if (h1 == h2)
            {
                if (m1 > m2)
                {
                    return 1;
                }
                else
                {
                    if (m1 < m2)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return -1;
            }
        }
    }
}


