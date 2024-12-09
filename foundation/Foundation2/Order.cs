public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateSubtotal()
    {
        double subtotal = 0;
        foreach(Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            subtotal += productPrice;
        }
        subtotal = Math.Round(subtotal, 2);
        return subtotal;
    }
    public double CalculateTotalCost()
    {
        double subtotal = CalculateSubtotal();
        double shippingCost = _customer.GetShippingCost();
        return Math.Round(subtotal + shippingCost, 2);
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("PACKING LABEL:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInfo());
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(_customer.CustomerInfo());
    }
}