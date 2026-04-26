using System;

public interface ICreditCard
{
    void PayWithCreditCard();
}

public interface IPayPal
{
    void PayWithPayPal();
}

public interface IBitCoin
{
    void PayWithBitCoin();
}

public class CreditCardPayment : ICreditCard
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }
}

public class PayPalPayment : IPayPal
{
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }
}

public class BitCoinPayment : IBitCoin
{
    public void PayWithBitCoin()
    {
        Console.WriteLine("Payment with Bit Coin.");
    }
}

public class Program
{
    public static void Main()
    {
        ICreditCard creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();

        IPayPal payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();

        IBitCoin bitCoinPayment = new BitCoinPayment();
        bitCoinPayment.PayWithBitCoin();
    }
}
