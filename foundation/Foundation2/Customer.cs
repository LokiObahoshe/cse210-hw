using System;

class Customer {

    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    public override string ToString()
    {
        return $"Address: {_address}";
    }

    public string GetName()
    {
        return _name;
    }
}