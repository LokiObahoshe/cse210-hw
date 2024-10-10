using System;

class Customer {

    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Address()
    {
        //Call to address
    }

    public string GetDisplayText()
    {
        Console.WriteLine();
    }

    public string GetName()
    {
        Console.WriteLine();
    }
}