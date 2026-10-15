namespace _3_TemplateMethod
{

    public class PdfExporter
    {
        public void Export(Report report)
        {
            Console.WriteLine($"📄 Exporting '{report.Title}' to PDF:");
            Console.WriteLine("Fetching data...");
            Console.WriteLine("Formatting as PDF...");
            Console.WriteLine("Saving PDF...");
            Console.WriteLine("Logging...");
            Console.WriteLine("Auditing...\n");
        }
    }
}
