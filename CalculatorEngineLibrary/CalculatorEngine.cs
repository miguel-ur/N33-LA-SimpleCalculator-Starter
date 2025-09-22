using System;

namespace CalculatorEngineLibrary
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            argOperation = argOperation.ToLower();

            switch (argOperation)
            {
                case "plus":
                case "add":
                case ("+"):
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "minus":
                case "moins":
                case "subtract":
                case ("-"):
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "times":
                case "multiplier":
                case "multiply":
                case ("*"):
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "divide":
                case "diviser":
                case ("/"):
                    result = argFirstNumber / argSecondNumber;
                    break;
            }
              
            return result;
        }
    }
}
