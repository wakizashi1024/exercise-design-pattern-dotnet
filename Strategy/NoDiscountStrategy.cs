// 實現介面的具體策略類別(XxxStrategy)
public class NoDiscountStragegy : IPricingStrategy 
{
    public decimal CalculatePrice(decimal rawPrice)
    {
        return rawPrice;
    }
}