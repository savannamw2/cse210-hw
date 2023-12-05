public class Event
{
    private string eventTitle;
    
    public string EventTitle   
    {
        get { return eventTitle; }   
        set { eventTitle = value; } 
    }

    private string eventDescription;
    
    public string EventDescription   
    {
        get { return eventDescription; }   
        set { eventDescription= value; } 
    }

    private string eventDate;
    
    public string EventDate  
    {
        get { return eventDate; }   
        set { eventDate = value; } 
    }

    private string eventTime; 
    
    public string EventTime 
    {
        get { return eventTime; }   
        set { eventTime = value; } 
    }

    private Address eventAddress = new Address();

    public void SetEventAddress(string address, string cit, string st, string count)
    {
        eventAddress.SetAddress(address, cit, st, count);
    }

    public string DisplayStandardDetails()
    {
        return($"Event: {eventTitle}\nDescription:{eventDescription} - Date/time : {eventDate} - {eventTime}\n{eventAddress.GetAddress()}");

    }

    public string DisplayShortDescription()
    {
        return($"Event: {eventTitle} - Date:{eventDate}");
    }

     public void DisplayEventType(Event type)
    {
        Console.WriteLine("The type of Event  {0}" , type.GetType());
    }




}