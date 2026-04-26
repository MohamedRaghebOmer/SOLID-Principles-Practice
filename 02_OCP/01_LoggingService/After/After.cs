using System;

public sealed class LoggingService<T>
{
    private readonly ILogger<T> _logger;

    public void Log(T value)
    {
        _logger.Log(value);
    }

    public LoggingService(ILogger<T> logger)
    {
        this._logger = logger;
    }
}

public interface ILogger<T>
{
    void Log(T value);
}

public class FileLogger<T> : ILogger<T>
{
    // Method to log to file
    public void Log(T value)
    {
        Console.WriteLine("\nLog to file: {0}", value?.ToString());
    }
}

public class EventViewerLogger<T> : ILogger<T>
{
    // Method to log to EventLog
    public void Log(T value)
    {
        Console.WriteLine("\nLog to Event Log: {0}", value?.ToString());
    }
}

public class DatabaseLogger<T> : ILogger<T>
{
    // Method to log to file
    public void Log(T value)
    {
        Console.WriteLine("\nLog to Database: {0}", value?.ToString());
    }
}

class Program
{
    static void Main()
    {
        // Log to file
        LoggingService<string> fileServiceLogger = new LoggingService<string>(new FileLogger<string>());
        fileServiceLogger.Log("This message will be logged in a file");

        // Log to viewer
        LoggingService<string> eventViewerServiceLogger = new LoggingService<string>(new EventViewerLogger<string>());
        eventViewerServiceLogger.Log("This message will be logged windows viewer.");

        // Log to database
        LoggingService<string> dbServiceLogger = new LoggingService<string>(new DatabaseLogger<string>());
        dbServiceLogger.Log("This message will be logged windows viewer.");
    }
}
