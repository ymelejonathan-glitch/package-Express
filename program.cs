using System;
namespace PackageExpress
{
class program
{
static void Main(string[] args)
{
// Display the welcome message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
// Display a welcome message and instructions to the user.
// Ask for the package weight
// Display a welcome message and instructions to the user.
Console.WriteLine("Please enter the package weight:");
int weight = Convert.ToInt32(Console.ReadLine());

// Check if the package is too heavy
if (weight > 50)
// Stop the program because the package is too heavy.
// Stop the program because the package is too heavy.
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Ask for the package width
Console.WriteLine("Please enter the package width:");
int width = Convert.ToInt32(Console.ReadLine());
// Stop the program because the package is too heavy.

// Ask for the package height
Console.WriteLine("Please enter the package height:");
int height = Convert.ToInt32(Console.ReadLine());
// Stop the program because the package is too heavy.

// Ask for the package length
Console.WriteLine("Please enter the package length:");
int length = Convert.ToInt32(Console.ReadLine());
// Stop the program because the package is too heavy.

// Check if the total dimensions are greater than 50
if (width + height + length > 50)
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return;

}// Stop the program because the package is too large.
// Calculate the shipping cost
int total = weight * width * height * length;
double shippingCost = (double)total / 100;

Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCost);
// Display the estimated shipping cost to the user.b
}
}
}