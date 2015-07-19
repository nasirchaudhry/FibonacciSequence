﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace FibonacciSequence
namespace FibonacciSequence
{
    /// <summary>
    /// In Fibonacci Sequence each new term in the Fibonacci sequence is generated by adding the previous two terms. 
    /// By starting with 1 and 2.
    /// </summary>
    
    //start class Program
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
                Console.WriteLine();
            }

        }

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            // In N steps compute Fibonacci sequence iteratively
            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }// end class Program
}// end namespace FibonacciSequence