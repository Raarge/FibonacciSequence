using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public static class CalculateFibonacci
    {
        
        public static int CalculatFibonacciAt(int numOfFibonacci)
        {
            Globals.fibCount = Globals.fibCount + 1;

            if (numOfFibonacci < 2)
                return numOfFibonacci;
            else
            {
                return CalculatFibonacciAt(numOfFibonacci - 2) + CalculatFibonacciAt(numOfFibonacci - 1);
            }
        }
    }
}
