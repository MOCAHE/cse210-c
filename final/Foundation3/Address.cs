using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;

    public Address(string street, string city, string state, int zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string Street { get { return _street; } }
    public string City { get { return _city; } }
    public string State { get { return _state; } }
    public int Zip { get { return _zip; } }

    public override string ToString() //Este metodo viene por defecto segun CHATGPT
    {
        return $"{Street}, {City}, {State}, {Zip}";
    }


}