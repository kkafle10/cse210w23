using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine() ?? "";
        int grade = int.Parse(userInput);
        string letter;


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You got an {letter}.");
        }
        else 
        {
            Console.WriteLine($"You got a {letter}.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass! All the best for next time!");
        }

    }
}