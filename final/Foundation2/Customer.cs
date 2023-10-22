using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }

    //NO COMPRENDO CUANDO DEBO USAR GETTER AND SETTER 
    //COMO MÉTODOS Y NO COMO PROPIEDADES. 
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}