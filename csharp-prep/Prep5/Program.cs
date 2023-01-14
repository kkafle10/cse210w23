using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = userName();
        int number = userNumber();
        int square = squareNumber(number);

        displayResult(name, square);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string userName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int userNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void displayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
    }
    
}