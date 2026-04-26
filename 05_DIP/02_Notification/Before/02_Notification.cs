using System;

public class EmailSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class NotificationService
{
    private readonly EmailSender _emailSender;

    public NotificationService()
    {
        // Direct dependency on concrete low-level module.
        _emailSender = new EmailSender();
    }

    public void Notify(string message)
    {
        _emailSender.Send(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificationService notificationService = new NotificationService();
        notificationService.Notify("Welcome to the system.");
    }
}
