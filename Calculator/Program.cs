using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            InputHandler handler = new InputHandler();
            Operations operations = new Operations();

            var userOperationChoice = handler.HandleInputOperator();
            var number1 = handler.HandleInputNumber();
            var number2 = handler.HandleInputNumber();

            Console.WriteLine($"You selected the {userOperationChoice} operation to be performed on numbers {number1} and {number2}.");
            Console.WriteLine($"Your result is: {(operations.OperationHandler(userOperationChoice, number1, number2))}");

            Console.ReadLine();
        }
    }
}
