﻿using SIngletonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter count = Counter.getInstance;
            Counter c1 = new Counter();
            count.increment();
            count.increment();
            count.decrement();
           
            count.Currentcounter();
            
        }
    }
}

