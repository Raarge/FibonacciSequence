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
                Console.WriteLine(CalculateFibonacci.CalculatFibonacciAt(i));
            }
            Console.Read();
        }
    }
}
