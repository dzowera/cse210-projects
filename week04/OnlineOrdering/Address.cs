using System;
 
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string aStreet, string aCity, string aState, string aCountry)
    {
        street = aStreet;
        city = aCity;
        state = aState;
        country = aCountry;
    }

    public bool IsUSA()
    {
        if (country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}
