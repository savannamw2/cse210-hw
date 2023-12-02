public class Customer 
{
    private string name; 
   private Address custAddress = new Address();

    public string GetName  
    {
        get { return name; }  
        set { name = value; }  
    }

    public string GetAddress()
    {
        return custAddress.GetAddress();
    }

    public void SetAddress(string address, string city, string state, string country)
    {
        custAddress.SetAddress(address, city, state, country);
    }


    public bool IsUSA()
    {
        return custAddress.GetUSA();
    }

}