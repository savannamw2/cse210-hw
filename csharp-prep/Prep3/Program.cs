using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);


            

            Console.WriteLine("Guess a positive number between 1-100! ");
            
            string guess = "";

            while (true)
            {   
                Console.WriteLine("What is your guess? ");
                string guessNumber = Console.ReadLine();
                int chance = int.Parse(guessNumber);
                if (number < chance)
                {
                    guess = "Too High";
                    Console.WriteLine($"{guess}");
                }
                else if (number > chance) 
                {
                    guess = "Too Low";
                    Console.WriteLine($"{guess}");

                }
                else 
                {
                Console.WriteLine("You guessed it! ");
                break; 

                }



                
            
            }
        }
    }
}