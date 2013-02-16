using System;

class Lines
{
    static void Main()
    {
        byte[] arr = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            arr[i] = byte.Parse(Console.ReadLine());

        }
        #region FirstAttempt

        int k = 0;

        int[,] max = new int[2, 8];
        int[,] cnt = new int[2, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 7; j >= 0; j--)
            {
                if (BitCheck(arr[i], j))
                {
                    k++;
                    if (k > max[0, i])
                    {
                        max[0, i] = k;
                        cnt[0, i] = 1;
                    }
                    else if (k == max[0, i])
                    {
                        cnt[0, i]++;
                    }
                }
                else
                {
                    k = 0;
                }
            }
            k = 0;
        }

        k = 0;
        for (int j = 7; j >= 0; j--)
        {
            for (int i = 0; i < 8; i++)
            {
                if (BitCheck(arr[i], j))
                {
                    k++;
                    if (k > max[1, j])
                    {
                        max[1, j] = k;
                        cnt[1, j] = 1;
                    }
                    else if (k == max[1, j])
                    {
                        cnt[1, j]++;
                    }
                }
                else
                {
                    k = 0;
                }
            }
            k = 0;
        }


        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 7; j >= 0; j--)
        //    {
        //        Console.Write((BitCheck(arr[i], j) ? 1 : 0) + " ");

        //    }
        //    Console.Write("  " + max[0, i] + " " + cnt[0, i]);
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 7; i >= 0; i--)
        //{
        //    Console.Write(max[1, i] + " ");
        //}
        //Console.WriteLine();
        //for (int i = 7; i >= 0; i--)
        //{
        //    Console.Write(cnt[1, i] + " ");
        //}
        //Console.WriteLine();


        int m = -1;
        int c = -1;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (max[i, j] > m)
                {
                    m = max[i, j];
                    //c = 1;
                    c = cnt[i, j];
                }
                else if (max[i, j] == m)
                {
                    //c++;
                    c += cnt[i, j];
                }
            }
        }
        if (m == 1)
        {
            c = c / 2;
        }

        Console.WriteLine("{0}\n{1}", m, c);
        #endregion


    }

    static bool BitCheck(byte b, int pos)
    {
        bool result = (b & (1 << pos)) != 0;
        return result;
    }
}

