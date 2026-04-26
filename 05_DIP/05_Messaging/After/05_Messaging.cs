using System;

public interface IMessageBroker
{
    void Publish(string message);
}

public class RabbitMqBroker : IMessageBroker
{
    public void Publish(string message)
    {
        Console.WriteLine($"RabbitMQ published: {message}");
    }
}

public class KafkaBroker : IMessageBroker
{
    public void Publish(string message)
    {
        Console.WriteLine($"Kafka published: {message}");
    }
}

public class AlertService
{
    private readonly IMessageBroker _messageBroker;

    public AlertService(IMessageBroker messageBroker)
    {
        _messageBroker = messageBroker;
    }

    public void SendAlert(string message)
    {
        _messageBroker.Publish(message);
    }
}

class Program
{
    static void Main()
    {
        AlertService service = new AlertService(new RabbitMqBroker());
        service.SendAlert("Server CPU is above 90%.");

        service = new AlertService(new KafkaBroker());
        service.SendAlert("Disk space is below 15%.");
    }
}
