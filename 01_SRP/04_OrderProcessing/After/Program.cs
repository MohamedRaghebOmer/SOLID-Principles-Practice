using System;

public class PriceCalculator
{
    public decimal Calculate(decimal unitPrice, int quantity)
    {
        return unitPrice * quantity;
    }
}

public class PaymentService
{
    public void Capture(string orderId, decimal total)
    {
        Console.WriteLine($"Payment captured for {orderId}: {total:C}");
    }
}

public class InvoiceService
{
    public void Generate(string orderId, decimal total)
    {
        Console.WriteLine($"Invoice generated for {orderId}: {total:C}");
    }
}

public class OrderProcessor
{
    private readonly PriceCalculator _priceCalculator = new PriceCalculator();
    private readonly PaymentService _paymentService = new PaymentService();
    private readonly InvoiceService _invoiceService = new InvoiceService();

    public void Process(string orderId, decimal unitPrice, int quantity)
    {
        decimal total = _priceCalculator.Calculate(unitPrice, quantity);
        _paymentService.Capture(orderId, total);
        _invoiceService.Generate(orderId, total);
    }
}

class Program
{
    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();
        processor.Process("ORD-1001", 99.99m, 2);
    }
}
