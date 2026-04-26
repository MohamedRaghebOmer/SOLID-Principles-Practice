using System;

public interface IBackupStorage
{
    void Save(string data);
}

public class LocalDiskBackup : IBackupStorage
{
    public void Save(string data)
    {
        Console.WriteLine($"Saved to local disk: {data}");
    }
}

public class CloudBackup : IBackupStorage
{
    public void Save(string data)
    {
        Console.WriteLine($"Saved to cloud storage: {data}");
    }
}

public class BackupService
{
    private readonly IBackupStorage _backupStorage;

    public BackupService(IBackupStorage backupStorage)
    {
        // High-level module depends on abstraction.
        _backupStorage = backupStorage;
    }

    public void Backup(string data)
    {
        _backupStorage.Save(data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BackupService backupService = new BackupService(new LocalDiskBackup());
        backupService.Backup("orders-2026-04-26.zip");

        backupService = new BackupService(new CloudBackup());
        backupService.Backup("users-2026-04-26.zip");
    }
}
