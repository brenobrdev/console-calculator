using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler handler = new InputHandler();
            Operations operations = new Operations();

            var userOperationChoice = handler.HandleOperator();
        }
    }
}
