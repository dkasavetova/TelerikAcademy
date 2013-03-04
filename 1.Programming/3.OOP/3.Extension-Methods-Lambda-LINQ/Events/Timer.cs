﻿using System;
using System.Threading;

public delegate void EventHandler(object sender, EventArgs args);

public class Timer
{
    private int interval = 0;
    private bool terminated = false;

    public event EventHandler Tick;

    public int Interval
    {
        get
        {
            return this.interval;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("interval", "value must be greater than 1");
            }

            this.interval = value;
        }
    }

    protected virtual void OnTick(EventArgs args)
    {
        EventHandler handler = Tick;

        if (handler != null)
        {
            handler(this, args);
        }
    }

    public void Start() {

        //the timer is running in a new thread
        Thread newThread = new Thread(delegate()
        {
            while (true)
            {
                if (terminated == false)
                {
                    OnTick(null);
                }
                else
                {
                    break;
                }

                Thread.Sleep(interval);
            }
        });
        newThread.Start();  
    }

    public void Stop()
    {
        this.terminated = true;
    }
}

