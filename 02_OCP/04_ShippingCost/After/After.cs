using System;

public interface IShippingCostStrategy
{
    decimal Calculate(decimal weightKg);
}

public class StandardShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg) => 5m + weightKg * 1.5m;
}

public class ExpressShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg) => 10m + weightKg * 2.5m;
}

public class InternationalShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg) => 25m + weightKg * 4m;
}

public class ShippingCostCalculator
{
    public decimal Calculate(decimal weightKg, IShippingCostStrategy strategy)
    {
        return strategy.Calculate(weightKg);
    }
}

class Program
{
    static void Main()
    {
        ShippingCostCalculator calculator = new ShippingCostCalculator();
        Console.WriteLine($"Shipping: {calculator.Calculate(3.2m, new ExpressShipping()):C}");
        Console.WriteLine($"Shipping: {calculator.Calculate(3.2m, new InternationalShipping()):C}");
    }
}
