public class Outdoor : Event
{
    private string forecast = "Partly Cloudy - Low: 44 Fahrenheit";
    
    public Outdoor()
    {
        EventTitle = "Yoga";
        EventDescription = "Relieve the Stress";
        EventDate = "Dec 16, 2023"; 
        EventTime = "8:00 p.m."; 

        SetEventAddress("BYUI Track", "Rexburg", "ID", "USA");
    }

    public void DisplayFullInformation()
    {
        Console.WriteLine($"\nType of Event: Outdoors");
        Console.WriteLine($"Forecast: {forecast}");
        Console.WriteLine(DisplayStandardDetails());
    }
}