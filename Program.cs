using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*float a = 42;
            float b = 119;
            float c = a + b;
            Console.WriteLine(c);
            Console.ReadKey(); */

            // Declare variables and then initialize to zero
            double num1 = 0; double num2 = 0; double answer;

            // Display  title as the C# console calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            // Ask the user to type the first number
            Console.WriteLine("Type a number and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());
            

            // Ask the user to type the second number
            Console.WriteLine("Type another number and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    answer = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = {answer}");
                    break;
                case "s":
                    answer = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = {answer}");
                    break;
                case "m":
                    answer = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = {answer}");
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor and wait until they do so.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a Non-Zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                    }
                    
                    answer = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = {answer}"); // + (num1 / num2)
                    break;
            }

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }
    }
}
