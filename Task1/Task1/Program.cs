using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sing in or Sing up to Continue!");

        Console.WriteLine("=== Register ===");
        Console.Write("Enter a username: ");
        string registeredUsername = Console.ReadLine();

        Console.Write("Enter a password: ");
        string registeredPassword = Console.ReadLine();

        Console.WriteLine("Registration complete!\n");


        Console.WriteLine("=== Login ===");
        Console.Write("Enter your username: ");
        string loginUsername = Console.ReadLine();

        Console.Write("Enter your password: ");
        string loginPassword = Console.ReadLine();


        if (loginUsername == registeredUsername && loginPassword == registeredPassword)
        {
            Console.WriteLine("\nLogin successful!");
        }
        else
        {
            Console.WriteLine("\nInvalid username or password.");
        }
    }
}
