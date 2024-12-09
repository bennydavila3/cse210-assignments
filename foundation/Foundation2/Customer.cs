public class Customer
{
    private string _customer;
    private Address _address;

    public Customer(string customer, Address address)
    {
        _customer = customer;
        _address = address;
    }
    public bool USACustomer()
    {
        return _address.USAAddress();
    }
    public double GetShippingCost()
    {
        double shippingCost;
        if(USACustomer())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public string CustomerInfo()
    {
        string fullAddress = _address.GetFullAddress();
        return $"{_customer}\n{fullAddress}";
    }
}