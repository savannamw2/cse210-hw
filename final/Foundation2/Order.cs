public class Order 
{
    private Customer customer = new Customer();
    private List<Products> products = new List<Products>();


    public string CustomerName 
    {
        get { return customer.GetName; }  
        set { customer.GetName = value; }  
    }

    public void SetAddress(string address, string city, string state, string country)
    {
        customer.SetAddress(address, city, state, country);
    }


    public string PackageLabel()
    {
        string packageLabel = ""; 
        int order = 1; 

        foreach (Products product in products)
        {
            packageLabel += $"{order}.{product.GetPack()}\n";
            order++; 
        }

        return packageLabel;
    }

    public string GetShippingLabel()
    {
        return$"Name:{customer.GetName}\n{customer.GetAddress()}";
    }

   public double GetShippingCost()
    {
        if (customer.IsUSA())
        {
            return 5;
        } else
        {
            return 35;
        }
    }

    public double GetTotal()
    {
        double overallTotal = 0;

        foreach (Products product in products)
        {
            overallTotal += product.ProductTotal();
        }

        overallTotal += GetShippingCost();

        return overallTotal;
    }

    public void AddList(Products product)
    {
        products.Add(product);
    }

}