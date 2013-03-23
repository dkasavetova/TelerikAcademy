using System;

class GSMTest
{
    static void Main()
    {
        GSM[] gsmArray = new GSM[4]
        {
            new GSM("Galaxy S3", "Samsung"),
            new GSM("Lumia 620", "Nokia", 324M),
            new GSM("Z10", "Blackberry", 869.70M, "John Doe", new Battery("bbb", 312, 10, BatteryType.LiIon), null),
            new GSM("One", "HTC", 479M, "Pesho", new Battery("someBattery"), new Display(4.7, 16000000))
        };

        foreach (var gsm in gsmArray)
        {
            Console.WriteLine(gsm);
        }

        Console.WriteLine(GSM.IPhone4S);
    }
}

