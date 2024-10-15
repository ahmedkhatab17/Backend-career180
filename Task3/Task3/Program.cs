using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the First number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: + , - , * , /");
        char op = Console.ReadLine()[0];

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Error: Invalid operation. Please enter +, -, *, /");
                break;
        }
    }
}
