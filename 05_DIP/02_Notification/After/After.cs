using System;

public interface INotificationSender
{
    void Send(string message);
}

public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class PushSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent: {message}");
    }
}

public class NotificationService
{
    private readonly INotificationSender _notificationSender;

    public NotificationService(INotificationSender notificationSender)
    {
        // High-level module depends on abstraction.
        _notificationSender = notificationSender;
    }

    public void Notify(string message)
    {
        _notificationSender.Send(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificationService service = new NotificationService(new EmailSender());
        service.Notify("Welcome to the system.");

        service = new NotificationService(new SmsSender());
        service.Notify("Your OTP is 1248.");

        service = new NotificationService(new PushSender());
        service.Notify("A new message arrived.");
    }
}
