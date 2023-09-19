using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string UserName = PromptUserName();
        int UserNum = PromptUserNumber(); 
        int SquaredNum = SquareNumber(UserNum);

        DisplayResult(UserName, SquaredNum);
    }
    
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
    Console.Write("Please enter your name? ");
    string name = Console.ReadLine();
    return name; 
    }

    static int PromptUserNumber()
    {
    Console.Write("Please enter your favorite number? ");  
    int number = int.Parse(Console.ReadLine());
    return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number; 
        return square; 
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square root of your number is {square}");
    }
}