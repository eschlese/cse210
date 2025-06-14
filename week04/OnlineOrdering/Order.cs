public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotal()
    {
        double total = 0.0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }

        if (_customer.IsUSAddress())
        {
            total += 5.0; // Flat shipping fee for US addresses
        }
        else
        {
            total += 35.0; // Flat shipping fee for non-US addresses
        }

        return total;
    }

    public string GetPackLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetQuantity()} x {product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShipLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressLabel()}";
    }
}