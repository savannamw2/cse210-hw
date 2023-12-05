public class Reception : Event 
{ 
    private string email = "livelaughlove1234@gmail.com";

    public Reception()
    {
        EventTitle = "The wedding of Jane Doe and John Doe";
        EventDescription = "Wedding Recption";
        EventDate = " Dec 18, 2023"; 
        EventTime = " 4:00 p.m."; 

        SetEventAddress("1234 3rd St", "Washougal", "WA", "USA");
    }

    public void DisplayFullInformation()
    {
        Console.WriteLine($"\nType of Event: Receptions");
        Console.WriteLine($"RVSP email:{email}");
        Console.WriteLine(DisplayStandardDetails());
    }

}