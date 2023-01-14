using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 10);

        bool keepPlaying = true;

        
        while(keepPlaying) {
            Console.Write("Guess a number between 1 and 10: ");
            string userInput = Console.ReadLine();
            int userGuess = int.Parse(userInput);

            if (magicNumber == userGuess) {
                Console.WriteLine("Nice! You guessed it!");
                keepPlaying = false;
            }
            else if(magicNumber > userGuess) {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Lower");
            }
        
        }

    }
}