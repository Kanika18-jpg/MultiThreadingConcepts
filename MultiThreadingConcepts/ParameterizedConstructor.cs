using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingConcepts
{
    internal class ParameterizedConstructor
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(square));
            t.Start(5);
            Console.WriteLine("Main Thread......");
            Console.ReadLine();
        }

        private static void square(object obj)
        {
            if (obj is int number)
            {
                int result = number * number;
                Console.WriteLine($"The square of {number} is {result}");
            }
        }

       
    }
}

/* we pass an object as an argument to the method (Square) because the ParameterizedThreadStart delegate requires
 * the thread's entry point method to take a single parameter of type object.
 * This design allows you to pass any type of data to the thread method.
 * However, you would typically cast and use the object parameter as the appropriate data type within the method.

Here's why ParameterizedThreadStart takes an object:

Flexibility: It provides flexibility by allowing you to pass different types of data to the thread method.
Since object is the most general type in C#, you can pass any object as the parameter.

Common Denominator: object serves as a common denominator for different data types. 
This is especially useful when you have a method that can accept various types of data, and you want to use it with the ParameterizedThreadStart constructor.

However, the use of object can lead to type safety issues because the compiler won't catch type mismatches. 
Inside the method, you need to cast the object to the correct data type, and if the cast is incorrect, 
it can lead to runtime exceptions.
 * 
 * 
 */


