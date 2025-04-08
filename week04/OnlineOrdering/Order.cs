using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer aCustomer)
    {
        customer = aCustomer;
        products = new List<Product>();
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product item in products)
        {
            total = total + item.GetTotalCost();
        }

        double shippingCost;

        if (customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product item in products)
        {
            label = label + "- " + item.GetProductInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label = label + customer.GetName() + "\n";
        label = label + customer.GetCustomerAddress();

        return label;
    }
}
