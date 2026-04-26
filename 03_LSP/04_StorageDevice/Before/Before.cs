using System;

public class StorageDevice
{
    public virtual void Read()
    {
        Console.WriteLine("Reading data...");
    }

    public virtual void Write()
    {
        Console.WriteLine("Writing data...");
    }

    public virtual void Format()
    {
        Console.WriteLine("Formatting storage...");
    }
}

public class ReadOnlyStorage : StorageDevice
{
    public override void Write()
    {
        throw new NotSupportedException("Read-only storage cannot write.");
    }

    public override void Format()
    {
        throw new NotSupportedException("Read-only storage cannot format.");
    }
}

class Program
{
    static void Main()
    {
        StorageDevice device = new ReadOnlyStorage();
        device.Read();
        device.Write(); // LSP violation: substituted type breaks expected behavior.
    }
}
