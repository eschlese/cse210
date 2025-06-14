public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotal()
    {
        return _price * _quantity;
    }
}