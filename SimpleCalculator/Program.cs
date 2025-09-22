using System;
using System.Collections.Generic;
using System.Text;
using CalculatorEngineLibrary;
using System.Threading;
using System.Globalization;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Class to perform actual calculations
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            Console.WriteLine("Select language / Sélectionnez la langue (en/fr): ");
            string language = Console.ReadLine().Trim().ToLower();

            if (language == "en")
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-CA");
            else
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-CA");

            // First number
            double firstNumber;
            while (true)
            {
                Console.Write(Properties.Strings.EnterFirstNum);
                string input = Console.ReadLine();

                try
                {
                    firstNumber = InputConverter.ConvertInputToNumeric(input);
                    break; // exit loop once valid
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format(Properties.Strings.InvalidInput, ex.Message));
                }
            }

            // Second number
            double secondNumber;
            while (true)
            {
                Console.Write(Properties.Strings.EnterSecondNum);
                string input = Console.ReadLine();

                try
                {
                    secondNumber = InputConverter.ConvertInputToNumeric(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format(Properties.Strings.InvalidInput, ex.Message));
                }
            }

            // Operator
            string operation = null;
            while (true)
            {
                Console.Write(Properties.Strings.EnterOperation);
                string input = Console.ReadLine();

                try
                {
                    operation = InputConverter.GetOperator(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format(Properties.Strings.InvalidInput, ex.Message));
                }
            }

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            var sb = new StringBuilder();
            sb.AppendFormat(Properties.Strings.Result,
                            firstNumber, operation, secondNumber, result);
            Console.WriteLine(sb.ToString());
        }
    }
}
