using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 100);

       int userGuess = 0;


       do {
    
        Console.Write("What is your guess? ");
        userGuess = int.Parse(Console.ReadLine());

        if (userGuess < magicNumber) {
            Console.WriteLine("Higher");
        } else if (userGuess > magicNumber) {
            Console.WriteLine("Lower");
        } else {
            Console.WriteLine("You guessed it!");
        }
       } while (userGuess != magicNumber);


    }
  
}