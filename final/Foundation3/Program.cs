using System;

class Program
{
    static void Main(string[] args)
    {
        Event newEvent = new Event();
       
        Lecture newLecture = new Lecture();
        newLecture.DisplayFullInformation();

        Reception newReception = new Reception(); 
        newReception.DisplayFullInformation();

        Outdoor newOutdoor = new Outdoor();
        newOutdoor.DisplayFullInformation(); 

        Console.WriteLine();

        Console.WriteLine(newLecture.DisplayShortDescription());
        Console.WriteLine(newReception.DisplayShortDescription()); 
        Console.WriteLine(newOutdoor.DisplayShortDescription());


    }
}