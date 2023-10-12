using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingConcepts
{
    internal class JoinMethod
    {
        public static void Test1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2: " + i);

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
                Console.WriteLine("Test3: " + i);
            }
        }
        public static void Main(string[] args)
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);

            Console.WriteLine("The Main Thread started.....");

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join(3000);
            T2.Join();
            T3.Join();

            Console.WriteLine("The Main Thread is exited.......");

            Console.ReadLine();
        }
}
}

/*The Join method makes the main thread wait until the thread it's called on (in this case, T1, T2, or T3)
    completes its work. 
    This ensures that the main thread won't exit until all three threads have finished.

 Join method with a timeout for T1, which makes the main thread wait for T1 to complete but with a maximum 
wait time of 3000 milliseconds (3 seconds). After that, T2 and T3 will continue to run concurrently.
 
 This code snippet results in the main thread waiting for T1 for a maximum of 3 seconds, and if T1 does not complete within that time, the main thread 
proceeds to the next Join. However, T2 and T3 will continue running regardless of whether T1 has completed or not.
 
 */