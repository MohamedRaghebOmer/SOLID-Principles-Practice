using System;

public interface IDiscountStrategy
{
    decimal Calculate(decimal amount);
}

public class RegularDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal amount) => amount * 0.05m;
}

public class PremiumDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal amount) => amount * 0.10m;
}

public class VipDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal amount) => amount * 0.20m;
}

public class DiscountCalculator
{
    public decimal Calculate(decimal amount, IDiscountStrategy strategy)
    {
        return strategy.Calculate(amount);
    }
}

class Program
{
    static void Main()
    {
        DiscountCalculator calculator = new DiscountCalculator();
        Console.WriteLine($"Discount: {calculator.Calculate(1000m, new PremiumDiscount()):C}");
        Console.WriteLine($"Discount: {calculator.Calculate(1000m, new VipDiscount()):C}");
    }
}
