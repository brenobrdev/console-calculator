using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            InputHandler handler = new InputHandler();
            Operations operations = new Operations();

            var userOperationChoice = handler.HandleOperator();

            Console.WriteLine(userOperationChoice);

            Console.ReadLine();
        }
    }
}
