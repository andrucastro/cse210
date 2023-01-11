using System;

class Program
{
    static void Main(string[] args)
    {
      
        
 
       
        string continueGame = "yes";

        do
        {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);    
        int guess = -1;
        int counter = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    counter += 1;
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                    counter += 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"attempts: {counter}");
                    Console.WriteLine();
                    
                    
                }

            }

            Console.WriteLine("Would you like to play again?");
            continueGame = Console.ReadLine();
    
        }while(continueGame == "yes");

        Console.WriteLine("thank you for playing with us");
    }     
}

