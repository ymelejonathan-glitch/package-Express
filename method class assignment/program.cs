using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathClass
            MathClass math = new MathClass();

            // Call the method using positional parameters
            math.PerformMathOperation(10, 20);

            // Call the method using named parameters
            math.PerformMathOperation(number1: 30, number2: 40);
        }
    }
}