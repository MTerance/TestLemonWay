using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLemonWay.Logic
{
    public class FibonacciLogic
    {
        public int ComputeFibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;
            return ComputeFibonacci(number - 1) + ComputeFibonacci(number - 2);
        }
    }
}
