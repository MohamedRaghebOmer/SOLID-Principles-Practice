using System;

public enum ShippingMethod
{
    Standard,
    Express,
    International
}

public class ShippingCostCalculator
{
    public decimal Calculate(decimal weightKg, ShippingMethod method)
    {
        if (method == ShippingMethod.Standard)
        {
            return 5m + weightKg * 1.5m;
        }

        if (method == ShippingMethod.Express)
        {
            return 10m + weightKg * 2.5m;
        }

        if (method == ShippingMethod.International)
        {
            return 25m + weightKg * 4m;
        }

        return 0m;
    }
}

class Program
{
    static void Main()
    {
        ShippingCostCalculator calculator = new ShippingCostCalculator();
        Console.WriteLine($"Shipping: {calculator.Calculate(3.2m, ShippingMethod.Express):C}");
    }
}
