using System;

public class RabbitMqClient
{
    public void Publish(string message)
    {
        Console.WriteLine($"RabbitMQ published: {message}");
    }
}

public class AlertService
{
    private readonly RabbitMqClient _rabbitMqClient;

    public AlertService()
    {
        // High-level module depends directly on low-level implementation.
        _rabbitMqClient = new RabbitMqClient();
    }

    public void SendAlert(string message)
    {
        _rabbitMqClient.Publish(message);
    }
}

class Program
{
    static void Main()
    {
        AlertService service = new AlertService();
        service.SendAlert("Server CPU is above 90%.");
    }
}
