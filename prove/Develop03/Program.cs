using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference(5,6);
        Scripture scripture = new Scripture();

        bool done = false;

        Console.WriteLine($"{reference.getReference()} {scripture.scripture}");
        while (!done) {
        // Display Reference
            done = true;
            Console.WriteLine();
            // While the user does not enter "q" or "quit", continue to wait 
            // for them to press Enter.
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();
            Console.Clear();  

            for (int i = 0; i < 3; i++)
            {
                scripture.HideWords();
            } 

            if (response == "quit")
            {
                break; // Exit the outer loop when "quit" is entered
            }
            foreach(Word word in scripture.words){
                if (word.isHidden) {
                    // Just display underscores
                    foreach(char character in word.text){
                        Console.Write("_");
                    }
                } 
                else {
                    done = false; 
                    Console.Write(word.text);
                }

                Console.Write(" "); 
            }

        }

        Console.WriteLine("\nCongrats!");
    }
}