public class Address
{
    private string address; 
    private string city; 
    private string state; 
    private string country;

    public Address()
    {}

    public Address(string adr, string cit, string st, string cntry="USA")
    {
        address = adr;
        city = cit;
        state = st;
        country = cntry;
    }

    public string GetAddress()
    {
        return $"Address: {address}, {city}, {state}, {country}";
    }

    public void SetAddress(string adr, string cit, string st, string cntry)
    {
        address = adr; 
        city = cit; 
        state = st; 
        country = cntry; 
    }

     public bool GetUSA() 
    {
        if (country == "USA")
        {
            return true;
        } else
        {
            return false;
        }
    } 



}