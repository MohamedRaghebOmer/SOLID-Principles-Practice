using System;

public class InvoiceBuilder
{
    public string Build(decimal amount)
    {
        return $"Invoice Amount: {amount:C}";
    }
}

public class InvoiceStorage
{
    public void Save(string customerEmail, string invoiceText)
    {
        Console.WriteLine($"Invoice saved for {customerEmail}: {invoiceText}");
    }
}

public class InvoiceNotifier
{
    public void SendByEmail(string customerEmail, string invoiceText)
    {
        Console.WriteLine($"Invoice emailed to {customerEmail}: {invoiceText}");
    }
}

public class InvoiceService
{
    private readonly InvoiceBuilder _builder = new InvoiceBuilder();
    private readonly InvoiceStorage _storage = new InvoiceStorage();
    private readonly InvoiceNotifier _notifier = new InvoiceNotifier();

    public void CreateAndSend(string customerEmail, decimal amount)
    {
        string invoiceText = _builder.Build(amount);
        _storage.Save(customerEmail, invoiceText);
        _notifier.SendByEmail(customerEmail, invoiceText);
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
