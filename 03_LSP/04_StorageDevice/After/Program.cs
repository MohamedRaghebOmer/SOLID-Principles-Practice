using System;

public interface IReadableStorage
{
    void Read();
}

public interface IWritableStorage
{
    void Write();
}

public interface IFormattableStorage
{
    void Format();
}

public class ReadOnlyStorage : IReadableStorage
{
    public void Read()
    {
        Console.WriteLine("Reading data from read-only storage...");
    }
}

public class FlashStorage : IReadableStorage, IWritableStorage, IFormattableStorage
{
    public void Read()
    {
        Console.WriteLine("Reading data from flash storage...");
    }

    public void Write()
    {
        Console.WriteLine("Writing data to flash storage...");
    }

    public void Format()
    {
        Console.WriteLine("Formatting flash storage...");
    }
}

class Program
{
    static void Main()
    {
        IReadableStorage readOnly = new ReadOnlyStorage();
        readOnly.Read();

        FlashStorage flash = new FlashStorage();
        flash.Read();
        flash.Write();
        flash.Format();
    }
}
