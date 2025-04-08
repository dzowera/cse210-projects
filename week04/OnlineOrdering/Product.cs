using System;

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string pName, string pId, double pPrice, int pQuantity)
    {
        name = pName;
        productId = pId;
        price = pPrice;
        quantity = pQuantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetProductInfo()
    {
        return name + " (ID: " + productId + ")";
    }
}
