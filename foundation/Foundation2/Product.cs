using System;

class Product {

    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        /*
        The total cost of this product is computed by
        multiplying the price per unit and the quantity.
        (If the price per unit was $3 and they bought 5 of them,
        the product total cost would be $15.)
        */

        Console.WriteLine();
    }

    public string GetName()
    {
        Console.WriteLine();
    }

    public string GetProductId()
    {
        Console.WriteLine();
    }
}