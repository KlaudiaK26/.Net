using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            while (true)
            {
                Console.WriteLine("\nChoose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tp - Check if a number is Prime");
                Console.Write("Your option? ");
                string option = Console.ReadLine(); // reads the user input and stores it in the option variable

                if (option == "p")
                {
                    Console.Write("Enter a number to check if it's prime: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        if (number <= 1)
                        {
                            Console.WriteLine("A prime number must be greater than 1.");
                        }
                        else if (IsPrime(number))
                        {
                            Console.WriteLine($"{number} is a prime number.");
                        }
                        else
                        {
                            Console.WriteLine($"{number} is not a prime number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                    continue; 
                }

                Console.Write("Type the first number and press Enter: ");
                if (!int.TryParse(Console.ReadLine(), out int input1))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                Console.Write("Type the second number and press Enter: ");
                if (!int.TryParse(Console.ReadLine(), out int input2))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                switch (option)
                {
                    case "a":
                        Console.WriteLine($"Result: {input1} + {input2} = {input1 + input2}");
                        break;
                    case "s":
                        Console.WriteLine($"Result: {input1} - {input2} = {input1 - input2}");
                        break;
                    case "m":
                        Console.WriteLine($"Result: {input1} * {input2} = {input1 * input2}");
                        break;
                    case "d":
                        if (input2 != 0)
                        {
                            Console.WriteLine($"Result: {input1} / {input2} = {(double)input1 / input2}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown option.");
                        break;
                }
            }
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
