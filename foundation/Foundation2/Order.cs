using System;

class Order {

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double TotalPrice()
    {
        /*
        The total price is calculated as the sum of
        the total cost of each product plus a one-time
        shipping cost.
        */

        Console.WriteLine();
    }

    public void AddProduct()
    {
        Console.WriteLine();
    }

    public string GetPackingLabel()
    {
        Console.WriteLine();
    }

    public string GetShippingLabel()
    {
        Console.WriteLine();
    }
}