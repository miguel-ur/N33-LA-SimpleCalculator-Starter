using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            if (double.TryParse(argTextInput, out double value))
            {
                return value;
            }

            throw new ArgumentException("Expected a numeric value, but got: " + argTextInput);
        }

        public string GetOperator(string argTextInput)
        {
            switch (argTextInput.ToLower())
            {
                case "plus":
                case "add":
                case "+":
                    return "+";

                case "minus":
                case "subtract":
                case "-":
                    return "-";

                case "times":
                case "multiply":
                case "*":
                    return "*";

                case "divide":
                case "/":
                    return "/";

                default:
                    throw new ArgumentException("Unrecognized operator: " + argTextInput);
            }
        }
    }
}
