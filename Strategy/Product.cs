// 上下文類別(Context)，用來操作策略
public class Product
{
    private readonly IPricingStrategy _pricingStrategy;

    public string Name { get; set; }

    public decimal Price { get; private set; }

    public Product(string name, decimal price, IPricingStrategy pricingStrategy)
    {
        this.Name = name;
        this.Price = price;
        this._pricingStrategy = pricingStrategy;
    }

    public decimal GetPrice()
    {
        return _pricingStrategy.CalculatePrice(Price);
    }
}