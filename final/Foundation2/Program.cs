using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(); 
        order1.CustomerName = "Savanna Mays";
        order1.SetAddress("555 Gum Drop Lane", "North Pole", "Wonderland", "USA");

        Products product1 = new Products("Dyson Hair Wrap", "101", 599.99, 1);
        Products product2 = new Products("Sol De Janiero", "102", 45.00, 3); 
        Products product3 = new Products("Sony Headphones", "103", 249.99, 1); 

        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);

        Order order2 = new Order(); 
        order2.CustomerName = "Chase Whittaker"; 
        order2.SetAddress("2867 Wildflower Rd", "Mystic Falls", "Magnolia", "UK"); 

        Products product4 = new Products("Coach Bracelet", "201", 154.99, 1); 
        Products product5 = new Products("Coach Purse", "202", 249.00, 2);
        Products product6 = new Products("Free People Top", "203", 59.99, 2 ); 
        Products product7 = new Products("Steve Madden Boots", "204", 170.99, 1); 

        order2.AddList(product4);
        order2.AddList(product5);
        order2.AddList(product6);
        order2.AddList(product7); 

        Console.WriteLine("Order 1:");

        Console.WriteLine($"Packing Label\n{order1.PackageLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}\n");

        Console.WriteLine("Order 2:");

        Console.WriteLine($"Packing Label\n{order2.PackageLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}\n");

    }
}