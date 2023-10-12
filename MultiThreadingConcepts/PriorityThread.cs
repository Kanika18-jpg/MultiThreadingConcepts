using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingConcepts
{
    internal class PriorityThread
    {
        public static long count1, count2;
        public static void increment1()
        {
            while (true)
            {
            count1++;

            }

        }
        public static void increment2()
        {
            while(true)
            {
            count2++;

            }

        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(increment1);
            Thread t2 = new Thread(increment2);
            t1.Start();
            t2.Start();
            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;

            Console.WriteLine("Count1: "+count1);
            Console.WriteLine("Count2: "+count2);
        }

    }
}
