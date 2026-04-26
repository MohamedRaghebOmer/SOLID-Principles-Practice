using System;

public interface IPaymentGateway
{
    void Charge(decimal amount);
}

public class StripeGateway : IPaymentGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"Stripe charged ${amount}.");
    }
}

public class PayPalGateway : IPaymentGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"PayPal charged ${amount}.");
    }
}

public class CheckoutService
{
    private readonly IPaymentGateway _paymentGateway;

    public CheckoutService(IPaymentGateway paymentGateway)
    {
        // High-level module depends on abstraction.
        _paymentGateway = paymentGateway;
    }

    public void Checkout(decimal amount)
    {
        _paymentGateway.Charge(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CheckoutService checkoutService = new CheckoutService(new StripeGateway());
        checkoutService.Checkout(149.99m);

        checkoutService = new CheckoutService(new PayPalGateway());
        checkoutService.Checkout(89.50m);
    }
}
