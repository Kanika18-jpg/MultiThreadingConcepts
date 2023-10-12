using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingConcepts
{
    internal class MyThreadStartConstructor
    {
        static void Main()
        {
            // Create a new thread and specify the method to be executed
            Thread myThread = new Thread(new ThreadStart(MyThreadFunction));

            // Start the thread
            myThread.Start();

            // Main thread continues to execute here
            Console.WriteLine("Main thread is running.");
            Console.ReadLine();
        }

        static void MyThreadFunction()
        {
            // This method will be executed on a separate thread
            Console.WriteLine("Thread started!");
        }
    }
}
