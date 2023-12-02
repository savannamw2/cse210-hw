public class Products
{
    private string productName; 
    private string productID; 
    private double price; 
    private double quantity; 
    
    public Products(string name, string id, double pri, double quant)
    {
        productName = name; 
        productID = id; 
        price = pri; 
        quantity = quant; 
    }

   public double ProductTotal()
    {
        return price * quantity;  
    } 

    public void SetProduct(string name, string id, double pri, double quant)
    {
        productName = name;
        productID = id;
        price = pri;
        quantity = quant;
    }

    public string GetPack()
    {
        return($"ID/Name: {productID}/{productName}");
    } 
}


