using System;

public class OrderProcessor
{
    public void Process(string orderId, decimal unitPrice, int quantity)
    {
        decimal total = unitPrice * quantity;

        // Multiple responsibilities in one class.
        Console.WriteLine($"Order {orderId} total: {total:C}");
        Console.WriteLine($"Payment captured for order {orderId}.");
        Console.WriteLine($"Invoice generated for order {orderId}.");
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
