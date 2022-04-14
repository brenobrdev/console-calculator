using System;
namespace Calculator
{
    public class InputHandler
    {
        public string HandleOperator()
        {
            string[] allowedOperators = new string[4] { "+", "-", "*", "/"};

            Console.WriteLine("What operation would you like to perform (+, -, *, /)?");
            string input = Console.ReadLine();

            int inputCheck = Array.IndexOf(allowedOperators, input);

            string operatorChosen = InputChoice(inputCheck);

            return operatorChosen;
        }

        string InputChoice(int userInput)
        {
            switch (userInput)
            {
                case 0:
                    return "Addition";
                case 1:
                    return "Subtraction";
                case 2:
                    return "Multiplication";
                case 3:
                    return "Division";
                default:
                    Console.WriteLine("Please enter a valid operator");
                    this.HandleOperator();
                    return null;
            }
        }

        public int HandleNumber()
        {
            return 0;
        }

    }
}
