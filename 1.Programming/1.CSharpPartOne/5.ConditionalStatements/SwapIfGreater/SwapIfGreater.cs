using System;

class SwapIfGreater
{
    static void Main()
    {
        int first = 40;
        int second = 10;

        if (first > second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}

