using System;

class TestApp
{
    static void Main()
    {
        TimerCallback callback = PrintHello;

        Timer timer = new Timer(callback, 1);

        //Call the method PrintHello() every 1 sec
        timer.Start();
    }

    static void PrintHello()
    {
        Console.WriteLine("Hello");
    }
}

