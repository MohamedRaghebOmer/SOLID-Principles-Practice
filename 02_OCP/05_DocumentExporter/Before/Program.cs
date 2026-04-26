using System;

public enum ExportFormat
{
    Pdf,
    Excel,
    Csv
}

public class DocumentExporter
{
    public void Export(string content, ExportFormat format)
    {
        if (format == ExportFormat.Pdf)
        {
            Console.WriteLine($"Exported PDF: {content}");
        }
        else if (format == ExportFormat.Excel)
        {
            Console.WriteLine($"Exported Excel: {content}");
        }
        else if (format == ExportFormat.Csv)
        {
            Console.WriteLine($"Exported CSV: {content}");
        }
    }
}

class Program
{
    static void Main()
    {
        DocumentExporter exporter = new DocumentExporter();
        exporter.Export("Sales Report", ExportFormat.Pdf);
    }
}
