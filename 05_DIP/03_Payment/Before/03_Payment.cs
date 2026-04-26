using System;

public class StripeGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"Stripe charged ${amount}.");
    }
}

public class CheckoutService
{
    private readonly StripeGateway _stripeGateway;

    public CheckoutService()
    {
        // Direct dependency on concrete payment gateway.
        _stripeGateway = new StripeGateway();
    }

    public void Checkout(decimal amount)
    {
        _stripeGateway.Charge(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CheckoutService checkoutService = new CheckoutService();
        checkoutService.Checkout(149.99m);
    }
}
