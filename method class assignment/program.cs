using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {// Create an Employee object.
Employee employee = new Employee();

// Use polymorphism to create an IQuittable reference to the Employee object.
IQuittable quittable = employee;

// Call the Quit method through the IQuittable interface.
quittable.Quit();
            // Instantiate the MathClass
            MathClass math = new MathClass();

            // Call the method using positional parameters
            math.PerformMathOperation(10, 20);

            // Call the method using named parameters
            math.PerformMathOperation(number1: 30, number2: 40);
        }
    }
}