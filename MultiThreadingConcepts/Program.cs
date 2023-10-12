using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";

            Console.WriteLine(t.Name);

            Console.ReadLine();
        }
    }
}
