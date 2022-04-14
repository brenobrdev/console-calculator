using System;
namespace Calculator
{
    public class InputHandler
    {
        public string HandleInputOperator()
        {

            Console.WriteLine("What operation would you like to perform (+, -, *, /)?");
            string input = Console.ReadLine();

            string operatorChosen = OperatorInputChoice(input);

            return operatorChosen;

        }

        string OperatorInputChoice(string userInput)
        {
            switch (userInput)
            {
                case "+":
                    return "Addition";
                case "-":
                    return "Subtraction";
                case "*":
                    return "Multiplication";
                case "/":
                    return "Division";
                default:
                    Console.WriteLine("Please enter a valid operator");
                    return HandleInputOperator();
            }
        }

        public float HandleInputNumber()
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            float inputFloat;
            bool isInputValid = float.TryParse(input, out inputFloat);

            if (isInputValid)
            {
                return inputFloat;
            }
            else
            {
                Console.WriteLine("Please enter a numeric value.");
                return HandleInputNumber();
            }
        }

    }
}
