public class Order
{
    private Customer _customer;
    private List<Products> _products;

    public Order(Customer customer, List<Products> products)
    {
        _customer = customer;
        _products = products;
    }
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Products products in _products)
        {
            totalPrice += products.CalculateTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label\n";
        foreach (Products products in _products)
        {
            packingLabel += $"{products.GetName()} (ID: {products.GetId()}) - Quantity: {products.GetQuantity()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label\n";
        shippingLabel += $"Customer: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetAddressFormatted()}";
        shippingLabel += $"Address: {_customer.GetAddress().GetAddressFormatted()}";
        return shippingLabel;
    }






}