public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

     public string GetAddress()
    {
        return($"Address: {street}, {city}, {state}, {country}");

    }

    public void SetAddress(string address, string cit, string st, string count)
    {
        street = address;
        city = cit;
        state = st;
        country = count;
    }


}