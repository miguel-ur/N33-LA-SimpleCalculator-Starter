using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            if (double.TryParse(argTextInput, out double value))
            {
                return value;
            }

            throw new ArgumentException(Properties.Strings.Expected + argTextInput);
        }

        public static string GetOperator(string argTextInput)
        {
            switch (argTextInput.ToLower())
            {
                case "plus":
                case "add":
                case "+":
                    return "+";

                case "minus":
                case "moins":
                case "subtract":
                case "-":
                    return "-";

                case "times":
                case "multiplier":
                case "multiply":
                case "*":
                    return "*";

                case "divide":
                case "diviser":
                case "/":
                    return "/";

                default:
                    throw new ArgumentException("Unrecognized operator: " + argTextInput);
            }
        }
    }
}
