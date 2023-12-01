// 策略介面(IStrategy)
public interface IPricingStrategy
{
    decimal CalculatePrice(decimal rawPrice);
}