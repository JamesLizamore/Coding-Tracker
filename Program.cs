// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CodingTracker;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please write your name:");
    var name = Console.ReadLine();
    return name;
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("-------------------------");
    foreach(var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("-------------------------\n");
    Console.WriteLine("Press any key to return to the Main Menu");
    Console.ReadLine();
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {score}. Press any key to go back to they main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Addition");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score={gameScore}");
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {score}. Press any key to go back to they main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Substraction");
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {   
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {score}. Press any key to go back to they main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Multiplication");
}
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {score}. Press any key to go back to they main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Division");
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);
    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;


    return result;


}
