using System;

class PrintFormatedNumber
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:d}", num);
        Console.WriteLine("{0,15:x}", num);
        Console.WriteLine("{0,15:p}", num);
        Console.WriteLine("{0,15:e}", num);
    }
}

