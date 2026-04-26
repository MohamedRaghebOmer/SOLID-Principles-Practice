using System;

public enum CustomerType
{
    Regular,
    Premium,
    Vip
}

public class DiscountCalculator
{
    public decimal Calculate(decimal amount, CustomerType customerType)
    {
        if (customerType == CustomerType.Regular)
        {
            return amount * 0.05m;
        }

        if (customerType == CustomerType.Premium)
        {
            return amount * 0.10m;
        }

        if (customerType == CustomerType.Vip)
        {
            return amount * 0.20m;
        }

        return 0m;
    }
}

class Program
{
    static void Main()
    {
        DiscountCalculator calculator = new DiscountCalculator();
        Console.WriteLine($"Discount: {calculator.Calculate(1000m, CustomerType.Premium):C}");
    }
}
