using System;

// The Employee class implements the IQuittable interface.
public class Employee : IQuittable
{
    // This method implements the Quit method required by IQuittable.
    public void Quit()
    {
        // Display a message when the employee quits.
        Console.WriteLine("The employee has quit.");
    }
}