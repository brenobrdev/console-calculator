using System;
namespace Calculator
{
    public class Operations
    {
        public float OperationHandler(string operatorSelected, float num1, float num2)
        {
            float result = 0f;

            switch (operatorSelected)
            {
                case "Addition":
                    result = Addition(num1, num2);
                    break;
                case "Subtration":
                    result = Subtraction(num1, num2);
                    break;
                case "Multiplication":
                    result = Multiplication(num1, num2);
                    break;
                case "Division":
                    result = Division(num1, num2);
                    break;
                default:
                    break;
            }

            return result;
        }

        public float Addition(float a, float b)
        {
            return a + b;
        }

        public float Subtraction(float a, float b)
        {
            return a - b;
        }

        public float Multiplication(float a, float b)
        {
            return a * b;
        }

        public float Division(float a, float b)
        {
            return a / b;
        }
    }
}
