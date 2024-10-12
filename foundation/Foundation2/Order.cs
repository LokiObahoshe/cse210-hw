using System;
using System.Collections.Generic;

class Order {

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public double TotalPrice()
    {
        /*
        The total price is calculated as the sum of
        the total cost of each product plus a one-time
        shipping cost.
        */

        double totalPrice = 0;

        foreach (var product in _products)
        {
            totalPrice += product.TotalCost();
        }

        if (_customer.IsInUsa())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label ="";

        foreach (var product in _products)
        {
            label += $" || Product: {product.GetName()}, ID: {product.GetProductId()}";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $" || Customer: {_customer.GetName()} || {_customer}";
    }
}