using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            argOperation = argOperation.ToLower();

            switch (argOperation)
            {

                case ("+"):
                    result = argFirstNumber + argSecondNumber;
                    break;

                case ("-"):
                    result = argFirstNumber - argSecondNumber;
                    break;

                case ("*"):
                    result = argFirstNumber * argSecondNumber;
                    break;

                case ("/"):
                    result = argFirstNumber / argSecondNumber;
                    break;
            }
              
            return result;
        }
    }
}
