using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class to convert user input
            InputConverter inputConverter = new InputConverter();

            // Class to perform actual calculations
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            // First number
            double firstNumber;
            while (true)
            {
                Console.Write("Please Enter the first number: ");
                string input = Console.ReadLine();

                try
                {
                    firstNumber = inputConverter.ConvertInputToNumeric(input);
                    break; // exit loop once valid
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}. Try again.");
                }
            }

            // Second number
            double secondNumber;
            while (true)
            {
                Console.Write("Please enter the second number: ");
                string input = Console.ReadLine();

                try
                {
                    secondNumber = inputConverter.ConvertInputToNumeric(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}. Try again.");
                }
            }

            // Operator
            string operation = null;
            while (true)
            {
                Console.Write("Please enter the operation (+, -, *, / or words like plus/minus): ");
                string input = Console.ReadLine();

                try
                {
                    operation = inputConverter.GetOperator(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid operator: {ex.Message}. Try again.");
                }
            }

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            var sb = new StringBuilder();
            sb.AppendFormat("The value {0:F2} {1} the value {2:F2} is equal to {3:F2}",
                            firstNumber, operation, secondNumber, result);
            Console.WriteLine(sb.ToString());
        }
    }
}
