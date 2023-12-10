class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalCost()
    {
        double TotalPrice = products.Sum(product => product.GetTotalPrice());
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return TotalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return customer.GetFullAddress();
    }
}