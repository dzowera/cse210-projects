using System;


public class Customer
{
    private string name;
    private Address address;

    public Customer(string aName, Address aAddress)
    {
        name = aName;
        address = aAddress;
    }

    public bool LivesInUSA()
    {
        return address.IsUSA();
    }

    public string GetName()
    {
        return name;
    }

    public string GetCustomerAddress()
    {
        return address.GetFullAddress();
    }
}
