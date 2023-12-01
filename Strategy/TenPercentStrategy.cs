// 實現介面的具體策略類別(XxxStrategy)
public class TenPercentDiscountStrategy : IPricingStrategy
{
    public decimal CalculatePrice(decimal rawPrice)
    {
        return rawPrice * (decimal)0.9;
    }
}