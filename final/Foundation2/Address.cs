using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // //MI VERSIÓN (Sólo agrega verbosidad)
    // public bool IsInUsa()
    // {
    //     if (_country  != "USA")
    //     {
    //         return true;
    //     }
    //     return false;
    // }

    //CHATGPT (Es más concisa)
    public bool IsInUsa()
    {
        return _country == "USA";
    }


    public string DisplayAdressInformation()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}