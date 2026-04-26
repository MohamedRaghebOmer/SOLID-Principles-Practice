using System;

public class LocalDiskBackup
{
    public void Save(string data)
    {
        Console.WriteLine($"Saved to local disk: {data}");
    }
}

public class BackupService
{
    private readonly LocalDiskBackup _localDiskBackup;

    public BackupService()
    {
        // Direct dependency on a concrete storage implementation.
        _localDiskBackup = new LocalDiskBackup();
    }

    public void Backup(string data)
    {
        _localDiskBackup.Save(data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BackupService backupService = new BackupService();
        backupService.Backup("orders-2026-04-26.zip");
    }
}
