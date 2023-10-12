using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingConcepts
{
    internal class MyMultiTHread
    {
        public static void Test1()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test1: "+i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2: "+i);

                if (i == 50)
                {
                    Console.WriteLine("Thread is going to Sleep....");
                    Thread.Sleep(6000);
                    Console.WriteLine("Thread woke up.....");
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test3: "+i);
            }
        }
        public static void Main(string[] args)
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);

            T1.Start();
            T2.Start();
            T3.Start();

            Console.WriteLine("The Main Thread is running.......");

            Console.ReadLine();
        }
    }
}
