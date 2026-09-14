using System;

namespace PackageExpress
{
    // This class contains the Main method where the program starts.
    class Program
    {
        // This is the Main method of the console application.
        static void Main(string[] args)
        {
            // Create an object of the MathClass.
            MathClass math = new MathClass();

            // Call the method using two numbers.
            math.PerformMathOperation(10, 20);

            // Call the method again using named parameters.
            math.performMathoperation(number1:30,number2:40);
    }
}