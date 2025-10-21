// Import the System namespace so we can use built-in C# features like Console.
using System;

// Define a namespace (like a container for your classes). You can name it anything.
namespace MathOperationApp
{
    // Create a class named MathOperations.
    // This class will contain our custom method that performs a math operation.
    class MathOperations
    {
        // Create a void method (does not return any value).
        // The method takes two integers as parameters.
        public void PerformOperation(int num1, int num2)
        {
            // Perform a simple math operation on the first integer.
            // Here we’ll multiply the first number by 2.
            int result = num1 * 2;

            // Display the result of the operation on the first integer.
            Console.WriteLine("The result of doubling the first number (" + num1 + ") is: " + result);

            // Display the second integer to the screen.
            Console.WriteLine("The second number is: " + num2);
        }
    }

    // The main Program class that will contain the entry point (Main method).
    class Program
    {
        // Main() is where the program starts running.
        static void Main(string[] args)
        {
            // Step 1: Instantiate (create) an object from the MathOperations class.
            // This allows us to use the methods defined inside that class.
            MathOperations mathOp = new MathOperations();

            // Step 2: Call the PerformOperation method, passing in two numbers directly.
            mathOp.PerformOperation(5, 10);

            // Step 3: Call the PerformOperation method again,
            // but this time specify the parameter names for clarity.
            mathOp.PerformOperation(num1: 8, num2: 4);

            // Step 4: Pause the console so the user can see the output before the program closes.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
