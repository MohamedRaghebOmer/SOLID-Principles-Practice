using System;
using System.Collections.Generic;

public sealed class PaymentService
{
    private readonly IPayment _payment;

    public void Pay(decimal amount)
    {
        _payment.Pay(amount);
    }

    public PaymentService(IPayment payment)
    {
        this._payment = payment;
    }
}

public interface IPayment
{
    void Pay(decimal amount);
}

public class PayPal : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("PayPal: Amount:[{0:C}] paid successfully.", amount);
    }
}

public class CreditCard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("CreditCard: Amount:[{0:C}] paid successfully.", amount);
    }
}

public class BankTransfer : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("BankTransfer: Amount:[{0:C}] paid successfully.", amount);
    }
}

public class BitCoin : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("BitCoin: Amount:[{0:C}] paid successfully.", amount);
    }
}

internal class PaymentServiceExample
{
    static void Main(string[] args)
    {
        // PayPal Payment
        PaymentService paymentService = new PaymentService(new PayPal());
        paymentService.Pay(100m);

        // Credit Card Payment
        paymentService = new PaymentService(new CreditCard());
        paymentService.Pay(100m);

        // Bank Transfer Payment
        paymentService = new PaymentService(new BankTransfer());
        paymentService.Pay(100m);

        // Bit Coin Payment
        paymentService = new PaymentService(new BitCoin());
        paymentService.Pay(100m);
    }
}