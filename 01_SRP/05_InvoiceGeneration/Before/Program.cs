using System;

public class InvoiceService
{
    public void CreateAndSend(string customerEmail, decimal amount)
    {
        string invoiceText = $"Invoice Amount: {amount:C}";

        // Multiple responsibilities in one class.
        Console.WriteLine($"Invoice generated: {invoiceText}");
        Console.WriteLine($"Invoice saved for customer: {customerEmail}");
        Console.WriteLine($"Invoice emailed to: {customerEmail}");
    }
}

class Program
{
    static void Main()
    {
        InvoiceService service = new InvoiceService();
        service.CreateAndSend("bob@example.com", 250m);
    }
}
