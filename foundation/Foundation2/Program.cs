using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("CherryRoad", "Detroit", "Michigan", "USA");
        Address notUsaAddress = new Address("PeachRoad", "Calgary", "Alberta", "Canada");
        Address usaAddress2 = new Address("PearRoad", "New York City", "New York", "USA");
        Address notUsaAddress2 = new Address("AppleRoad", "Florence", "Italy", "Europe");
        
        Customer customerInUsa = new Customer("William Afton", usaAddress);
        Customer customerNotInUsa = new Customer("John Wick", notUsaAddress);
        Customer customerinUsa2 = new Customer("Caesar Salad", usaAddress2);
        Customer customerNotInUsa2 = new Customer("Bean-E-boo", notUsaAddress2);

        Product chair = new Product("Chair", 18437849, 100, 1);
        Product table = new Product("Table", 79494905, 200, 2);
        Product veggieBurger = new Product("Veggie Burger", 63810436, 5, 1);

        Order order1 = new Order(customerInUsa);
        order1.AddProduct(chair);

        Order order2 = new Order(customerNotInUsa);
        order2.AddProduct(table);
        
        Order order3 = new Order(customerinUsa2);
        order3.AddProduct(veggieBurger);
        order3.AddProduct(chair);

        Order order4 = new Order(customerNotInUsa2);
        order4.AddProduct(chair);
        order4.AddProduct(table);
        order4.AddProduct(veggieBurger);
        
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order1.TotalPrice():F2}");

        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order2.TotalPrice():F2}");

        Console.WriteLine();
        Console.WriteLine("Order 3:");
        Console.WriteLine($"Packing Label:{order3.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:{order3.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order3.TotalPrice():F2}");

        Console.WriteLine();
        Console.WriteLine("Order 4:");
        Console.WriteLine($"Packing Label:{order4.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:{order4.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order4.TotalPrice():F2}");

        Console.WriteLine("\nThank you for your order!\n");

    }
}