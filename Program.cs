using System;

class Program
{
    static void Main()
    {
        string? userChoice;
        bool keepRunning = true;

        while (keepRunning)
        {
            // Display the menu
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("1 - New Game");
            Console.WriteLine();
            Console.WriteLine("2 - Load Game");
            Console.WriteLine();
            Console.WriteLine("3 - Options");
            Console.WriteLine();
            Console.WriteLine("4 - Quit");
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.Write("Enter your choice (1-4): ");

            // Read user input
            userChoice = Console.ReadLine();

            // Process user choice
            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Starting New Game...");
                    Console.WriteLine();
                    Console.WriteLine("Welcome to the adventure!");
                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Loading Game...");
                    Console.WriteLine();
                    Console.WriteLine("Game loaded successfully!");
                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Options Menu:");
                    Console.WriteLine();
                    Console.WriteLine("• Sound: ON");
                    Console.WriteLine("• Graphics: HIGH");
                    Console.WriteLine("• Difficulty: NORMAL");
                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    keepRunning = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice!");
                    Console.WriteLine();
                    Console.WriteLine("Please enter 1, 2, 3, or 4.");
                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}