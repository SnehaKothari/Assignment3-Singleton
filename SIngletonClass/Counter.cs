using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIngletonClass
{
    public sealed class Counter
    {
        private static int count1 = 0;
        static int count = 0;
        private static Counter instance = null;
        //default
        private Counter()
        {
          
        }
        //static
        static Counter()
        {
            count1++;
            Console.WriteLine("Value: "+count1);
        }
       public static Counter getInstance
        {
            get
            {
                if (instance == null)
                    instance = new Counter();
                return instance;
            }
        }
        public void increment()
        {
            count = count + 1;
            Console.WriteLine("Increment value:" + count);
        }
        public void decrement()
        {
            count = count - 1;
            Console.WriteLine("Decrement value:" + count);
        }
        public void Currentcounter()
        {
            Console.WriteLine("Current count is: " + count);
        }
    }
}
