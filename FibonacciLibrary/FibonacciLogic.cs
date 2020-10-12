using System;
using log4net;

namespace FibonacciLibrary
{
    public class FibonacciLogic
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public int ComputeFibonacci(int number)
        {
            long number1 = 0;
            long number2 = 1;
            long tempResult = 0;

            if (number == 0 || number == 1)
                return number;

            for (int count = 2; count <= number; count++)
            {
                tempResult = number1 + number2;
                number1 = number2;
                number2 = tempResult;
            }

            try
            {
                return Convert.ToInt32(tempResult);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                return -1;
            }
        }
    }
}
