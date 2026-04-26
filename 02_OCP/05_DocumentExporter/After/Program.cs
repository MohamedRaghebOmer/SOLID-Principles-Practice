using System;

public interface IDocumentExportStrategy
{
    void Export(string content);
}

public class PdfExportStrategy : IDocumentExportStrategy
{
    public void Export(string content) => Console.WriteLine($"Exported PDF: {content}");
}

public class ExcelExportStrategy : IDocumentExportStrategy
{
    public void Export(string content) => Console.WriteLine($"Exported Excel: {content}");
}

public class CsvExportStrategy : IDocumentExportStrategy
{
    public void Export(string content) => Console.WriteLine($"Exported CSV: {content}");
}

public class DocumentExporter
{
    public void Export(string content, IDocumentExportStrategy strategy)
    {
        strategy.Export(content);
    }
}

class Program
{
    static void Main()
    {
        DocumentExporter exporter = new DocumentExporter();
        exporter.Export("Sales Report", new PdfExportStrategy());
        exporter.Export("Inventory", new CsvExportStrategy());
    }
}
