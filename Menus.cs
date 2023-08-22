using System;

namespace CodingTracker
{
    internal class Menu
    {
        internal void Menu(string name)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.");
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.WriteLine($@"What would you like to focus on today? 
        V - View Previous Games
        A - Addtion
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit the program");
                Console.WriteLine("---------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim())
                {
                    case "v":
                        GetGames();
                        break;
                    case "a":
                        AdditionGame("Addition Game Selected");
                        break;
                    case "s":
                        SubtractionGame("Subtraction Game Selected");
                        break;
                    case "m":
                        MultiplicationGame("Multiplication Game Selected");
                        break;
                    case "d":
                        DivisionGame("Division Game Selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }

    }
}