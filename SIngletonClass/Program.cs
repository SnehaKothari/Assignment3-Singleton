using SIngletonClass;
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
            Counter c1 = Counter.getInstance;
            if (count == c1)
            {
                Console.WriteLine("Singleton Implemented ");
            }
            else
            {
                Console.WriteLine("Singleton not implemented");
            }
            count.increment();
            count.increment();
            count.decrement();
           
            count.Currentcounter();
            
        }
    }
}

