using System;

public interface IPhone
{
    void MakeCall();
}

public interface IMail
{
    void SendEmail();
}

public interface ICamera
{
    void TakePhoto();
}

public interface ITracker
{
    void UseGPS();
}

public interface ISmartPhone : IPhone, IMail, ICamera, ITracker { }

public class Smartphone : ISmartPhone
{
    public void MakeCall()
    {
        Console.WriteLine("Making a call.");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

    public void UseGPS()
    {
        Console.WriteLine("Using GPS.");
    }
}

public class Program
{
    public static void Main()
    {
        ISmartPhone smartphone = new Smartphone();
        Console.WriteLine("SmartPhone:");
        smartphone.MakeCall();
        smartphone.TakePhoto();
        smartphone.SendEmail();
        smartphone.UseGPS();

        ITracker tracker = new Smartphone();
        Console.WriteLine("\nTracker:");
        tracker.UseGPS();
    }
}