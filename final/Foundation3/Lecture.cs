public class Lecture : Event
{   
    private int capacity = 200; 
    private string speaker = "Malcolm Gladwell";   
    
    
    public Lecture()
    {
        EventTitle = "Choice, Happiness & Spaghetti Sauce";
        EventDescription = "Malcolm Gladwell for TedX";
        EventDate = "Dec 23, 2023"; 
        EventTime = "12: 30 p.m."; 

        SetEventAddress("1234 Horseshoe LN", "Los Angeles", "CA", "USA");
    }

    public string DisplayInformation()
    {
        return($"Speaker: {speaker} - Capacity: {capacity} places");
    }

    public void DisplayFullInformation()
    {
        Console.WriteLine($"\nType of Event: Lectures");
        Console.WriteLine(DisplayInformation());
        Console.WriteLine(DisplayStandardDetails());
    } 

    
}