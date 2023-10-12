using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingConcepts
{
    internal class THreadLocking
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayMessage);
            Thread t2 = new Thread(DisplayMessage);
            Thread t3 = new Thread(DisplayMessage);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.Read();
        }

        private static readonly object LockDisplayMethod = new object();
        static void DisplayMessage()
        {
            lock (LockDisplayMethod)
            {
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of IT!]");
            }
        }
    }
}
/* Here's what happens:

All three threads start concurrently.
One of the threads (whichever is scheduled 
first by the operating system) acquires the 
lock and enters the locked block.
It writes "[Welcome to the " to the console and then sleeps for 1 second.
While the first thread is sleeping,
other threads wait because they cannot acquire the lock (LockDisplayMethod).
After the sleep, the first thread continues by printing "world of dotnet!]"
to the console and then releases the lock.
Once the first thread releases the lock, 
the next waiting thread acquires it and enters the locked block, and the process repeats.
 * 
 * 
 * 
 * 
 * 
 */
