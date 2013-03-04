using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public delegate void TimerCallback();

public class Timer
{
    //Fields
    private TimerCallback callback;
    private int interval;

    //Constructors
    public Timer(TimerCallback callback, int interval)
    {
        this.callback = callback;
        this.interval = interval;
    }

    //Methods
    public void Start()
    {
        while (true)
        {
            callback.Invoke();
            Thread.Sleep(interval * 1000);
        }
    }
}

