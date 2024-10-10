using System;

class Address {

    private string _Address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Address, string city, string state, string country)
    {
        _Address = Address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IfInUsa()
    {
        /*
        The address should have a method that can return
        whether it is in the USA or not.
        */

        Console.WriteLine();
    }

    public string GetDisplayText()
    {
        /*
        The address should have a method to return a string
        all of its fields together in one string
        (with newline characters where appropriate)
        */

        Console.WriteLine();
    }

}