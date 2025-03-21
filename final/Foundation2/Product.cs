public class Products
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Products(string name, string id, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _price;
    } 





}