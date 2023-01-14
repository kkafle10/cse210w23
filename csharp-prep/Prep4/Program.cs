using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput = 1;

        do 
        {

            Console.WriteLine("Enter a number: ");

            string userAnswer = Console.ReadLine();
            userInput = int.Parse(userAnswer);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } 
        while(userInput != 0);

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            
        }

    }
}