using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            for(var i = 0; i <= 10; i++)
            {
                var fib = CalculateFibonacci.CalculatFibonacciAt(i);
                Console.WriteLine("The Fibonacci number at position " + i + " is " + fib + "; It took " + Globals.fibCount + " calls to fib to get here. ");
            }
            Console.Read();
        }
    }
}
