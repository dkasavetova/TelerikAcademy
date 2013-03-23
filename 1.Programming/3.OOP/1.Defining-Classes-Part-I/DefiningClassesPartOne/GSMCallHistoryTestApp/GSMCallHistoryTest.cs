using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class GSMCallHistoryTest
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        GSM gsm = new GSM("Galaxy S3", "Samsung");

        gsm.AddCall(new Call(DateTime.Now, "5551337", 150));
        gsm.AddCall(new Call(DateTime.Now.AddDays(-1), "5551337", 230));
        gsm.AddCall(new Call(new DateTime(2013, 2, 19), "5551337", 420));

        foreach (var call in gsm.CallHistory)
        {
            Console.WriteLine(call);
        }

        Console.WriteLine("{0:C}", gsm.CalculateCallsPrice(0.37M));

        
        //get the longest call;
        Call maxCall = gsm.CallHistory.Where(x => x.Duration == gsm.CallHistory.Max(y => y.Duration)).Single();

        //remove the longest call from the call history
        gsm.RemoveCall(maxCall);

        //print the total price without the longest call
        Console.WriteLine("{0:C}", gsm.CalculateCallsPrice(0.37M));

        gsm.ClearCallHistory();

        foreach (var call in gsm.CallHistory)
        {
            Console.WriteLine(call);
        }
    }
}

