using System;

class Address {

    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        /*
        The address should have a method that can return
        whether it is in the USA or not.
        */

        return _country.ToUpper() == "USA";
    }

    public override string ToString()
    {
        /*
        The address should have a method to return a string
        all of its fields together in one string
        (with newline characters where appropriate)
        */

        return $"{_address}, {_city}, {_state} {_country}";
    }

}